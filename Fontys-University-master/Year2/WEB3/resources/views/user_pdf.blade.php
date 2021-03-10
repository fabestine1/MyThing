<body>
    <h1>All Vehicles:</h1>
    @foreach($vehicle as $v)
        <h3>Brand:</h3>
        {{$v->brand}}
        <br>
        <h3>Model:</h3>
        {{$v->model}}
        <br>
        <h3>Year:</h3>
        {{$v->year}}
        <hr>
    @endforeach
</body>