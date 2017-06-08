var http = require("https");

var options = {
  "method": "POST",
  "hostname": "ussouthcentral.services.azureml.net",
  "port": null,
  "path": "/workspaces/d19304fb0c674e1aa12b3c5a08a92374/services/aa707fe0ff3c4bf5bafbc1613a450ed7/execute?api-version=2.0&details=true",
  "headers": {
    "content-type": "application/json",
    "authorization": "Bearer Q4DgIgdDh2QISXu4ckAQwVEJY0HSIb4TysEdTVznPi31R9rpD7xL/EoAKadtAs15AAJh7YxIRiOdStZ2mfeSlQ==",
    "cache-control": "no-cache",
    "postman-token": "23296353-7047-ad83-4085-c41b47054a8b"
  }
};

var req = http.request(options, function (res) {
  var chunks = [];

  res.on("data", function (chunk) {
    chunks.push(chunk);
  });

  res.on("end", function () {
    var body = Buffer.concat(chunks);
    console.log(body.toString());
  });
});

req.write(JSON.stringify({ Inputs: 
   { input1: 
      { ColumnNames: 
         [ 'make',
           'body-style',
           'wheel-base',
           'engine-size',
           'horsepower',
           'peak-rpm',
           'highway-mpg' ],
        Values: [ [ 'audi', 'sedan', '78', '45', '34', '67', '99' ] ] } },
  GlobalParameters: {} }));
req.end();
