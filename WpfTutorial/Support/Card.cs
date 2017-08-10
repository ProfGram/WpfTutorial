using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorial.Support
{
    class Card: CardDefinition
    {
        private Number number;
        private string image;
        private Color color;

        Card(Number number, string image, Color color)
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
