using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    //The logic class will act as a bridge between program.cs and planet.cs
    //This is where I have all the methods I need for the assignment
    class Logic
    {
        //I instantiated the planet class out here cause I need it in all my methods
        Planet p = new Planet();
        public Logic()
        {

        }
        //Adds planets to the normal list of planets
        public void Add(Planet planet)
        {
            p.Planets.Add(planet);
        }
        //Adds planets to a different list if they have a certain meanTemperature
        public void AddMeanTemp(int highValue)
        {
            for (int i = 0; i < p.Planets.Count; i++)
            {
                if (p.Planets[i].MeanTemperature < highValue)
                    p.PlanetsMeanTemp.Add(p.Planets[i]);
            }
        }
        //Adds planets to a different list if their diameter is in a specific range
        public void AddDiameter(int lowValue, int highValue)
        {
            for (int i = 0; i < p.Planets.Count; i++)
            {
                if (p.Planets[i].Diameter < highValue && p.Planets[i].Diameter > lowValue)
                    p.PlanetsDiameter.Add(p.Planets[i]);
            }
        }
        //Inserts planets in the normal list
        public void Insert(int index, Planet planet)
        {
            p.Planets.Insert(index, planet);
        }
        //Removes planets in the normal list
        public void Remove(Planet planet)
        {
            p.Planets.Remove(planet);
        }
        //I can't seem to make sense of the .RemoveAll() function so I'm just gonna use.Clear() instead
        public void RemoveAll()
        {
            p.Planets.Clear();
        }
        //Returns the amount of planets in the normal list
        public int Count()
        {
            return p.Planets.Count();
        }
        //This is the method that I use when I need to print out the list
        //It returns a string containing a planetname, then a newline and then another planetname etc.
        public string ReturnPlanetList()
        {
            string planetNames = "";
            foreach  (Planet planet in p.Planets)
            {
                planetNames +=planet.Name + "\n";
            }
            return planetNames;
        }
        //Returns a string containing the planetnames and mean temperature of each planet
        public string ReturnPlanetMeanTempList()
        {
            string planetNames = "";
            foreach (Planet planet in p.PlanetsMeanTemp)
            {
                planetNames += $"{planet.Name} {planet.MeanTemperature} \n";
            }
            return planetNames;
        }
        //Returns a string containing the planetnames and diameter of each planet
        public string ReturnPlanetDiameterList()
        {
            string planetNames = "";
            foreach (Planet planet in p.PlanetsDiameter)
            {
                planetNames += $"{planet.Name} {planet.Diameter}\n";
            }
            return planetNames;
        }
    }
}
