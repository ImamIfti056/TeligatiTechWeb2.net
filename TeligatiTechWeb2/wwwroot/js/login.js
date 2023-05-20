function login() {
    window.alert('Login button clicked');
}

function createAccount() {
    window.alert("Create new account button clicked");
}

function ValidateEmail(input) {

    var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

    if (input.value.match(validRegex)) {

        //   alert("Valid email address!");

        //   document.form1.text1.focus();
        document.getElementById("email").style.border = "none";
        document.getElementById("email").style.borderBottom = "1px solid gray";
        document.getElementById("msg").style.display = "none";

        return true;

    } else {

        //   alert("Invalid email address!");

        document.getElementById("email").style.border = "3px solid red";
        document.getElementById("msg").style.display = "block";

        document.form1.text1.focus();

        return false;

    }
}

function check() {
    ValidateEmail(document.getElementById('email'));

    const email = document.getElementById('email').value;
    const pass = document.getElementById('password').value;
    if (email == "") {
        document.getElementById("email").style.border = "3px solid red";
        document.getElementById("msg").style.display = "block";

    }
    else if (pass == "") {
        document.getElementById("password").style.border = "3px solid red";
        document.getElementById("msg").style.display = "block";


    }
    else if (pass != "") {
        document.getElementById("password").style.border = "none";
        document.getElementById("password").style.borderBottom = "1px solid gray";
        document.getElementById("msg").style.display = "none";
    }
}