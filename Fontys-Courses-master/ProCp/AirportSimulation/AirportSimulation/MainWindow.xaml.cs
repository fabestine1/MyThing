using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirportSimulation
{
    public partial class MainWindow : Window
    {
        private Storyboard s;
        private bool isStarted = false;
        private bool isPaused = false;
        public MainWindow()
        {
            InitializeComponent();
            s = (Storyboard)TryFindResource("sb");
        }

        private void btnStartSimulation_Click(object sender, RoutedEventArgs e)
        {
            if (!isStarted)
            {
                s.Begin();  // Start animation
                btnStartSimulation.Content = "Stop Simulation";
                btnPauseSimulation.IsEnabled = true;
            }
            else
            {
                s.Stop();  // Start animation
                btnStartSimulation.Content = "Start Simulation";
                btnPauseSimulation.IsEnabled = false;
            }
            isStarted = !isStarted;
        }

        private void BtnPauseSimulation_Click(object sender, RoutedEventArgs e)
        {
            if (!isPaused)
            {
                s.Pause(); // Pause animation
                btnPauseSimulation.Content = "Resume Simulation";
            }
            else
            {
                s.Resume(); // Resume animation
                btnPauseSimulation.Content = "Pause Simulation";
            }
            isPaused = !isPaused;
        }
    }
}
