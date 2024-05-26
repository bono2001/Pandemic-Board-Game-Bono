using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }

        public Card(int id, string name, string type, int amount)
        {
            Id = id;
            Name = name;
            Type = type;
            Amount = amount;
        }

        public void ShowCard()
        {
        }
        public void DrawCard()
        {
        }
        public void DiscardCard()
        {
        }
    }
}
