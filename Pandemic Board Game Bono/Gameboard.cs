using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Gameboard
    {
        public int Id { get; set; }
        public List<City> Cities { get; set; }
        public List<Disease> Diseases { get; set; }
        public List<ResearchStation> ResearchStations { get; set; }
        public string PlayerDeck { get; set; }
        public string InfectionDeck { get; set; }
    }

}
