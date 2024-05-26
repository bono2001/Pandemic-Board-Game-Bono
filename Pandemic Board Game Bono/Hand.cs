using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Hand
    {
        public int Id { get; set; }
        public List<Card> Cards { get; set; }

        public Hand(int id, List<Card> cards)
        {
            Id = id;
            Cards = cards;
        }

        public void AddCard()
        {
        }
        public void RemoveCard()
        {
        }
        public void ShowHand()
        {
        }
    }
}
