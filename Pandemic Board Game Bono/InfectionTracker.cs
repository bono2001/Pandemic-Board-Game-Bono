using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class InfectionTracker
    {
        public int Id { get; set; }
        public int InfectionRate { get; set; }
        public int Outbreaks { get; set; }

        public InfectionTracker(int id, int infectionRate, int outbreaks)
        {
            Id = id;
            InfectionRate = infectionRate;
            Outbreaks = outbreaks;
        }
        public void IncreaseOutbreaks()
        {
        }
        public void UpdateInfectionRate()
        {
        }
    }
}
