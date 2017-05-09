
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Windows.Controls;

namespace WpfTutorial.Support
{
    /// <summary>
    /// Interaktionslogik für PlayerIcon.xaml
    /// </summary>
    public partial class PlayerIcon :  UserControl, INotifyPropertyChanged
    {
        
        public PlayerIcon(int id)
        {
            DataContext = this;
            this._id = id;
            InitializeComponent();
            PlayerName = defaultPlayerName + "" + this._id;
        }

        public enum Position { left, top, right, bottom };
        private string defaultPlayerName = "Player";
        private string _playerName;
        private int _id;

        public void setDataPosition(Position position)
        {
            switch (position)
            {
                case Position.left:
                    break;
                case Position.top:
                    break;
                case Position.right:
                    break;
                case Position.bottom:
                    break;
                default:
                    break;
            }
        }

        public string PlayerName {
            get { return _playerName;  }
            set
            {
                if (_playerName != value)
                {
                    _playerName = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ID {
            get { return _id; }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void MenuItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PlayerName = "TESTPLAYERNAME";
            Console.WriteLine(PlayerName);
        }

        private void MenuItem_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            PlayerName = "";
        }

        private void MenuItem_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            PlayerName = "Your POSITION";
        }

        private void MenuItem_Click_3(object sender, System.Windows.RoutedEventArgs e)
        {
            PlayerName = "Yeah its donne";
        }
    }

}
