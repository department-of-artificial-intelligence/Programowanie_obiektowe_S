using System.Net.Sockets;
using System.Net.WebSockets;
using System;

public class WebSocketManagerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly WebSocketHandler _webSocketHandler;

    public WebSocketManagerMiddleware(RequestDelegate next, WebSocketHandler webSocketHandler)
    {
        _next = next;
        _webSocketHandler = webSocketHandler;
    }
    public async Task Invoke(HttpContext context)
    {
        if (!context.WebSockets.IsWebSocketRequest) return;
        var socket = await context.WebSockets.AcceptWebSocketAsync(); await _webSocketHandler.OnConnected(socket);

        await Receive(socket, async (result, buffer) =>
        {
            switch (result.MessageType)
            {
                case WebSocketMessageType.Text:
                    await _webSocketHandler.ReceiveAsync(socket, result, buffer); return;
                case WebSocketMessageType.Close:
                    await _webSocketHandler.OnDisconnected(socket); return;

            }
        });
    }

private async Task Receive(WebSocket socket, Action<WebSocketReceiveResult, byte[]> handleMessage)
    {
        var buffer = new byte[1024 * 4];
        while (socket.State == WebSocketState.Open)
        {
            var result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None); handleMessage(result, buffer);
        }
    }