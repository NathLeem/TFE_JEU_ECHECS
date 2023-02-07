using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TFE_JEU_ECHECS
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        MainWindow PageGame = new MainWindow();
        public Menu()
        {
            InitializeComponent();
            btnLaunch.Click += new RoutedEventHandler(StartGame);
            btnRules.Click += new RoutedEventHandler(GoRules);
        }

        public void StartGame(object sender, RoutedEventArgs e) 
        {
            PageGame.Show();
            this.Visibility = Visibility.Hidden;
        }
        public void GoRules(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Rules_of_chess");
        }
    }
}