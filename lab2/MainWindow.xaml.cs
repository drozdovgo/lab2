using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int index = 0;

        private void MenueItem(object sender, RoutedEventArgs e)
        {
            if (index == 0)
            {
                Paint.Background = Brushes.Black;
                ++index;
            }

            else if (index == 1)
            {
                Paint.Background = Brushes.Green;
                ++index;
            }

            else if (index == 2)
            {
                Paint.Background = Brushes.Red;
                ++index;
            }

            else if (index == 3)
            {
                Paint.Background = Brushes.Yellow;
                ++index;
            }

            else
            {
                Paint.Background= Brushes.White;
                index = 0;
            }
        }

        private void Inf(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здравствуйте, данное приложение было написано кем-то :)");
        }

        private void MouseEnter_grid(object sender, MouseEventArgs e)
        {
            FrameworkElement? fe = sender as FrameworkElement;
            if (fe != null && fe.Tag != null)
                switch (fe.Tag.ToString())
                {
                    case "1":
                        Bar.Text = "меняет фон";
                        break;
                    case "2":
                        Bar.Text = "выход";
                        break;
                    case "3":
                        Bar.Text = "информация";
                        break;
                    case "4":
                        Bar.Text = "меняет фон";
                        break;
                    case "5":
                        Bar.Text = "информация";
                        break;
                    
                }

            else
            {
                Bar.Text = string.Empty;
            }
        }
        private void Exit(object sender, EventArgs e) 
        {
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(((ComboBox)sender).SelectedIndex == 0)
            {
                Paint.DefaultDrawingAttributes.Color = Colors.Red;

            }
            else if (((ComboBox)sender).SelectedIndex == 1)
            {
                Paint.DefaultDrawingAttributes.Color = Colors.Black;

            }
            else if (((ComboBox)sender).SelectedIndex == 2)
            {
                Paint.DefaultDrawingAttributes.Color = Colors.Green;

            }
            else
            {
                Paint.DefaultDrawingAttributes.Color = Colors.Blue;

            }
        }
    }
}