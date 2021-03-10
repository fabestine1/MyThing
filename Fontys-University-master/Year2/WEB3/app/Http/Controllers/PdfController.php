<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use PDF;
use App;
use App\Vehicle;


class PdfController extends Controller
{
    public function vehiclepdfdown(Request $request){
        $vehicle = Vehicle::all();
        $pdf = PDF::loadView('user_pdf', [
            'vehicle' => $vehicle
        ]);

        return $pdf->download('export.pdf');
    }
}
