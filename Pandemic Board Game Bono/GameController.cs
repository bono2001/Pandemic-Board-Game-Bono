using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class GameController
    {
        public int Id { get; set; }
        public string InputHandler { get; set; }

        public GameController(int id, string inputHandler)
        {
            Id = id;
            InputHandler = inputHandler;
        }

        public void ProcessInput()
        {
        }
        public void UpdateGameState()
        {
        }
    }
}
