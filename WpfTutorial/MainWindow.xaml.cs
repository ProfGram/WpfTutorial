using System;
using System.Collections.Generic;
using System.Windows;
using WpfTutorial.Support;

namespace WpfTutorial
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int x = 0;
        private List<PlayerIcon> playerIcons = new List<PlayerIcon>();

        public MainWindow()
        {
            InitializeComponent();
            this.hideSomething();
            
        }
        private void hideSomething()
        {
            Console.WriteLine("wrote");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Support.PlayerIcon test = new Support.PlayerIcon();
            test.Margin = new Thickness(10, x += 100, 10,10);
            grid1.Children.Add(test);
            playerIcons.Add(test);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            while (playerIcons.Count != 0)
            {
                grid1.Children.Remove(playerIcons[0]);
                playerIcons.RemoveAt(0);
            }
            x = 0;    
        }
    }
}
