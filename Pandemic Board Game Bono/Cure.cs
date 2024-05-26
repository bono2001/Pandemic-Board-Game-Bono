using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Cure
    {
        public int Id { get; set; }
        public string Disease { get; set; }
        public bool IsCured { get; set; }

        public Cure(int id, string disease, bool isCured)
        {
            Id = id;
            Disease = disease;
            IsCured = isCured;
        }

        public void DiscoverCure()
        {
        }
    }
}
