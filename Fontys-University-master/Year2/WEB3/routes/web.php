<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Auth::routes();

Route::get('/home', 'HomeController@index')->name('home');
Route::get('/about', function(){
   return view('about_us');
})->name('about');

Route::get('/contact', function(){
    return view('contact');
 })->name('contact');

//Route::resource('/users', 'UserController');
Route::get('/profile/edit',  ['as' => 'users.edit', 'uses' => 'UserController@edit']);

Route::patch('/profile/edit',  ['as' => 'users.update', 'uses' => 'UserController@update']);

Route::get('/profile', function(){
    return view('profile');
 })->name('profile');

Route::delete('/profile',  ['as' => 'users.destroy', 'uses' => 'UserController@destroy']);

Route::post('/profile', 'UserController@update_avatar')->name('profile.avatar');

Route::post('/vehicles/{vehicle}/comments', 'CommentController@store');

Route::get('/vehicle', 'VehicleController@index')->name('vehicle');

Route::patch('/vehicle/{comment_id}', 'CommentController@update')->name('vehicle.update');

Route::delete('/vehicle/{comment_id}',  ['as' => 'comment.destroy', 'uses' => 'CommentController@destroy']);

Route::get('/export_vehicle', 'PdfController@vehiclepdfdown')->name('export.vehicle');


//Route::get('/uploadfile', 'UploadFileController@index');


 
