<!doctype html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<title>Avira</title>
	<link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/contact.css">
	<link rel="stylesheet" href="css/login.css">
</head>

<body>
		<?php $currentPage = 'Contact'; ?>
		<?php include 'formLogin.php';?>
		<?php include 'LogInConnect.php';?>
		<?php include 'RegisterConnect.php';?>
		<?php include 'header.php';?>

		<h2 style="text-align: center;">Wanna say hello?</h2>

		<div style="float:right; padding:15px">
			<iframe width="450" height="400" src="https://maps.google.com/maps?width=100%&amp;height=600&amp;hl=en&amp;q=1%20Grafton%20Street%2C%20Dublin%2C%20Ireland+(My%20Business%20Name)&amp;ie=UTF8&amp;t=&amp;z=14&amp;iwloc=B&amp;output=embed"
			    frameborder="0" scrolling="no" marginheight="0" marginwidth="0">
				<a href="https://www.maps.ie/create-google-map/">Google Maps iframe generator</a>
			</iframe>
		</div>
		<br />
		<br>
		<div class="container">
			<form name="f1" action="#" onsubmit="return validate();">
				<label for="fname">* First Name</label>
				<br>
				<input style="width: 30%" type="text" id="fname" name="name" placeholder="Your name.." />
				<span id="nameloc" style="color:red"></span>
				<br>
				<label for="lname">* Last Name</label>
				<br>
				<input  style="width: 30%" type="text" id="lname" name="lname" placeholder="Your last name.." />
				<span id="lnameloc" style="color:red"></span>
				<br>
				<label for="country">Country</label>
				<br>
				<select id="country" name="country">
					<option value="australia">Australia</option>
					<option value="canada">Canada</option>
					<option value="usa">USA</option>
				</select>
				<br>
				<label for="subject">Subject</label>
				<br>
				<textarea id="subject" name="subject" placeholder="Write something.." style="height:200px"></textarea>
				<br>
				<input type="submit" value="register" /> 
			</form> 
		</div>

		<?php include 'footer.php';?>
		
	<script src="js/form.js"></script>
	<script src="js/login.js"></script>
</body>

</html>