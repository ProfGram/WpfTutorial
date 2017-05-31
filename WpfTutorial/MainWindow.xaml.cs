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
        private Controller GameController;

        public MainWindow()
        {
            GameController = new Controller();
            InitializeComponent();
            this.hideSomething();
            this.initGlobalPositions();
            this.initPlayerIcons();
            this.potValueLabel.DataContext = GameController;
        }

        private void initGlobalPositions()
        {
            playerPointList.Add(new Point(410, 480));
            playerPointList.Add(new Point(185, 425));
            playerPointList.Add(new Point(10, 270));
            playerPointList.Add(new Point(112.5, 162));
            playerPointList.Add(new Point(265, 110));
            playerPointList.Add(new Point(522.5, 110));
            playerPointList.Add(new Point(687.5, 162));
            playerPointList.Add(new Point(795, 270));
            playerPointList.Add(new Point(635, 425));
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

            //Canvas.SetLeft(playerIcons[4],Canvas.GetLeft(playerIcons[0]));
            
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    while (playerIcons.Count != 0)
        //    {
        //        canvas.Children.Remove(playerIcons[0]);
        //        playerIcons.RemoveAt(0);
        //    }
        //    x = 0;
        //}
    }
}
