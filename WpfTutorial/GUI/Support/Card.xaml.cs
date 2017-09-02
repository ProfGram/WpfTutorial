using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfTutorial.Support;

namespace WpfTutorial.GUI.Support
{
    /// <summary>
    /// Interaktionslogik für Card.xaml
    /// </summary>
    public partial class Card : UserControl, INotifyPropertyChanged
    {
        private BitmapSource _cardPath;

        public BitmapSource ConvertToBitmapSource(Bitmap bitmap)
        {
            BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap
            (
            bitmap.GetHbitmap(),
            IntPtr.Zero,
            Int32Rect.Empty,
            BitmapSizeOptions.FromEmptyOptions()
            );
            return bitmapSource;
        }

        public Card()
        {
            DataContext = this;
            CardGenerator GEN = new CardGenerator();
            CardUri = ConvertToBitmapSource(Properties.Resources.card_2c);//new CardGenerator().GetCard(CardDefinition.Color.Heart, CardDefinition.Number.Ace).GetCardImage().ToString();
            Console.WriteLine(_cardPath);
            InitializeComponent();
        }

        public BitmapSource CardUri
        {
            get { return _cardPath; }
            set
            {
                if (_cardPath != value)
                {
                    _cardPath = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
