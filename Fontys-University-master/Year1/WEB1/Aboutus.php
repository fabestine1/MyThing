<!doctype html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<title>Avira</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
	<link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/login.css">
</head>

<body>

		<?php $currentPage = 'About'; ?>
		<?php include 'formLogin.php';?>
		<?php include 'LogInConnect.php';?>
		<?php include 'RegisterConnect.php';?>
		<?php include 'header.php';?>


	<h1>Who are we?</h1>
	<br>
	<div style="margin-left: 4%">
		<p>Mercedes-Benz (German: [mɛʁˈtseːdəsˌbɛnts]) is a global automobile marque and a division of the German company Daimler
			AG. The brand is known for luxury vehicles, buses, coaches, and lorries. The headquarters is in Stuttgart, Baden-Württemberg.
			The name first appeared in 1926 under Daimler-Benz.</p>
		<br>
		<div class="w3-content w3-display-container">
			<img class="mySlides" src="img/merc.jpg" style="width:100%" height="300" >
			<img class="mySlides" src="img/2.jpg"  style="width:100%" height="300">
			<img class="mySlides" src="img/3.jpg"  style="width:100%" height="300">
			<img class="mySlides" src="img/4.jpg"  style="width:100%" height="300">

			<button style="width:0;" class="w3-button w3-black w3-display-left" onclick="plusDivs(-1)">&#10094;</button>
			<button style="width:0;" class="w3-button w3-black w3-display-right" onclick="plusDivs(1)">&#10095;</button>
		</div>
		<br>
		<br>
	</div>
	<h1>History</h1>
	<br>

	<div style="margin-left: 4%">
		<p>The first contemporary automobile Due to his premature death, Gottlieb Daimler does not witness one of the most outstanding
			designs Maybach produced for the joint company. The first Mercedes generates great excitement at the “Nice Race Week”
			in March 1901. It is a powerful, lightweight vehicle with a low centre of gravity and stands out from all previously built
			cars. </p>
		<br>
		<img src="old.jpg" alt="" width="500" height="300">

	</div>


		<?php include 'footer.php';?>

	<script src="js/js.js"></script>
	<script src="js/login.js"></script>
</body>

</html>