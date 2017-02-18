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
using RNG.Models;

namespace RNG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowModel Model;

        public MainWindow()
        {
            InitializeComponent();
            Model = new Models.MainWindowModel(
                MinNumber, 
                MaxNumber, 
                RandomNumber
                );

            MinNumber.Text = RandomNumberGenerator.DefaultMinNumber.ToString();
            MaxNumber.Text = RandomNumberGenerator.DefaultMaxNumber.ToString();
        }

        void DoIt_Click(Object sender, RoutedEventArgs e)
        {
            Model.Calc();
        }
    }
}
