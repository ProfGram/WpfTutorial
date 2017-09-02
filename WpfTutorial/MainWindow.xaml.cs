using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfTutorial.GUI_Support;
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
        private GameModel GameModel;
        private CardGenerator cardGenerator;

        public MainWindow()
        {
            GameModel = new GameModel();
            cardGenerator = new CardGenerator();
            InitializeComponent();
            this.hideSomething();
            this.initGlobalPositions();
            this.initPlayerIcons();
            this.potValueLabel.DataContext = GameModel;
            //Card card = cardGenerator.GetCard(CardDefinition.Color.Heart, CardDefinition.Number.Ace);
            //Console.WriteLine(card.GetCardImage().ToString());
        }

        private void initGlobalPositions()
        {
            playerPointList.Add(new Point(410, 480));
            playerPointList.Add(new Point(185, 425));
            playerPointList.Add(new Point(7, 270));
            playerPointList.Add(new Point(132.5, 162));
            playerPointList.Add(new Point(265, 110));
            playerPointList.Add(new Point(522.5, 110));
            playerPointList.Add(new Point(652.5, 162));
            playerPointList.Add(new Point(775, 270));
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
                GUI_Support.PlayerIcon icon = new GUI_Support.PlayerIcon(i);
                Canvas.SetLeft(icon, item.X);
                Canvas.SetTop(icon, item.Y);
                canvas.Children.Add(icon);
                playerIcons.Add(icon);
                i++;
            }            
        }
    }
}
