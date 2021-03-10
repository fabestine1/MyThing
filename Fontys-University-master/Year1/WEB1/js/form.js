function validate() {
    var name = document.f1.name.value;
    var lname = document.f1.lname.value;
    var status = false;
    if (name == "") {
        document.getElementById("nameloc").innerHTML =
            " <img src='http://www.javatpoint.com/javascriptpages/images/unchecked.gif'/> Please enter your name";
        status = false;
    } else {
        document.getElementById("nameloc").innerHTML =
            " <img src='http://www.javatpoint.com/javascriptpages/images/checked.gif'/>";
        status = true;
    }

    if (lname == "") {
        document.getElementById("lnameloc").innerHTML =
            " <img src='http://www.javatpoint.com/javascriptpages/images/unchecked.gif'/> Please enter your name";
        status = false;
    } else {
        document.getElementById("lnameloc").innerHTML =
            " <img src='http://www.javatpoint.com/javascriptpages/images/checked.gif'/>";
        status = true;
    }

    return status;
}