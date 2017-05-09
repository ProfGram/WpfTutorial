using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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
        private List<Point> playerPointList = new List<Point>();

        public MainWindow()
        {
            InitializeComponent();
            this.hideSomething();
            this.initGlobalPositions();
            this.initPlayerIcons();
            
        }

        private void initGlobalPositions()
        {
            playerPointList.Add(new Point(300, 490));
            playerPointList.Add(new Point(85, 455));
            playerPointList.Add(new Point(-80, 290));
            playerPointList.Add(new Point(0, 162));
            playerPointList.Add(new Point(160, 110));
            playerPointList.Add(new Point(460, 110));
            playerPointList.Add(new Point(625, 162));
            playerPointList.Add(new Point(715, 290));
            playerPointList.Add(new Point(525, 455));
        }

        private void hideSomething()
        {
            Console.WriteLine("wrote");
        }

        private void initPlayerIcons()
        {
            int i = 1;
            foreach (var item in playerPointList)
            {
                Support.PlayerIcon test = new Support.PlayerIcon(i);
                Canvas.SetLeft(test, item.X);
                Canvas.SetTop(test, item.Y);
                canvas.Children.Add(test);
                playerIcons.Add(test);
                i++;
            }
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            while (playerIcons.Count != 0)
            {
                canvas.Children.Remove(playerIcons[0]);
                playerIcons.RemoveAt(0);
            }
            x = 0;    
        }
    }
}
