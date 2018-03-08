function loadMeUp() {

    var body = document.body,
        html = document.documentElement;

    var h = Math.max(body.scrollHeight, body.offsetHeight,
        html.clientHeight, html.scrollHeight, html.offsetHeight);

    document.getElementById("outputStuff").innerHTML = h;

    document.getElementById("Label1").text = "testing";

    document.getElementById("Label1").setAttribute("text", "testing");

    document.getElementById("HiddenField1").value = h;

}