<?php

use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     *
     * @return void
     */
    public function run()
    {
        // $this->call(UsersTableSeeder::class);
        DB::table('comments')->insert([
            //body	vehicle_id
            'body' => 'This is a text',
            'vehicle_id' => '2',
        ]);
    }
}
