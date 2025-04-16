var uri = `ws://${window.location.host}/ws`; function connect() {
    socket = new WebSocket(uri); socket.onopen = function (event) {
        console.log(`opened connection to ${uri}`);
    };
    socket.onclose = function (event) {
        console.log(`closed connection from ${uri}`);
    };
    socket.onmessage = function (event) {
        let li = $(`<li><span>${event.data}</span></li>`);
        $(".chat-container #messages").append(li);
        console.log(event.data);
    };
    socket.onerror = function (event) {
        console.log("error: " + event.data);
    };
}
connect();
$(".chat-container button#send-btn").click(function () {
    let messageTxt = $("#msg-txt").val(); console.log("Sending: " + messageTxt); socket.send(messageTxt);
    $("#msg-txt").val("");
    $("#msg-txt").focus();
});