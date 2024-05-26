using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class ResearchStation
    {
        public int Id { get; set; }
        public string Location { get; set; }

        public ResearchStation(int id, string location)
        {
            Id = id;
            Location = location;
        }

        public void BuildResearchStation()
        {
        }
    }
}
