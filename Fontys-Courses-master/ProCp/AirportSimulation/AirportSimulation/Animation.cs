using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AirportSimulation
{
    [Serializable]
    public enum Weather
    {
        Raining,
        Sunny,
        Snowy
    }
    [Serializable]
    public static class Animation
    {
        //Fields
        private static int speed = 50;
        private static Weather weather = Weather.Sunny;

        //Methods
        public static void Rotate(Image image, int degrees, int beginTime)
        {
            RotateTransform trans = new RotateTransform();
            DoubleAnimation animation = new DoubleAnimation(0.0, degrees, TimeSpan.FromSeconds(2));
            image.LayoutTransform = trans;
            animation.BeginTime = TimeSpan.FromSeconds(beginTime);
            trans.BeginAnimation(RotateTransform.AngleProperty, animation);
        }

        public static void GoStraight(this Image target, double newX, double newY, int beginTime)
        {
            var top = Canvas.GetTop(target);
            TranslateTransform trans = new TranslateTransform();
            target.RenderTransform = trans;
            DoubleAnimation animation = new DoubleAnimation(top, newY - top, TimeSpan.FromSeconds(10));
            animation.BeginTime = TimeSpan.FromSeconds(beginTime);
            trans.BeginAnimation(TranslateTransform.XProperty, animation);
        }

        public static void MoveTo(this Image target, double newX, double newY)
        {
            var top = Canvas.GetTop(target);
            var left = Canvas.GetLeft(target);
            TranslateTransform trans = new TranslateTransform();
            target.RenderTransform = trans;
            var acc = 0.1;
            var dec = 0.8;
            FillBehavior AccelerationRatio = (FillBehavior)acc;
            FillBehavior DecelerationRatio = (FillBehavior)dec; 
            DoubleAnimation anim1 = new DoubleAnimation(top, newY - top, TimeSpan.FromSeconds(3));
            DoubleAnimation anim2 = new DoubleAnimation(left, newX - left, TimeSpan.FromSeconds(3));
            anim1.AccelerationRatio = acc;
            anim1.DecelerationRatio = dec;
            anim1.AutoReverse = false;
            trans.BeginAnimation(TranslateTransform.XProperty, anim1);
            trans.BeginAnimation(TranslateTransform.YProperty, anim2);
        }

        public static void Save()
        {

        }
    }
}
