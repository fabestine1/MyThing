@extends('layouts.app')

@section('content')
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="{{ asset('css/about.css') }}" rel="stylesheet">

<link href='https://fonts.googleapis.com/css?family=Amaranth' rel='stylesheet'>
<div class="about-section">
		<div class="container">
			<div class="site-title text-center">
				<h3>About Us</h3>
				<p>A global automobile marque and a division of the German company Daimler AG. The brand is known for luxury vehicles, buses, coaches, and lorries.</p>
			</div>
			<div class="about-inner-section" style="display: inline-flex;">				
				<div class="col-md-6 about-inner-column">
					<h4>Mercedes-Benz History  </h4>
					<p>Mercedes-Benz traces its origins to Karl Benz's creation of the first petrol-powered car, the Benz Patent Motorwagen, financed by Bertha Benz and patented in January 1886, and Gottlieb Daimler and engineer Wilhelm Maybach's conversion of a stagecoach by the addition of a petrol engine later that year. The Mercedes automobile was first marketed in 1901 by Daimler-Motoren-Gesellschaft (Daimler Motors Corporation).</p>
					<ul>
						<li><a href="#">Mercedes-AMG</a></li>
						<li><a href="#">Mercedes-Maybach</a></li>
						<li><a href="#">Mercedes-Benz China</a></li>
					</ul>
				</div>
				<div class="col-md-6 about-right">
				<img src="https://images.pexels.com/photos/7096/people-woman-coffee-meeting.jpg?w=940&h=650&auto=compress&cs=tinysrgb" alt=" ">
			</div>
				<div class="clearfix"> </div>
			</div>
		</div>
	</div>
@endsection