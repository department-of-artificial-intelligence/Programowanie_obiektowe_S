using System.Net.WebSockets;
using System.Text;

public class ChatMessageHandler : WebSocketHandler
{
    public ChatMessageHandler(ConnectionManager webSocketConnectionManager)
    : base(webSocketConnectionManager) { }

    public override async Task OnConnected(WebSocket socket)
    {
        await base.OnConnected(socket);
        var socketId = _webSocketConnectionManager.GetId(socket); await SendMessageToAllAsync($"{socketId} connected");
    }

    public override async Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
    {
        var socketId = _webSocketConnectionManager.GetId(socket);
        var message = $"{socketId}: {Encoding.UTF8.GetString(buffer, 0, result.Count)}"; await SendMessageToAllAsync(message);
    }
}