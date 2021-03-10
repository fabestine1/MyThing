@extends('layouts.app')
    
@section('content')

<link href="{{ asset('css/home.css') }}" rel="stylesheet">

<div class="swiper-container main-slider loading">
        <div class="swiper-wrapper">
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://i.pinimg.com/originals/a2/1f/b4/a21fb42679ec87d5e8ed0e11583fcdd7.jpg)">
              <img src="https://i.pinimg.com/originals/a2/1f/b4/a21fb42679ec87d5e8ed0e11583fcdd7.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz SLS</p>
              <span class="caption">Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</span>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://www.mercedes-benz.com/wp-content/uploads/sites/3/2017/12/02-mercedes-benz-mbsocialcar-s-class-s-500-v-222-calendar-december-2018-2560x1440-1280x720.jpg)">
              <img src="https://www.mercedes-benz.com/wp-content/uploads/sites/3/2017/12/02-mercedes-benz-mbsocialcar-s-class-s-500-v-222-calendar-december-2018-2560x1440-1280x720.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz S Class</p>
              <span class="caption">Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</span>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(http://newsonscreen.com/wp-content/uploads/2018/09/Mercedes-Benz-C-Class-Coupe.jpg)">
              <img src="http://newsonscreen.com/wp-content/uploads/2018/09/Mercedes-Benz-C-Class-Coupe.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz C Class</p>
              <span class="caption">Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</span>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://wallpapersite.com/images/wallpapers/mercedes-benz-g-class-2560x1440-2017-cars-hd-3248.jpg)">
              <img src="https://wallpapersite.com/images/wallpapers/mercedes-benz-g-class-2560x1440-2017-cars-hd-3248.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz G Class</p>
              <span class="caption">Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</span>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://i.pinimg.com/originals/ea/66/1f/ea661f6e56e6bb9695189ee65a4f5ecf.jpg)">
              <img src="https://i.pinimg.com/originals/ea/66/1f/ea661f6e56e6bb9695189ee65a4f5ecf.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz A Class</p>
              <span class="caption">Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.</span>
            </div>
          </div>
        </div>
        <!-- If we need navigation buttons -->
        <div class="swiper-button-prev swiper-button-white"></div>
        <div class="swiper-button-next swiper-button-white"></div>
      </div>
      
      <!-- Thumbnail navigation -->
      <div class="swiper-container nav-slider loading">
        <div class="swiper-wrapper">
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://i.pinimg.com/originals/a2/1f/b4/a21fb42679ec87d5e8ed0e11583fcdd7.jpg)">
              <img src="https://i.pinimg.com/originals/a2/1f/b4/a21fb42679ec87d5e8ed0e11583fcdd7.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz SLS</p>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://www.mercedes-benz.com/wp-content/uploads/sites/3/2017/12/02-mercedes-benz-mbsocialcar-s-class-s-500-v-222-calendar-december-2018-2560x1440-1280x720.jpg)">
              <img src="https://www.mercedes-benz.com/wp-content/uploads/sites/3/2017/12/02-mercedes-benz-mbsocialcar-s-class-s-500-v-222-calendar-december-2018-2560x1440-1280x720.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz S Class</p>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(http://newsonscreen.com/wp-content/uploads/2018/09/Mercedes-Benz-C-Class-Coupe.jpg)">
              <img src="http://newsonscreen.com/wp-content/uploads/2018/09/Mercedes-Benz-C-Class-Coupe.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz C Class</p>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://wallpapersite.com/images/wallpapers/mercedes-benz-g-class-2560x1440-2017-cars-hd-3248.jpg)">
              <img src="https://wallpapersite.com/images/wallpapers/mercedes-benz-g-class-2560x1440-2017-cars-hd-3248.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz G Class</p>
            </div>
          </div>
          <div class="swiper-slide">
            <figure class="slide-bgimg" style="background-image:url(https://i.pinimg.com/originals/ea/66/1f/ea661f6e56e6bb9695189ee65a4f5ecf.jpg)">
              <img src="https://i.pinimg.com/originals/ea/66/1f/ea661f6e56e6bb9695189ee65a4f5ecf.jpg" class="entity-img" />
            </figure>
            <div class="content">
              <p class="title">Mercedes-Benz A Class</p>
            </div>
          </div>
        </div>
      </div>
      
      
@endsection
