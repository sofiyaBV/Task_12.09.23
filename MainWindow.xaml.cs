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

namespace Task_12._09._23
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
        private void DisplayDateTime(TextBlock targetTextBlock)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = $"{currentDateTime}";
            Dispatcher.Invoke(() => targetTextBlock.Text = formattedDateTime);
        }
        private void Start_click(object sender, RoutedEventArgs e)
        {
            Task task1 = new Task(() => DisplayDateTime(Start_tb));
            task1.Start();

            Task task2 = Task.Factory.StartNew(() => DisplayDateTime(StartNew_tb));

            Task task3 = Task.Run(() => DisplayDateTime(Run_tb));
        }
    }
}
