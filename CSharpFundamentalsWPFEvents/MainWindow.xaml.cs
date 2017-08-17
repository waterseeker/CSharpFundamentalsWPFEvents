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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpFundamentalsWPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyButton.Click += MyButton_Click;
            MyButton.Click += MyButton_IClickedThis;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            MyLabel.Content = "You clicked mah button!!";
        }

        //having another click event that is affecting the same thing (the label content in this example)
        //you'll get the last value. They both fire off, but you'll only see the last one. 
        private void MyButton_IClickedThis(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            MyLabel.Content = "You clicked mah button again!!";
        }
    }
}
