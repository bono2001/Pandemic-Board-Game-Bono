using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ability { get; set; }


        public Role(int id, string name, string ability)
        {
            Id = id;
            Name = name;
            Ability = ability;
        }

        public void UseAbility()
        {
        }
    }
}
