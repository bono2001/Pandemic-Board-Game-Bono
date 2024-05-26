using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pandemic_Board_Game_Bono
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public string City { get; set; }
        public string Hand { get; set; }

        //ingame player
        public Player(int id, string name,  string role, string city, string hand)
        {
            Id = id;
            Name = name;
            Role = role;
            City = city;
            Hand = hand;
            
        }

        //Manage player
        public Player(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }

        public void CreatePlayer()
        { 
        }

        public void EditPlayer()
        {
        }
        public void RemovePlayer()
        {
        }
        public void SelectPlayer()
        {
        }
        public void DrawCard()
        {
        }
        public void PlayCard()
        {
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
    }
}