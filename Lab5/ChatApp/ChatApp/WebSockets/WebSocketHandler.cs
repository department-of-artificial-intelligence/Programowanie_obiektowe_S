using System.Net.WebSockets;
using System.Text;

public abstract class WebSocketHandler
{
    protected ConnectionManager _webSocketConnectionManager;

    protected WebSocketHandler(ConnectionManager webSocketConnectionManager)
    {
        _webSocketConnectionManager = webSocketConnectionManager;
    }

    public async virtual Task OnConnected(WebSocket socket)
    {
        _webSocketConnectionManager.AddSocket(socket);
    }

    public virtual async Task OnDisconnected(WebSocket socket)
    {
        await _webSocketConnectionManager.RemoveSocket(_webSocketConnectionManager.GetId(socket));
    }
    public async Task SendMessageAsync(WebSocket socket, string message)
    {
        if (socket.State != WebSocketState.Open) return;
        await socket.SendAsync(buffer: new ArraySegment<byte>(array: Encoding.ASCII.GetBytes(message), offset: 0,
        count: message.Length), messageType: WebSocketMessageType.Text, endOfMessage: true,
        cancellationToken: CancellationToken.None);
    }

    public async Task SendMessageAsync(string socketId, string message)
    {
        await SendMessageAsync(_webSocketConnectionManager.GetSocketById(socketId), message);
    }

    public async Task SendMessageToAllAsync(string message)
    {
        foreach (var socket in _webSocketConnectionManager.Sockets)
        {
            if (socket.Value.State == WebSocketState.Open) await SendMessageAsync(socket.Value, message);
        }
    }

    public abstract Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer);
}