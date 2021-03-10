@extends('layouts.app')

@section('content')
<link href="{{ asset('css/profile.css') }}" rel="stylesheet">
    <div class="container emp-profile">
            <div class="row">
                
            <div class="col-md-4">
                    <div class="profile-img">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <img src="/storage/avatars/{{ Auth::user()->avatar }}"style="width:150px; height:150px; border-radius:50%; display: block; margin-left: auto;margin-right: auto;">
                                    <h2>{{ Auth::user()->name }}'s Profile</h2>
                                    <form enctype="multipart/form-data" action="{{ route('profile.avatar') }}" method="POST">
                                        <input type="hidden" name="_token" value="<?php echo csrf_token(); ?>">
                                        <input type="file" name="avatar">
                                        <button style="float:right;" class="btn btn-primary" type="submit">upload</button>
                                        
                                    </form>
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
                        </ul>
                    </div>
                </div>
                <div class="col-md-2">
                        <button type="button" class="profile-edit-btn">
                            <a href="{{ route('profile') }}">Back to Profile</a>
                        </button>
                </div>
            </div>
            <div class="row">
                 <div class="col-md-4">
                </div> 
                <div class="col-md-8">
                    <div class="tab-content profile-tab" id="myTabContent">
                        <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                    <h2>Edit Profile</h2>

                                            @if ($errors->any())
                                            <div class="alert alert-danger">
                                              <ul>
                                                  @foreach ($errors->all() as $error)
                                                    <li>{{ $error }}</li>
                                                  @endforeach
                                              </ul>
                                            </div><br />
                                          @endif
                                            <form method="post" action="{{ route('users.update', $user->id) }}">
                                              @method('PATCH')
                                              @csrf
                                              <div class="form-group">
                                                  
                                    <div class="row">
                                                <div class="col-md-6">
                                                    <label for="name">Name:</label>
                                                </div>
                                                <div class="col-md-6">
                                                    <input type="text" class="form-control" name="name" value={{ $user->name }} style="margin-bottom: 5px;"/>
                                                </div>
                                        </div>
                                              
                                    <div class="row">
                                            <div class="col-md-6">
                                                <label for="name">Email:</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input type="text" class="form-control" name="email" value={{ $user->email }}  style="margin-bottom: 5px;"/>
                                            </div>
                                    </div>

                                    <div class="row">
                                            <div class="col-md-6">
                                                <label for="phone">Phone:</label>
                                            </div>
                                            <div class="col-md-6">
                                                <input type="text" class="form-control" name="phone" value={{ $user->phone }} style="margin-bottom: 5px;" />
                                            </div>
                                    </div>
                                              <button type="submit" class="btn btn-primary">Update</button>
                                            </form>
                        </div>
                    </div>
                </div>
            </div>    
    </div>

</div>
@endsection