using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2._2
{
    class TrafficLight
    {
        private int size_;
        private String color_;

        public TrafficLight(int size, String color)
        {
            this.Size = size;
            this.Color = color;
        }

        public int Timer { get; set; }

        public int Size
        {
            get
            {
                return this.size_;
            }
            set
            {
                if (value < 5)
                {
                    value = 5;
                }
                if (value > 75)
                {
                    value = 75;
                }

                this.size_ = value;
            }
        }

        public String Color
        {
            get
            {
                return this.color_;
            }
            set
            {
                if (value == "Red" || value == "Orange" || value == "Green")
                {
                    this.color_ = value;
                }  
            }
        }

        public void ChangeColor()
        {
            if (this.Color == "Red")
            {
                this.Color = "Green";
            }
            else if (this.Color == "Green")
            {
                this.Color = "Orange";
            }
            else if (this.Color == "Orange")
            {
                this.Color = "Red";
            }
        }

        public void Draw(Graphics gr)
        {
            if (this.Color == "Red")
            {
                gr.FillEllipse(Brushes.Red, 10, 10, size_, size_);
                gr.FillEllipse(Brushes.White, 10, 10 + size_, size_, size_);
                gr.FillEllipse(Brushes.White, 10, 10 + 2 * size_, size_, size_);
            }
            if (this.Color == "Orange")
            {
                gr.FillEllipse(Brushes.White, 10, 10, size_, size_);
                gr.FillEllipse(Brushes.Orange, 10, 10 + size_, size_, size_);
                gr.FillEllipse(Brushes.White, 10, 10 + 2 * size_, size_, size_);
            }
            if (this.Color == "Green")
            {
                gr.FillEllipse(Brushes.White, 10, 10, size_, size_);
                gr.FillEllipse(Brushes.White, 10, 10 + size_, size_, size_);
                gr.FillEllipse(Brushes.Green, 10, 10 + 2 * size_, size_, size_);
            }
        }

        public void StartTimer(int seconds)
        {
            bool checker = true;

            /*if(checker)
            {
                checker = true;
            }
            else
            {
                checker = false;
            }*/

            while (checker)
            {
                this.ChangeColor();

                

                System.Threading.Thread.Sleep(seconds * 1000);
            }
        }
    }
}
