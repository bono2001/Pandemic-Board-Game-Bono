using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int InfectionLevel { get; set; }

        public Disease(int id, string name, string color, int infectionLevel)
        {
            Id = id;
            Name = name;
            Color = color;
            InfectionLevel = infectionLevel;
        }

        public void InfectCity()
        {
        }
        public void TreatDisease()
        {
        }
    }
}
