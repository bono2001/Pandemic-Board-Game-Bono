using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pandemic_Board_Game_Bono
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public string ConnectedCities { get; set; }
        public int DiseaseCubes { get; set; }

        public City(int id, string name, int population, string connectedCities, int diseaseCubes)
        {
            Id = id;
            Name = name;
            Population = population;
            ConnectedCities = connectedCities;
            DiseaseCubes = diseaseCubes;
        }

        public void AddDiseaseCubes()
        {
        }
        public void RemoveDiseaseCubes()
        {
        }
        public void BuildResearchStation()
        {
        }
    }
}
