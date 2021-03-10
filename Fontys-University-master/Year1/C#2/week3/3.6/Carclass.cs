using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3._6;

namespace carClass
{
    public class Car
    {
        private String _brand;
        private String _imageFileName;

        public Car()
        {
                
        }

        public Car(String carBrand, int latestMileage, int latestTotalLiters)
        {
            this.Brand = carBrand;
            this.LatestMileage = latestMileage;
            this.LatestTotalLiters = latestTotalLiters;
        }

        public int LatestMileage { get; set; }
        public int LatestTotalLiters { get; set; }
        public int LatestLitersTanked { get; set; }
        public int LatestLitersLeft { get; set; }

        public String Brand
        {
            get
            {
                return this._brand;
            }
            set
            {
                if(value == "Mustang" || value == "mustang" || value == "Porsche" || value == "porsche")
                {
                    this._brand = value;
                }
            }
        }

        public String ImageFileName
        {
            get
            {
                return this._imageFileName;
            }
            private set
            {
                this._imageFileName = "";
            }
        }
        
        public void Initialize(Car car, Label brand, Label mileage, PictureBox pb)
        {
            car.Brand = this.Brand;
            car.LatestMileage = this.LatestMileage;

            brand.Text = car.Brand;

            mileage.Text = car.LatestMileage.ToString();

            if (car.Brand == "Mustang")
            {
                pb.Image = Image.FromFile("mustang.jpg");
            }
            if(car.Brand == "Porsche")
            {
                pb.Image = Image.FromFile("porsche.png");
            }
        }

        public void UpdateCar(int latestLitersTanked, int latestLitersLeft, int latestMileage)
        {
            this.LatestMileage += latestMileage;
            this.LatestLitersTanked = latestLitersTanked;
            this.LatestLitersLeft = latestLitersLeft;
            this.LatestTotalLiters += LatestLitersTanked;
        }

        public String Efficiency()
        {
            String info;
            double efficiency;

            efficiency = this.LatestMileage / (this.LatestTotalLiters - this.LatestLitersLeft -
                this.LatestLitersTanked);

            info = "The " + this.Brand + " efficiency is " + efficiency;

            return info;
        }
    }
}
