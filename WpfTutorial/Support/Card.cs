using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorial.Support
{
    public class Card: CardDefinition
    {
        private Number number;
        private string image;
        private Color color;

        public Card(Color color, Number number, string image)
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

        public string GetCardImage()
        {
            return this.image;
        }
    }
}
