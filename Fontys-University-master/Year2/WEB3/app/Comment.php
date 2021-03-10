<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Comment extends Model
{
    //
    
    protected $fillable = [
        'body', 'vehicle_id', 'user_id'
    ];

    public function vehicle(){
        return $this->belongsTo('App\Vehicle');
    }
    
    public function user(){
        return $this->belongsTo('App\User');
    }
}
