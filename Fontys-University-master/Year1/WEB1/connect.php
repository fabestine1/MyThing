
<?php 
$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi378522', 'dbi378522', 'Tia8W8a47Z');
foreach($conn->query("select * from user") as $row)
{
    echo "<tr><td>" . $row["Id"] . 
    "</td><td>". $row["Name"]
     ."</td></tr>";
}
?>
