<!doctype html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<title>Avira</title>
	<link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/login.css">
</head>

<body>

		<?php $currentPage = 'Index'; ?>
		<?php include 'formLogin.php';?>
		<?php include 'LogInConnect.php';?>
		<?php include 'RegisterConnect.php';?>
		<?php include 'header.php';?>

	<div id="content">
			<div class="content">
				<div class="main_wrapper">
					<h1><strong>Choose you future car: </strong></h1>
					<div class="catalog_sidebar">
						<div class="search_auto">
							<h3><strong>Search</strong> <span style="color: orange">auto</span></h3>
							<div class="clear"></div>	
							
							<form action="" method="post">						
							<label><strong>Model:</strong></label>
							<div class="select_box_1">
								<select class="select_3" name="model">
									<option value="0">Any</option>
									<option value="CLS">CLS</option>
									<option value="S">S Class</option>
									<option value="C">C Class</option>
									<option value="A">A Class</option>
								</select>
							</div>
							<label><strong>Year:</strong></label>
							<div class="select_box_2">
								<select class="select_4" name="yearFrom">
									<option value="0">From</option>
									<option value="2016">2016</option>
									<option value="2017">2017</option>
									<option value="2018">2018</option>
								</select>
								<select class="select_4" name="yearTo">
									<option value="0">To</option>
									<option value="2016">2016</option>
									<option value="2017">2017</option>
									<option value="2018">2018</option>
								</select>
								<div class="clear"></div>
							</div>
							<label><strong>Price:</strong></label>
							<div class="select_box_2">
								<select class="select_4" name="priceFrom">
									<option value="0">From</option>
									<option value="40000">40000</option>
									<option value="50000">50000</option>
									<option value="60000">60000</option>
								</select>
								<select class="select_4" name="priceTo">
									<option value="0">To</option>
									<option value="40000">40000</option>
									<option value="60000">60000</option>
									<option value="100000">100000</option>
								</select>
								<div class="clear"></div>
							</div>
							<label><strong>Mileage:</strong></label>
							<div class="select_box_2">
								<select class="select_4" name="mileFrom">
									<option value="0">From</option>
									<option value="1000">1000</option>
									<option value="10000">10000</option>
									<option value="30000">30000</option>
								</select>
								<select class="select_4" name="mileTo">
									<option value="0">To</option>
									<option value="100000">100000</option>
									<option value="200000">200000</option>
									<option value="300000">300000</option>
								</select>
								<div class="clear"></div>
							</div>
							<br>
							<input name="ModelSearch" type="submit" value="Search" style="padding: 5px;border: 1px solid #ccc;border-radius: 4px;box-sizing: border-box;margin-top: 6px;margin-bottom: 16px;resize: vertical; width: 32%;cursor:pointer;" />
							</form>
							<div class="clear"></div>
						</div>
					</div>
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
								</select>
								<div style="float:right">
								<form action="" method="post">
								<input name="search" type="text" style="padding: 5px;border: 1px solid #ccc;border-radius: 4px;box-sizing: border-box;margin-top: 6px;margin-bottom: 16px;resize: vertical; width: 54%;"/>
								<input type="submit" name="buttonSearch" style="padding: 5px;border: 1px solid #ccc;border-radius: 4px;box-sizing: border-box;margin-top: 6px;margin-bottom: 16px;resize: vertical; width: 32%;cursor:pointer;"/>	
							</form>
								</div>
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