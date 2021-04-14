using calculator.Core.UI;
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

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            fModeWindow.Content = new MainCalculator();
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();


        private void bExit_Click(object sender, RoutedEventArgs e) => Close();


        private void bHide_Click(object sender, RoutedEventArgs e) => mainWindow.WindowState = WindowState.Minimized;

        private void tSetMode_Checked(object sender, RoutedEventArgs e)
        {
            mainWindow.Width = 1000;
            fModeWindow.Width = 1000;
            fModeWindow.Content = new AdvancedCalculator();
        }

        private void tSetMode_Unchecked(object sender, RoutedEventArgs e)
        {
            mainWindow.Width = 349;
            fModeWindow.Width = 349;
            fModeWindow.Content = new MainCalculator();
        }
    }
}
