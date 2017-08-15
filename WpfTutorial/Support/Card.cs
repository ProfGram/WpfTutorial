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
        }

        Number GetNumber()
        {
            return this.number;
        }

        Color GetColor()
        {
            return this.color;
        }

        string GetCardImage()
        {
            return this.image;
        }
    }
}
