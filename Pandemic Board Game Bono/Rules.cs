using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Rule
    {
        public int Id { get; set; }
        public string Rules { get; set; }

        public Rule(int id, string rules)
        {
            Id = id;
            Rules = rules;
        }

        public void ReadRules()
        {
        }
    }
}
