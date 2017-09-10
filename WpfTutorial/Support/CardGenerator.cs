using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfTutorial.Support
{
    public class CardGenerator
    {
        Dictionary<CardDefinition.Color, Dictionary<CardDefinition.Number, Card>> cards;

        public CardGenerator()
        {
            this.SetUpCards();
        }

        public Card GetCard(CardDefinition.Color color, CardDefinition.Number number)
        {
            Dictionary<CardDefinition.Number, Card> dict = cards[color];
            return dict[number];
        }

        void SetUpCards()
        {
            cards = new Dictionary<CardDefinition.Color, Dictionary<CardDefinition.Number, Card>>();

            Dictionary<CardDefinition.Number, Card> drict = new Dictionary<CardDefinition.Number, Card>();

            CardDefinition.Color color = CardDefinition.Color.Heart;
            CardDefinition.Number number = CardDefinition.Number.Two;
            drict.Add(number, new Card(color, number, Properties.Resources.card_2h));
            number = CardDefinition.Number.Three;
            drict.Add(number, new Card(color, number,Properties.Resources.card_3h));
            number = CardDefinition.Number.Four;
            drict.Add(number, new Card(color, number, Properties.Resources.card_4h));
            number = CardDefinition.Number.Fife;
            drict.Add(number, new Card(color, number, Properties.Resources.card_5h));
            number = CardDefinition.Number.Six;
            drict.Add(number, new Card(color, number, Properties.Resources.card_6h));
            number = CardDefinition.Number.Seven;
            drict.Add(number, new Card(color, number, Properties.Resources.card_7h));
            number = CardDefinition.Number.Eight;
            drict.Add(number, new Card(color, number, Properties.Resources.card_8h));
            number = CardDefinition.Number.Nine;
            drict.Add(number, new Card(color, number, Properties.Resources.card_9h));
            number = CardDefinition.Number.Ten;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Th));
            number = CardDefinition.Number.Jack;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Jh));
            number = CardDefinition.Number.Queen;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Qh));
            number = CardDefinition.Number.King;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Kh));
            number = CardDefinition.Number.Ace;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Ah));

            cards.Add(color, drict);

            drict = new Dictionary<CardDefinition.Number, Card>();
            color = CardDefinition.Color.Cross;
            number = CardDefinition.Number.Two;
            drict.Add(number, new Card(color, number, Properties.Resources.card_2c));
            number = CardDefinition.Number.Three;
            drict.Add(number, new Card(color, number, Properties.Resources.card_3c));
            number = CardDefinition.Number.Four;
            drict.Add(number, new Card(color, number, Properties.Resources.card_4c));
            number = CardDefinition.Number.Fife;
            drict.Add(number, new Card(color, number, Properties.Resources.card_5c));
            number = CardDefinition.Number.Six;
            drict.Add(number, new Card(color, number, Properties.Resources.card_6c));
            number = CardDefinition.Number.Seven;
            drict.Add(number, new Card(color, number, Properties.Resources.card_7c));
            number = CardDefinition.Number.Eight;
            drict.Add(number, new Card(color, number, Properties.Resources.card_8c));
            number = CardDefinition.Number.Nine;
            drict.Add(number, new Card(color, number, Properties.Resources.card_9c));
            number = CardDefinition.Number.Ten;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Tc));
            number = CardDefinition.Number.Jack;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Jc));
            number = CardDefinition.Number.Queen;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Qc));
            number = CardDefinition.Number.King;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Kc));
            number = CardDefinition.Number.Ace;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Ac));

            cards.Add(color, drict);

            drict = new Dictionary<CardDefinition.Number, Card>();
            color = CardDefinition.Color.Dear;
            number = CardDefinition.Number.Two;
            drict.Add(number, new Card(color, number, Properties.Resources.card_2d));
            number = CardDefinition.Number.Three;
            drict.Add(number, new Card(color, number, Properties.Resources.card_3d));
            number = CardDefinition.Number.Four;
            drict.Add(number, new Card(color, number, Properties.Resources.card_4d));
            number = CardDefinition.Number.Fife;
            drict.Add(number, new Card(color, number, Properties.Resources.card_5d));
            number = CardDefinition.Number.Six;
            drict.Add(number, new Card(color, number, Properties.Resources.card_6d));
            number = CardDefinition.Number.Seven;
            drict.Add(number, new Card(color, number, Properties.Resources.card_7d));
            number = CardDefinition.Number.Eight;
            drict.Add(number, new Card(color, number, Properties.Resources.card_8d));
            number = CardDefinition.Number.Nine;
            drict.Add(number, new Card(color, number, Properties.Resources.card_9d));
            number = CardDefinition.Number.Ten;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Td));
            number = CardDefinition.Number.Jack;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Jd));
            number = CardDefinition.Number.Queen;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Qd));
            number = CardDefinition.Number.King;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Kd));
            number = CardDefinition.Number.Ace;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Ad));

            cards.Add(color, drict);

            drict = new Dictionary<CardDefinition.Number, Card>();
            color = CardDefinition.Color.Spare;
            number = CardDefinition.Number.Two;
            drict.Add(number, new Card(color, number, Properties.Resources.card_2s));
            number = CardDefinition.Number.Three;
            drict.Add(number, new Card(color, number, Properties.Resources.card_3s));
            number = CardDefinition.Number.Four;
            drict.Add(number, new Card(color, number, Properties.Resources.card_4s));
            number = CardDefinition.Number.Fife;
            drict.Add(number, new Card(color, number, Properties.Resources.card_5s));
            number = CardDefinition.Number.Six;
            drict.Add(number, new Card(color, number, Properties.Resources.card_6s));
            number = CardDefinition.Number.Seven;
            drict.Add(number, new Card(color, number, Properties.Resources.card_7s));
            number = CardDefinition.Number.Eight;
            drict.Add(number, new Card(color, number, Properties.Resources.card_8s));
            number = CardDefinition.Number.Nine;
            drict.Add(number, new Card(color, number, Properties.Resources.card_9s));
            number = CardDefinition.Number.Ten;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Ts));
            number = CardDefinition.Number.Jack;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Js));
            number = CardDefinition.Number.Queen;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Qs));
            number = CardDefinition.Number.King;
            drict.Add(number, new Card(color, number, Properties.Resources.card_Ks));
            number = CardDefinition.Number.Ace;
            drict.Add(number, new Card(color, number, Properties.Resources.card_As));

            cards.Add(color, drict);
        }
    }
}
