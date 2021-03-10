<?php
$search_value=$_POST["search"];
$con=new mysqli("studmysql01.fhict.local","dbi378522","Tia8W8a47Z","dbi378522");
if($con->connect_error){
    echo 'Connection Faild: '.$con->connect_error;
    }else{
        $sql="select * from car where Name like '%$search_value%'";

        $res=$con->query($sql);

        while($row=$res->fetch_assoc()){
            echo 'First_name:  '.$row["First_Name"];


            }       

        }
?>