@extends('layouts.app')

@section('content')
<main class="py-4">
    
        <link href="{{ asset('css/profile.css') }}" rel="stylesheet">
    <div class="container emp-profile">

      <!--  <form method="post"> -->
            <div class="row">
                
                <div class="col-md-4">
                    <div class="profile-img">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <img src="/storage/avatars/{{ Auth::user()->avatar }}" style="width:150px; height:150px; border-radius:50%; display: block; margin-left: auto;margin-right: auto;">
                                    <h2>{{ Auth::user()->name }}'s Profile</h2>
                                    <!--<form enctype="multipart/form-data" action="{{ route('profile.avatar') }}" method="POST">
                                        <input type="hidden" name="_token" value="<?php echo csrf_token(); ?>">
                                        <input type="file" name="avatar">
                                        <button class="btn btn-primary" type="submit">upload</button>
                                        
                                    </form> -->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
                <div class="col-md-6">
                    <div class="profile-head">
                                <h5>
                                    {{ ucwords(Auth::user()->name) }}
                                </h5>
                                <h6>
                                    Web Developer and Designer
                                </h6>
                                <p class="proile-rating"></p>
                        <ul class="nav nav-tabs" id="myTab" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">About</a>
                            </li>
                           <!-- <li class="nav-item">
                                <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Timeline</a>
                            </li> -->
                        </ul>
                    </div>
                </div>
                <div class="col-md-2">
                    <button type="button" class="btn btn-primary" style="float:right;">
                        <a style="color:white" href="{{ route('users.edit') }}">Edit Profile</a>
                    </button>               
                </div>
            </div>
            <div class="row">
                 <div class="col-md-4">
                   <!-- <div class="profile-work">
                        <p>WORK LINK</p>
                        <a href="">Website Link</a><br/>
                        <a href="">Bootsnipp Profile</a><br/>
                        <a href="">Bootply Profile</a>
                        <p>SKILLS</p>
                        <a href="">Web Designer</a><br/>
                        <a href="">Web Developer</a><br/>
                        <a href="">WordPress</a><br/>
                        <a href="">WooCommerce</a><br/>
                        <a href="">PHP, .Net</a><br/>
                    </div>-->
                </div> 
                <div class="col-md-8">
                    <div class="tab-content profile-tab" id="myTabContent">
                        <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>User Id</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>{{ Auth::user()->id }}</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Name</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>{{ ucwords(Auth::user()->name) }}</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Email</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>{{ Auth::user()->email }}</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Phone</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>{{ Auth::user()->phone }}</p>
                                        </div>
                                    </div>
                                    <!--<div class="row">
                                        <div class="col-md-6">
                                            <label>Profession</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>Web Developer and Designer</p>
                                        </div>
                                    </div>-->
                        </div>
                      <!--  <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Experience</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>Expert</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Hourly Rate</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>10$/hr</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Total Projects</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>230</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>English Level</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>Expert</p>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label>Availability</label>
                                        </div>
                                        <div class="col-md-6">
                                            <p>6 months</p>
                                        </div>
                                    </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <label>Your Bio</label><br/>
                                    <p>Your detail description</p>
                                </div>
                            </div>
                        </div> -->
                    </div>
                    
                    <form action="{{ route('users.destroy')}}" method="post">
                            @csrf
                            @method('DELETE')
                            <button class="btn btn-danger" style="float: right;" type="submit">Delete</button>
                    </form>
                    
                </div>
            </div>
       <!-- </form>       -->    
    </div>

</div>
</main>
@endsection