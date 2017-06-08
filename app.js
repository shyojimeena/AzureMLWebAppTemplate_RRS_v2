var unirest = require("unirest");

var req = unirest("POST", "https://ussouthcentral.services.azureml.net/workspaces/d19304fb0c674e1aa12b3c5a08a92374/services/aa707fe0ff3c4bf5bafbc1613a450ed7/execute");

req.query({
  "api-version": "2.0",
  "details": "true"
});

req.headers({
  "postman-token": "8f627d26-f3ac-7528-c51d-97324df09cd8",
  "cache-control": "no-cache",
  "authorization": "Bearer Q4DgIgdDh2QISXu4ckAQwVEJY0HSIb4TysEdTVznPi31R9rpD7xL/EoAKadtAs15AAJh7YxIRiOdStZ2mfeSlQ==",
  "content-type": "application/json"
});

req.type("json");
req.send({
  "Inputs": {
    "input1": {
      "ColumnNames": [
        "make",
        "body-style",
        "wheel-base",
        "engine-size",
        "horsepower",
        "peak-rpm",
        "highway-mpg"
      ],
      "Values": [
        [
          "audi",
          "sedan",
          "78",
          "45",
          "34",
          "67",
          "99"
        ]
      ]
    }
  },
  "GlobalParameters": {}
});

req.end(function (res) {
  if (res.error) throw new Error(res.error);

  console.log(res.body);
});
