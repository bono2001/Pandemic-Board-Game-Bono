using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class GameManager
    {
        public int Id { get; set; }
        public string GameState { get; set; }
        public string InfectionTracker { get; set; }

        public GameManager(int id, string gameState, string infectionTracker)
        {
            Id = id;
            GameState = gameState;
            InfectionTracker = infectionTracker;
        }
        public void StartGame()
        {
        }
        public void EndGame()
        {
        }
        public void NextTurn()
        {
        }
        public void CheckWinCondition()
        {
        }
        public void CheckLoseCondition()
        {
        }
    }
}
