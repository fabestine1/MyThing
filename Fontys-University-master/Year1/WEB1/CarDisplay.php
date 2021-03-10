<?php
$servername = "studmysql01.fhict.local";
$username = "dbi378522";
$password = "Tia8W8a47Z";

try
{
	// Create connection
	$conn = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi378522', $username, $password);
    

    $sql = 'Select Name, Price, Registration, Type, Hp, Body, Mileage, Location From car;';
    
        if(isset($_POST['ModelSearch'])){
            $model=$_POST['model'];
            $yearFrom=$_POST['yearFrom'];
            $yearTo=$_POST['yearTo'];
            $priceFrom=$_POST['priceFrom'];
            $priceTo=$_POST['priceTo'];
            $mileFrom=$_POST['mileFrom'];
            $mileTo=$_POST['mileTo'];

            $sqll="select * from car where Name like '%Mercedes-Benz $model Class%' and Registration
             BETWEEN $yearFrom AND $yearTo and Price
             BETWEEN $priceFrom AND $priceTo and Mileage
             BETWEEN $mileFrom AND $mileTo ;";

             foreach($conn->query($sqll) as $row)
                {
                    echo '<h3>The Searched Car was: </h3>';
                    echo '<li>';
                    if($row['Name'] == 'Mercedes-Benz CLS Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/cls-class/" class="thumb"><img src="img/download.jpg" alt="" width="165" height="119"/></a>';
                    }
                    elseif($row['Name'] == 'Mercedes-Benz S Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/s-class/" class="thumb"><img src="img/sclass.jpg" alt="" width="165" height="119"/></a>';
                    }
                    elseif($row['Name'] == 'Mercedes-Benz A Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/a-class/" class="thumb"><img src="img/A.jpg" alt="" width="165" height="119"/></a>';
                    }
                    elseif($row['Name'] == 'Mercedes-Benz C Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/c-class/" class="thumb"><img src="img/C.jpg" alt="" width="165" height="119"/></a>';
                    }
                    echo '<div class="catalog_desc">';
                    echo '<div class="location">Location: '.$row['Location'].'</div>';
                    echo '<div class="title_box">';
                    echo    '<h4><a href="#">'.$row['Name'].'</a></h4>';
                    echo    '<div class="price">'.$row['Price']. ' EURO</div>';
                    echo '</div>';
                    echo '<div class="clear"></div>';
                    echo '<div class="grey_area">';
                    echo    '<span>Registration '.$row['Registration'].'</span>';
                    echo    '<span>'.$row['Type'].'</span>';
                    echo    '<span>'.$row['Hp'].' Hp</span>';
                    echo    '<span>Body '.$row['Body'].'</span>';
                    echo    '<span>'.$row['Mileage']. 'Miles</span>';
                    echo '</div>';
                    echo '<a href="#" class="more markered">View details</a>';
                    echo '</div>';
                    echo '</li>';
                    echo '<h3>The list of all the cars: </h3>';
                }       

        }

        if(isset($_POST['buttonSearch'])){
            $search_value=$_POST["search"];
            $sqlSe="select * from car where Name like '%$search_value%'";
            if(!$conn->query($sqlSe))
            {
                echo "<h3>Sorry, there are no matching result for <b> $search_value </b>. 
                <br> <br> 1. Try more general words. for example: 
                    If you want to search 'how to create a website' then use general 
                    keyword like 'create' 'website' <br> 2. Try different words with similar meaning
                     <br> 3. Please check your spelling</h3>";
            }
            else
            {
                foreach($conn->query($sqlSe) as $row)
                {
                    echo '<h3>The Searched Car was: </h3>';
                    echo '<li>';
                    if($row['Name'] == 'Mercedes-Benz CLS Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/cls-class/" class="thumb"><img src="img/download.jpg" alt="" width="165" height="119"/></a>';
                    }
                    elseif($row['Name'] == 'Mercedes-Benz S Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/s-class/" class="thumb"><img src="img/sclass.jpg" alt="" width="165" height="119"/></a>';
                    }
                    elseif($row['Name'] == 'Mercedes-Benz A Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/a-class/" class="thumb"><img src="img/A.jpg" alt="" width="165" height="119"/></a>';
                    }
                    elseif($row['Name'] == 'Mercedes-Benz C Class')
                    {
                        echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/c-class/" class="thumb"><img src="img/C.jpg" alt="" width="165" height="119"/></a>';
                    }
                    echo '<div class="catalog_desc">';
                    echo '<div class="location">Location: '.$row['Location'].'</div>';
                    echo '<div class="title_box">';
                    echo    '<h4><a href="#">'.$row['Name'].'</a></h4>';
                    echo    '<div class="price">'.$row['Price']. ' EURO</div>';
                    echo '</div>';
                    echo '<div class="clear"></div>';
                    echo '<div class="grey_area">';
                    echo    '<span>Registration '.$row['Registration'].'</span>';
                    echo    '<span>'.$row['Type'].'</span>';
                    echo    '<span>'.$row['Hp'].' Hp</span>';
                    echo    '<span>Body '.$row['Body'].'</span>';
                    echo    '<span>'.$row['Mileage']. 'Miles</span>';
                    echo '</div>';
                    echo '<a href="#" class="more markered">View details</a>';
                    echo '</div>';
                    echo '</li>';
                    echo '<h3>The list of all the cars: </h3>';
                }       
            }
        } 
    

    foreach($conn->query($sql) as $row)
    {
        echo '<li>';
        if($row['Name'] == 'Mercedes-Benz CLS Class')
        {
            echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/cls-class/" class="thumb"><img src="img/download.jpg" alt="" width="165" height="119"/></a>';
        }
        elseif($row['Name'] == 'Mercedes-Benz S Class')
        {
            echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/s-class/" class="thumb"><img src="img/sclass.jpg" alt="" width="165" height="119"/></a>';
        }
        elseif($row['Name'] == 'Mercedes-Benz A Class')
        {
            echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/a-class/" class="thumb"><img src="img/A.jpg" alt="" width="165" height="119"/></a>';
        }
        elseif($row['Name'] == 'Mercedes-Benz C Class')
        {
            echo '<a href="https://www.mercedes-benz.com/en/mercedes-benz/vehicles/passenger-cars/c-class/" class="thumb"><img src="img/C.jpg" alt="" width="165" height="119"/></a>';
        }
        echo '<div class="catalog_desc">';
        echo '<div class="location">Location: '.$row['Location'].'</div>';
        echo '<div class="title_box">';
        echo    '<h4><a href="#">'.$row['Name'].'</a></h4>';
        echo    '<div class="price">'.$row['Price']. ' EURO</div>';
        echo '</div>';
        echo '<div class="clear"></div>';
        echo '<div class="grey_area">';
        echo    '<span>Registration '.$row['Registration'].'</span>';
        echo    '<span>'.$row['Type'].'</span>';
        echo    '<span>'.$row['Hp'].' Hp</span>';
        echo    '<span>Body '.$row['Body'].'</span>';
        echo    '<span>'.$row['Mileage']. 'Miles</span>';
        echo '</div>';
        echo '<a href="#" class="more markered">View details</a>';
        echo '</div>';
        echo '</li>';
    }   
}
catch(PDOException $e)
{
	echo $e->getMessage();
} 
?>