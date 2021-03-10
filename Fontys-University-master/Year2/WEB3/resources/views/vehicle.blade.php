@extends('layouts.app')

@section('content')
<main class="py-4">

    <link href="{{ asset('css/vehicle.css') }}" rel="stylesheet">
    <link href="{{ asset('css/vehicle_list.css') }}" rel="stylesheet">
    <div class="container">
        <!-- <div class="row justify-content-center">
        <div class="col-md-8">
            <div class="card">
                <div class="card-header">Dashboard</div>

                <div class="card-body">
                    @if (session('status'))
                        <div class="alert alert-success" role="alert">
                            {{ session('status') }}
                        </div>
                    @endif

                    You are logged in. Hello, {{ Auth::user()->name }}!
                </div>
            </div>
        </div>
    </div> -->
        <div id="content">
            <div class="content">
                <div class="main_wrapper">
                    <h1><strong>Choose you future car: </strong></h1>
                    <div class="catalog_sidebar">
                        <div class="search_auto">
                            <h3><strong>Search</strong> <span>auto</span></h3>
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
                                <input name="ModelSearch" type="submit" value="Search" style="padding: 5px;border: 1px solid #ccc;border-radius: 4px;box-sizing: border-box;margin-top: 6px;margin-bottom: 16px;resize: vertical; width: 100%;cursor:pointer;" />
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
                                        <input name="search" type="text" style="padding: 5px;border: 1px solid #ccc;border-radius: 4px;box-sizing: border-box;margin-top: 6px;margin-bottom: 16px;resize: vertical; width: 54%;" />
                                        <input value="Search" type="submit" name="buttonSearch" style="padding: 5px;border: 1px solid #ccc;border-radius: 4px;box-sizing: border-box;margin-top: 6px;margin-bottom: 16px;resize: vertical; width: 32%;cursor:pointer;" />
                                    </form>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <ul class="catalog_table">
                            <div class="clear"></div>
                        </ul>
                        <!--<div class="bottom_catalog_box">
                        <div class="pagination">
                            <ul>
                                <li><button href="#" style="background-color:;">1</button></li>
                                <li><button href="#" style="background-color:;">2</button></li>
                                <li><button href="#" style="background-color:;">3</button></li>
                                <li><button href="#" style="background-color:;">4</button></li>
                            </ul>
                        </div>
                        <div class="clear"></div>
                    </div> -->
                        <div class="container">
                            <button type="button" class="export-vehicle-btn" style="margin-bottom: 10px; margin-top: 10px">
                                <a href="{{ route('export.vehicle') }}">Export PDF</a>
                            </button>
                            <div id="products" class="row list-group">
                                <div class="item list-group-item  col-xs-4 ">

                                    <div class="thumbnail">
                                        <img class="group list-group-image" width="400" height="243" src="https://i.pinimg.com/originals/a2/1f/b4/a21fb42679ec87d5e8ed0e11583fcdd7.jpg"
                                            alt="" />
                                        <div class="caption">
                                            <h4 class="group inner list-group-item-heading">
                                                {{App\Vehicle::find(1)->brand}} {{App\Vehicle::find(1)->model}}</h4>
                                            <p class="group inner list-group-item-text">
                                                <h6 style="color:black;display:inline"> Year: </h6>
                                                {{App\Vehicle::find(1)->year}}
                                            </p>
                                            <p class="group inner list-group-item-text">
                                                <h6 style="color:black;display:inline">Horse Power:</h6>
                                                {{App\Vehicle::find(1)->HorsePower}}
                                            </p>
                                            <p class="group inner list-group-item-text">
                                                <h6 style="color:black;display:inline"> Engine Type:</h6>
                                                {{App\Vehicle::find(1)->EngineType}}
                                            </p>
                                            <p class="group inner list-group-item-text">
                                                <h6 style="color:black;display:inline"> Mileage:</h6>
                                                {{App\Vehicle::find(1)->Mileage}}
                                            </p>
                                            <hr>
                                            <div class="row">
                                                <div class="col-xs-12 col-md-6">
                                                    <p class="lead">
                                                        ${{App\Vehicle::find(1)->price}}</p>
                                                </div>
                                                <div class="col-xs-12 col-md-6">
                                                    <a style="color:white" class="btn btn-success" onclick="myFunction()">Add
                                                        Comment</a>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                    <div id="myDIV" style="display:none;border:1px solid grey">
                                        <div class="card">
                                            <div class="card-body">
                                                <form method="POST" action="/vehicles/{{App\Vehicle::find(1)->id}}/comments">
                                                    {{ csrf_field() }}
                                                    <div class="formp-group">
                                                        <textarea name="body" id="" cols="10" rows="3" placeholder="Your comment here"
                                                            class="form-control">
                                                                </textarea>
                                                    </div>
                                                    <br>
                                                    <div class="form-group">
                                                        <button type="submit" class="btn btn-primary">Add Comment</button>
                                                    </div>
                                                </form>
                                            </div>
                                        </div>
                                        <br>
                                        <h3 style="text-align: center;">Comments for this car: </h3>
                                        <br>
                                        <ul class="list-group">
                                            @foreach (App\Vehicle::find(1)->comments as $item)
                                            <li class="list-group-item">
                                                <span style="font-weight: bold;font-size: medium;">
                                                    {{$item->user->name}} :
                                                </span>
                                                <span>{{$item->body}}</span>
                                                <br><br>
                                                @if($item->user->name == Auth::user()->name)


                                                <form action="/vehicle/{{$item->id}}" method="post">
                                                    @csrf
                                                    @method('DELETE')
                                                    <button style="float:right; margin-left: 3px;" type="submit" class="btn btn-danger">
                                                        Delete
                                                    </button>
                                                </form>
                                                <div class="card">
                                                    <div class="card-body">
                                                        <form method="post" action="/vehicle/{{$item->id}}">
                                                            @method('PATCH')
                                                            @csrf
                                                            <div class="formp-group">
                                                                <textarea name="body" id="" cols="10" rows="3"
                                                                    placeholder="Edit your comment here" class="form-control">
                                                                    </textarea>
                                                            </div>
                                                            <br>
                                                            <div class="form-group">
                                                                <button type="submit" style="float:right" class="btn btn-primary">
                                                                    Update
                                                                </button>
                                                            </div>
                                                        </form>
                                                    </div>
                                                </div>

                                                @endif

                                            </li>

                                            @endforeach
                                        </ul>
                                    </div>
                                </div>

                                <div class="item list-group-item  col-xs-4 ">
                                        <div class="thumbnail">
                                            <img class="group list-group-image" width="400" height="243" src="https://www.mercedes-benz.com/wp-content/uploads/sites/3/2017/12/02-mercedes-benz-mbsocialcar-s-class-s-500-v-222-calendar-december-2018-2560x1440-1280x720.jpg"
                                                alt="" />
                                            <div class="caption">
                                                <h4 class="group inner list-group-item-heading">
                                                    {{App\Vehicle::find(2)->brand}} {{App\Vehicle::find(2)->model}}</h4>
                                                <p class="group inner list-group-item-text">
                                                    <h6 style="color:black;display:inline"> Year: </h6>
                                                    {{App\Vehicle::find(2)->year}}
                                                </p>
                                                <p class="group inner list-group-item-text">
                                                    <h6 style="color:black;display:inline">Horse Power:</h6>
                                                    {{App\Vehicle::find(2)->HorsePower}}
                                                </p>
                                                <p class="group inner list-group-item-text">
                                                    <h6 style="color:black;display:inline"> Engine Type:</h6>
                                                    {{App\Vehicle::find(2)->EngineType}}
                                                </p>
                                                <p class="group inner list-group-item-text">
                                                    <h6 style="color:black;display:inline"> Mileage:</h6>
                                                    {{App\Vehicle::find(2)->Mileage}}
                                                </p>
                                                <hr>
                                                <div class="row">
                                                    <div class="col-xs-12 col-md-6">
                                                        <p class="lead">
                                                            ${{App\Vehicle::find(2)->price}}</p>
                                                    </div>
                                                    <div class="col-xs-12 col-md-6">
                                                        <a style="color:white" class="btn btn-success" onclick="myFunction2()">Add
                                                            Comment</a>
                                                    </div>
    
                                                </div>
                                            </div>
                                        </div>
                                        <div id="myDIV2" style="display:none;border:1px solid grey">
                                            <div class="card">
                                                <div class="card-body">
                                                    <form method="POST" action="/vehicles/{{App\Vehicle::find(2)->id}}/comments">
                                                        {{ csrf_field() }}
                                                        <div class="formp-group">
                                                            <textarea name="body" id="" cols="10" rows="3" placeholder="Your comment here"
                                                                class="form-control">
                                                                    </textarea>
                                                        </div>
                                                        <br>
                                                        <div class="form-group">
                                                            <button type="submit" class="btn btn-primary">Add Comment</button>
                                                        </div>
                                                        <br>
                                                    </form>
                                                </div>
                                            </div>
                                            <br>
                                            <h3 style="text-align: center;">Comments for this car: </h3>
                                            <br>
                                            <ul class="list-group">
                                                @foreach (App\Vehicle::find(2)->comments as $item)
                                                <li class="list-group-item">
                                                    <span style="font-weight: bold;font-size: medium;">
                                                        {{$item->user->name}} :
                                                    </span>
                                                    <span>{{$item->body}}</span>
                                                    <br><br>
                                                    @if($item->user->name == Auth::user()->name)
    
    
                                                    <form action="/vehicle/{{$item->id}}" method="post">
                                                        @csrf
                                                        @method('DELETE')
                                                        <button style="float:right; margin-left: 3px;" type="submit" class="btn btn-danger">
                                                            Delete
                                                        </button>
                                                    </form>
                                                    <div class="card">
                                                        <div class="card-body">
                                                            <form method="post" action="/vehicle/{{$item->id}}">
                                                                @method('PATCH')
                                                                @csrf
                                                                <div class="formp-group">
                                                                    <textarea name="body" id="" cols="10" rows="3"
                                                                        placeholder="Edit your comment here" class="form-control">
                                                                        </textarea>
                                                                </div>
                                                                <br>
                                                                <div class="form-group">
                                                                    <button type="submit" style="float:right" class="btn btn-primary">
                                                                        Update
                                                                    </button>
                                                                </div>
                                                            </form>
                                                        </div>
                                                    </div>
    
                                                    @endif
    
                                                </li>
    
                                                @endforeach
                                            </ul>
                                        </div>
                                    </div>

                            </div>

                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>

        </div>

    </div>

    </div>

    <script>
        function myFunction() {
            var x = document.getElementById("myDIV");
            if (x.style.display === "none") {
                x.style.display = "block";
            } else {
                x.style.display = "none";
            }
        }

        function myFunction2() {
            var x = document.getElementById("myDIV2");
            if (x.style.display === "none") {
                x.style.display = "block";
            } else {
                x.style.display = "none";
            }
        }

    </script>
</main>


@endsection
