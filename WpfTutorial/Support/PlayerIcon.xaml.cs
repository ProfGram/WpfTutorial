
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
        public PlayerIcon()
        {
            DataContext = this;
            InitializeComponent();
            PlayerName = defaultPlayerName;
        }

        private string defaultPlayerName = "Player";
        private string _playerName;

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
