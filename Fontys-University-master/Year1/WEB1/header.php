<div class="header">
		<div class="navigation-bar">
			<div id="navigation-container">

				<img src="img/avira.png" alt="" height="80">

				<ul>
					<li <?php if ($currentPage === 'Index') {echo 'class="current"';} ?>>
						<a href="index.php">Home</a>
					</li>
					<li <?php if ($currentPage === 'Catalog') {echo 'class="current"';} ?>>
						<a href="Catalog.php">Catalog</a>
					</li>
					<li <?php if ($currentPage === 'About') {echo 'class="current"';} ?>>
						<a href="Aboutus.php">About Us</a>
					</li>
					<li <?php if ($currentPage === 'Services') {echo 'class="current"';} ?>>
						<a href="Services.php">Services</a>
					</li>
					<li <?php if ($currentPage === 'Contact') {echo 'class="current"';} ?>>
						<a href="Contact.php">Get in Touch</a>
					</li>
				</ul>
				<div style="float:right; margin-top:22px;">
				<?php  if (isset($_SESSION['uname'])) : ?>
					<p style="color:  orange;">Welcome  <strong style="color:  black;"><?php echo $_SESSION['uname']; ?></strong></p>
					
					<p ><a style="color:  orange;" href="logout.php">Logout</a></p>
					<!--
					<input style="background-color: orange;color: white;padding: 7px 20px; margin: auto;border: none; cursor: pointer;" type="button" value="Logout" onclick="logout.php" />
-->
				<?php endif ?>
				<?php  if (!isset($_SESSION['uname'])) : ?>
				<input name="SignIn" style="background-color: orange;color: white;padding: 7px 20px; margin: auto;border: none; cursor: pointer;" type="button" value="Sign In" onclick="document.getElementById('id01').style.display='block'" />
					<input style="background-color: orange;color: white;padding: 7px 20px; margin: auto;border: none; cursor: pointer;" type="button" value="Sign Up"  onclick="document.getElementById('id02').style.display='block'"  />
				
				<?php endif ?>
				
			</div>
			</div>
		</div>
</div>

