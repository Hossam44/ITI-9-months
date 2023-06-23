console.log("hoomo");
function generateRow(data) {
  const row = document.createElement("tr");

  const name = document.createElement("td");
  name.textContent = data.userName;
  row.appendChild(name);

  const Mobile = document.createElement("td");
  Mobile.textContent = data.Mobile;
  row.appendChild(Mobile);

  const Adress = document.createElement("td");
  Adress.textContent = data.Adress;
  row.appendChild(Adress);

  const Email = document.createElement("td");
  Email.textContent = data.Email;
  row.appendChild(Email);

  return row;
}

function insirst_Data(data) {
    const TBody = document.querySelector("tbody");
    for (var i = 0; i < data.length; i++) {
      console.log(data[i]);
    var row = generateRow(data[i]);
    TBody.appendChild(row);
  }
}

var url = "http://www.localhost:7008/All_data";

// Making our request
fetch(url, { method: "GET" })
  .then((Result) => Result.json())
  .then((data) => {
    // Printing our response
    console.log(data.users);
    insirst_Data(data.users);
    // Printing our field of our response
    console.log(`Title of our response :  ${string.title}`);
  })
  .catch((errorMsg) => {
    console.log(errorMsg);
  });
