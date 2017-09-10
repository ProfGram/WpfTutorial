using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorial.Support
{
    public class Card: CardDefinition
    {
        private Number number;
        private Bitmap image;
        private Color color;

        public Card(Color color, Number number, Bitmap image)
        {
            this.color = color;
            this.number = number;
            this.image = image;
        }

        Number GetNumber()
        {
            return this.number;
        }

        Color GetColor()
        {
            return this.color;
        }

        public Bitmap GetCardImage()
        {
            return this.image;
        }
    }
}
