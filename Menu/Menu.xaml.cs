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
using System.Windows.Shapes;

namespace Restaurant_APP
{
    /// <summary>
    /// Logika interakcji dla klasy Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonAM_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            RectangleBreakfast.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation.From = 0;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            RectangleDinner.BeginAnimation(OpacityProperty, animation);

        }

        private void ButtonPM_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            RectangleDinner.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation.From = 0;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            RectangleBreakfast.BeginAnimation(OpacityProperty, animation);

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            MainWindow use = new MainWindow();
            use.Show();
            this.Close();
        }
    }
}
