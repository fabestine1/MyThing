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

		<?php $currentPage = 'Catalog'; ?>
		<?php include 'formLogin.php';?>
		<?php include 'LogInConnect.php';?>
		<?php include 'RegisterConnect.php';?>
		<?php include 'header.php';?>

	<div id="content">
			<div class="content">
				<div class="main_wrapper">
					<h1><strong>Choose your car from our catalog page: </strong></h1>

					<div class="main_catalog">
						<div class="top_catalog_box">
							<div class="switch">
								<span class="table_view"></span>
								<a href="#" class="list_view"></a>
							</div>
							<div class="sorting drop_list">
								<strong>Sort by: </strong>
								<select style="margin-left: 7px;margin-top: 2px;">
										<option value="0">Date</option>
										<option value="1">Price</option>
										<option value="1">Name</option>
										<option value="1">Manufacturer</option>
								</select>
								
								<div class="clear"></div>
							</div>
							<div class="clear"></div> 
						</div>
						<ul class="catalog_table">
						<?php include 'CarDisplay.php';?>
							<div class="clear"></div>							
						</ul>
						<div class="bottom_catalog_box">
								<div class="pagination">
									<ul>
										<li><button href="#" style="background-color:orange;">1</button></li>
										<li><button href="#" style="background-color:orange;">2</button></li>
										<li><button href="#" style="background-color:orange;">3</button></li>
										<li><button href="#" style="background-color:orange;">4</button></li>
									</ul>
								</div>
								<div class="clear"></div>
							</div>
					</div>
					<div class="clear"></div>
				</div>
			</div>
		</div>


		<?php include 'footer.php';?>
	<script src="js/login.js"></script>
</body>

</html>