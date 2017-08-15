using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorial.Support
{
    class CardGenerator
    {
        Dictionary<CardDefinition.Color, Dictionary<CardDefinition.Number, Card>> cards;

        CardGenerator()
        { 
        }

        void SetUpCards()
        {
            cards = new Dictionary<CardDefinition.Color, Dictionary<CardDefinition.Number, Card>>();

            Dictionary<CardDefinition.Number, Card> heartDictionary = new Dictionary<CardDefinition.Number, Card>();

            CardDefinition.Color color = CardDefinition.Color.Heart;
            CardDefinition.Number number = CardDefinition.Number.Two;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_2h.png"));
            number = CardDefinition.Number.Three;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_3h.png"));
            number = CardDefinition.Number.Four;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_4h.png"));
            number = CardDefinition.Number.Fife;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_5h.png"));
            number = CardDefinition.Number.Six;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_6h.png"));
            number = CardDefinition.Number.Seven;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_7h.png"));
            number = CardDefinition.Number.Eight;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_8h.png"));
            number = CardDefinition.Number.Nine;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_9h.png"));
            number = CardDefinition.Number.Ten;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_th.png"));
            number = CardDefinition.Number.Jack;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Jh.png"));
            number = CardDefinition.Number.Queen;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Qh.png"));
            number = CardDefinition.Number.King;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Kh.png"));
            number = CardDefinition.Number.Ace;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Ah.png"));

            color = CardDefinition.Color.Cross;
            number = CardDefinition.Number.Two;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_2c.png"));
            number = CardDefinition.Number.Three;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_3c.png"));
            number = CardDefinition.Number.Four;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_4c.png"));
            number = CardDefinition.Number.Fife;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_5c.png"));
            number = CardDefinition.Number.Six;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_6c.png"));
            number = CardDefinition.Number.Seven;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_7c.png"));
            number = CardDefinition.Number.Eight;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_8c.png"));
            number = CardDefinition.Number.Nine;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_9c.png"));
            number = CardDefinition.Number.Ten;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_tc.png"));
            number = CardDefinition.Number.Jack;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Jc.png"));
            number = CardDefinition.Number.Queen;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Qc.png"));
            number = CardDefinition.Number.King;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Kc.png"));
            number = CardDefinition.Number.Ace;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Ac.png"));

            color = CardDefinition.Color.Spare;
            number = CardDefinition.Number.Two;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_2s.png"));
            number = CardDefinition.Number.Three;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_3s.png"));
            number = CardDefinition.Number.Four;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_4s.png"));
            number = CardDefinition.Number.Fife;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_5s.png"));
            number = CardDefinition.Number.Six;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_6s.png"));
            number = CardDefinition.Number.Seven;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_7s.png"));
            number = CardDefinition.Number.Eight;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_8s.png"));
            number = CardDefinition.Number.Nine;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_9s.png"));
            number = CardDefinition.Number.Ten;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_ts.png"));
            number = CardDefinition.Number.Jack;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Js.png"));
            number = CardDefinition.Number.Queen;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Qs.png"));
            number = CardDefinition.Number.King;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Ks.png"));
            number = CardDefinition.Number.Ace;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_As.png"));

            color = CardDefinition.Color.Dear;
            number = CardDefinition.Number.Two;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_2d.png"));
            number = CardDefinition.Number.Three;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_3d.png"));
            number = CardDefinition.Number.Four;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_4d.png"));
            number = CardDefinition.Number.Fife;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_5d.png"));
            number = CardDefinition.Number.Six;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_6d.png"));
            number = CardDefinition.Number.Seven;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_7d.png"));
            number = CardDefinition.Number.Eight;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_8d.png"));
            number = CardDefinition.Number.Nine;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_9d.png"));
            number = CardDefinition.Number.Ten;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_td.png"));
            number = CardDefinition.Number.Jack;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Jd.png"));
            number = CardDefinition.Number.Queen;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Qd.png"));
            number = CardDefinition.Number.King;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Kd.png"));
            number = CardDefinition.Number.Ace;
            heartDictionary.Add(number, new Card(color, number, "Images/Cards/card_Ad.png"));
        }
    }
}
