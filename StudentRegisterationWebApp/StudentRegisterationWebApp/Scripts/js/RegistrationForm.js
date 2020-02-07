document.getElementById("submitBtn").addEventListener('click', (e) => {
    e.preventDefault();
    // data retrieval from form fields
    var firstName = document.getElementById("Tb_FirstName").value;
    var lastName = document.getElementById("Tb_LastName").value;
    var contactNumber = document.getElementById("Tb_Contact").value;
    var dob = document.getElementById("Tb_DOB").value;
    var country = document.getElementById("Ddl_Country").value;
    var state = document.getElementById("Ddl_State").value;
    var city = document.getElementById("Ddl_City").value;


    //First name validation
    var containsNumber = /\d+/;
    if (firstName === "" || containsNumber.test(firstName)) {
        alert("Enter valid first name");
        return false;
    }

    //Last name validation
    if (lastName === "" || containsNumber.test(lastName)) {
        alert("Enter valid Last name");
        return false;
    }

    //Contact Number validation
    if (contactNumber.length < 10) {
        alert("Enter valid Contact number");
        return false;
    }

    //DOB validation
    var age = parseInt(moment(dob.replace("-", ""), "YYYYMMDD").fromNow().split(" ")[0]);
    console.log(age);
    if (Number.isNaN(age) || age < 2) {
        alert("Your age must be atleast 18 years to register");
        return false;
    }
    // Country & State validation
    if (country === "Select Country") {
        alert("Select a country");
        return false;
    }
    if (state === "Select State") {
        alert("Select a state");
        return false;
    }

    console.log($('#exampleModal').modal());
})

document.getElementById("closeBtn").addEventListener('click', (e) => {
    //e.preventDefault();
    ResetData();
})

function ResetData() {
   window.location.reload(true);
    // data retrieval from form fields
    document.getElementById("Tb_FirstName").value = ""
    document.getElementById("Tb_LastName").value = ""
    document.getElementById("Tb_Contact").value = ""
    document.getElementById("Tb_DOB").value = ""
    document.getElementById("Tb_Email").value = ""
    var cb = document.querySelectorAll(".custom-checkbox input")
    for (var i = 0; i < cb.length; ++i)
        cb[i].checked = false;
    document.getElementById("Ddl_Country").selectedIndex = 0;
    document.getElementById("Ddl_State").selectedIndex = 0
    document.getElementById("Ddl_City").selectedIndex = 0

}