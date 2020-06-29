function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}

function plot(id) {
    var data = [{ "type": "bar", "x": [1.0, 2.0, 3.0, 4.0, 5.0], "y": [10.0, 20.0, 83.0, 34.0, 15.0] }];
    var layout = "";
    Plotly.newPlot(id, data, layout);
}

function execute(jscode) {
    eval(jscode);
}