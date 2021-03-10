<!doctype html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Mercedes-Benz Dealer</title>

        <link rel="shortcut icon" type="image/x-icon" href="img/MercLogo.jpg" />
        <!-- Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Nunito:200,600" rel="stylesheet" type="text/css">
        <link rel="stylesheet" href="css/app">
        <!-- Styles -->
        <style>

            .button {
                background-color: black;
                border: none;
                color: white;
                padding: 16px 32px;
                text-align: center;
                font-size: 14px;
                margin: 4px 2px;
                opacity: 0.9;
                transition: 0.3s;
                display: inline-block;
                text-decoration: none;
                cursor: pointer;
                border-radius: 5px;
            }

            .button:hover {opacity: 1}

            svg.intro {
                max-width: 800px;
                position: absolute;
                top: 18%;
                left: 50%;
                -webkit-transform: translate(-50%, -50%);
                transform: translate(-50%, -50%);
            }
            svg.intro .text {
                display: none;
            }
            svg.intro.go .text {
                font-family: 'Courier New';
                font-size: 25px;
                display: block;

            }
            svg.intro.go .text-stroke {
                fill: none;
                stroke: black;
                stroke-width: 2.8px;
                stroke-dashoffset: -900;
                stroke-dasharray: 900;
                stroke-linecap: butt;
                stroke-linejoin: round;
                -webkit-animation: dash 1.5s ease-in-out forwards;
                animation: dash 1.5s ease-in-out forwards;
            }
            svg.intro.go .text-stroke:nth-child(2) {
                -webkit-animation-delay: .3s;
                animation-delay: .3s;
            }
            svg.intro.go .text-stroke:nth-child(3) {
                -webkit-animation-delay: .9s;
                animation-delay: .9s;
            }
            svg.intro.go .text-stroke-2 {
                stroke: white;
                -webkit-animation-delay: 1.2s;
                animation-delay: 1.2s;
            }
            svg.intro.go .text-stroke:nth-child(5) {
                -webkit-animation-delay: 1.5s;
                animation-delay: 1.5s;
            }
            svg.intro.go .text-stroke:nth-child(6) {
                -webkit-animation-delay: 1.8s;
                animation-delay: 1.8s;
            }

            @-webkit-keyframes dash {
                100% {
                    stroke-dashoffset: 0;
                }
            }

            @keyframes dash {
                100% {
                    stroke-dashoffset: 0;
                }
            }
            .reload svg {
                vertical-align: middle;
                position: relative;
                top: -2px;
            }

            html, body {
                background-color: #fff;
                color: white;
                font-family: 'Nunito', sans-serif;
                font-weight: 200;
                height: 100vh;
                margin: 0;
            }

            .full-height {
                height: 100vh;
            }
            .position-ref {
                position: relative;
                background-image: url(/img/4k8.jpg);
                background-size: cover;
                background-position: center;
                height: 100vh;
                flex-direction: column;
                justify-content: center;
                padding: 0 20px;
            }

            .top-right {
                position: absolute;
                right: 10px;
                top: 18px;
            }

            .content {
                text-align: center;
                padding-top: 179px;
            }

            .links > a {
                color: white;
                padding: 0 25px;
                font-size: 13px;
                font-weight: 600;
                letter-spacing: .1rem;
                text-decoration: none;
                text-transform: uppercase;
            }

            .m-b-md {
                margin-bottom: 30px;
            }
        </style>
    </head>
    <body>
        <div class=" position-ref full-height">
            @if (Route::has('login'))
                <div class="top-right links">
                    @auth
                        <a href="{{ url('/home') }}">Home</a>
                    @else
                        <a href="{{ route('login') }}">Login</a>

                        @if (Route::has('register'))
                            <a href="{{ route('register') }}">Register</a>
                        @endif
                    @endauth
                </div>
            @endif

            <div class="content">


                <svg class="intro" viewbox="0 0 320 50">
                    <text text-anchor="start" x="10" y="30" class="text text-stroke" clip-path="url(#text1)">Mercedes-Benz Dealer</text>
                    <text text-anchor="start" x="10" y="30" class="text text-stroke text-stroke-2" clip-path="url(#text1)">Mercedes-Benz Dealer</text>
                    <defs>
                        <clipPath id="text1">
                            <text text-anchor="start" x="10" y="30" class="text">Mercedes-Benz Dealer</text>
                        </clipPath>
                    </defs>
                </svg>

                <button type="button" class="button">
                    <a href="{{route('register')}}" style="text-decoration: none;color: white;">> Find your car</a>

                </button>
            </div>
        </div>
        <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.1.0/jquery.min.js'></script>
        <script  src="js/index.js"></script>
    </body>
</html>
