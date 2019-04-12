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

namespace Restaurant_APP
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MouseEnterMenu(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(50));
            RectangleMenu.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveMenu(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(50));
            RectangleMenu.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseEnterAbout(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(50));
            RectangleAbout.BeginAnimation(OpacityProperty, animation);
            RectangleAbout1.BeginAnimation(OpacityProperty, animation);
            textBlockAbout.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveAbout(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(50));
            RectangleAbout.BeginAnimation(OpacityProperty, animation);

            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            RectangleAbout1.BeginAnimation(OpacityProperty, animation1);
            textBlockAbout.BeginAnimation(OpacityProperty, animation1);

        }

        private void MouseEnterContact(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(50));
            RectangleContact.BeginAnimation(OpacityProperty, animation);
        }

        private void MouseLeaveContact(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1;
            animation.To = 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(50));
            RectangleContact.BeginAnimation(OpacityProperty, animation);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu use = new Menu();
            use.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ContactButton_Click(object sender, RoutedEventArgs e)
        {
            Contact use = new Contact();
            use.Show();
        }
    }
}
