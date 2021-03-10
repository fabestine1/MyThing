<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Vehicle extends Model
{
    protected $fillable = [
        'brand', 'model', 'year'
    ];

    public function comments(){
        return $this->hasMany('App\Comment');
    }
}
