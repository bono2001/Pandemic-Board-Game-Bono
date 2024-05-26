using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class Actions
    {
        public int Id { get; set; }
        public string ActionType { get; set; }


        public Actions(int id, string actionType)
        {
            Id = id;
            ActionType = actionType;
        }

        public void MovePlayer()
        {
        }
        public void TreatDisease()
        {
        }
        public void ShareKnowledge()
        {
        }
        public void DiscoverCure()
        {
        }
        public void BuildResearchStation()
        {
        }

    }
}
