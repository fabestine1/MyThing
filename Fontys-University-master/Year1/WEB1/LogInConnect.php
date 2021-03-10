<?php
session_start();
   //$_SERVER['REQUEST_METHOD'] == 'POST'
    if (isset($_POST['login'])){
        $db=mysqli_connect("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");
        $username = $_POST['uname'];
        $password = $_POST['psw'];
        $query = "SELECT * FROM `user` WHERE Name='$username' and Password='$password'";
         
        $result = mysqli_query($db, $query) or die(mysqli_error($db));
        $count = mysqli_num_rows($result);
        if ($count > 0){
        $_SESSION['uname'] = $username;
        }else{
        echo "Invalid Login Credentials.";
        }
    }
?>