using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace project_2._2
{
    class TrafficLight
    {
        private int size;
        private Color trafficColor;
        private int timeInterval;
        public int Size {
            get { return size; }
            set {
                if (value < 5)
                {
                    size = 5;
                }
                else if (value > 75)
                {
                    size = 75;
                }
                else
                {
                    size = value;
                }
            }
        }
        public int TimeInterval
        {
            get { return timeInterval; }
        }
        public Color TrafficColor
        {
            get { return trafficColor; }
            set
            {
                if (value == Color.Red || value == Color.Orange || value == Color.Green)
                {
                    trafficColor = value;
                }
            }
        }

        public TrafficLight(int nwSize, Color nwColor, int nwInterval)
        {
            Size = nwSize;
            TrafficColor = nwColor;
            timeInterval = nwInterval;
        }
        public void ChangeColor()
        {
            if(trafficColor == Color.Red)
            {
                trafficColor = Color.Green;
            }
            else if (trafficColor == Color.Green)
            {
                trafficColor = Color.Orange;
            }
            else
            {
                trafficColor = Color.Red;
            }
        }
        public void Draw(Graphics gr)
        {
            if (trafficColor == Color.Red)
            {
                gr.FillEllipse(Brushes.Red, 10, 10, size, size);
                gr.FillEllipse(Brushes.White, 10, 10 + size, size, size);
                gr.FillEllipse(Brushes.White, 10, 10 + 2 * size, size, size);
            }
            else if (trafficColor == Color.Orange)
            {
                gr.FillEllipse(Brushes.White, 10, 10, size, size);
                gr.FillEllipse(Brushes.Orange, 10, 10 + size, size, size);
                gr.FillEllipse(Brushes.White, 10, 10 + 2 * size, size, size);
            }
            else
            {
                gr.FillEllipse(Brushes.White, 10, 10, size, size);
                gr.FillEllipse(Brushes.White, 10, 10 + size, size, size);
                gr.FillEllipse(Brushes.Green, 10, 10 + 2 * size, size, size);
            }
        }
    }
}
