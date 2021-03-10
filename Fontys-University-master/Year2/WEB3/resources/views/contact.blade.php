@extends('layouts.app')

@section('content')
<!--
<div class="container contact-form">
    <div class="contact-image">
        <img src="https://image.ibb.co/kUagtU/rocket_contact.png" alt="rocket_contact"/>
    </div>
    <form method="post">
        <h3>Drop Us a Message</h3>
       <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <input type="text" name="txtName" class="form-control" placeholder="Your Name *" value="" />
                </div>
                <div class="form-group">
                    <input type="text" name="txtEmail" class="form-control" placeholder="Your Email *" value="" />
                </div>
                <div class="form-group">
                    <input type="text" name="txtPhone" class="form-control" placeholder="Your Phone Number *" value="" />
                </div>
                <div class="form-group">
                    <input type="submit" name="btnSubmit" class="btnContact" value="Send Message" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <textarea name="txtMsg" class="form-control" placeholder="Your Message *" style="width: 100%; height: 150px;"></textarea>
                </div>
            </div>
        </div>
    </form>
</div> -->

<main class="py-4">
        <link href="{{ asset('css/contact.css') }}" rel="stylesheet">
<div class="container">
<div class="row">
    <div class="col-md-6">
        <div class="google-map"><iframe frameborder="0" style="border: 0px;width: 467px;height: 500px;" src="https://www.google.com/maps/embed/v1/place?key=AIzaSyA0Dx_boXQiwvdz8sJHoYeZNVTdoWONYkU&amp;q=place_id:ChIJn6wOs6lZwokRLKy1iqRcoKw" allowfullscreen=""></iframe></div>
    </div>
    <div class="col-md-6">
        <h2 class="pb-3 align-left mbr-fonts-style display-2" style="font-size: 4rem;">
            Drop us a Line
        </h2>
        <div>
            <div class="icon-block pb-3">
                <span class="icon-block__icon">
                    <span class="mbri-letter mbr-iconfont" media-simple="true"></span>
                </span>
                <h4 class="icon-block__title align-left mbr-fonts-style display-5">
                    Don't hesitate to contact us
                </h4>
            </div>
            <div class="icon-contacts pb-3">
                <h5 class="align-left mbr-fonts-style display-7">
                    Ready for offers and cooperation
                </h5>
                <br>
                <p class="mbr-text align-left mbr-fonts-style display-7">
                    Phone: +359 (0) 912 213 132 <br>
                    Email: mercedes-benz-dealer@mail.com
                </p>
                <br>
            </div>
        </div>
        <div data-form-type="formoid">
            <div data-form-alert="" hidden="">
                Thanks for filling out the form!
            </div>
            <form class="block mbr-form" action="https://mobirise.com/" method="post" data-form-title="Mobirise Form"><input type="hidden" data-form-email="true" value="ZqKtDsObgOIixYRH0FrMG0J+KnVHUaGLVvEtAYQrcscTHTwPghwEysPefw35je29YpyidhgmhTNdaL0S4JBt9DfXQuignsqeeSuXHPcNcs6MAsTSV1aI0jDlIzAtkdTz">
                <div class="row">
                    <div class="col-md-6 multi-horizontal" data-for="name">
                        <input type="text" class="form-control input" name="name" data-form-field="Name" placeholder="Your Name" required="" id="name-form4-6x">
                    </div>
                    <div class="col-md-6 multi-horizontal" data-for="phone">
                        <input type="text" class="form-control input" name="phone" data-form-field="Phone" placeholder="Phone" required="" id="phone-form4-6x">
                    </div>
                    <div class="col-md-12" data-for="email">
                        <input type="text" class="form-control input" name="email" data-form-field="Email" placeholder="Email" required="" id="email-form4-6x">
                    </div>
                    <div class="col-md-12" data-for="message">
                        <textarea class="form-control input" name="message" rows="3" data-form-field="Message" placeholder="Message" style="resize:none" id="message-form4-6x"></textarea>
                    </div>
                    <div class="input-group-btn col-md-12" style="margin-top: 10px;">
                        <button href="" type="submit" class="btn btn-primary btn-form display-4">SEND MESSAGE</button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
</div>
</main>
@endsection