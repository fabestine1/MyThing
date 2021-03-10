<?php
$con=mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");

// Check connection
if (mysqli_connect_errno()) {
  echo "Failed to connect to MySQL: " . mysqli_connect_error();
}
if(isset($_POST['register'])){
    // escape variables for security
    $name =  $_POST['name'];
    $password = $_POST['psw'];

    $sql="INSERT INTO user (Name, Password)
    VALUES ('$name','$password')";

    if (!mysqli_query($con,$sql)) {
    die('Error: ' . mysqli_error($con));
    }

}
mysqli_close($con);
?>
