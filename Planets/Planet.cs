using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    //This class will act as the datalayer
    class Planet
    {
        //Empty constructor for when I need to use this class but don't need to add a planet
        public Planet()
        {

        }
        //The other constructor that I use when I create the planets
        //I only needed name, diameter and meanTemperature for this assignment so I didn't add the rest of the properties in the constructor
        public Planet(string name, int diameter, int meanTemperature)
        {
            this.name = name;
            this.diameter = diameter;
            this.meanTemperature = meanTemperature;
        }
        private List<Planet> planets = new List<Planet>() { };
        private List<Planet> planetsMeanTemp = new List<Planet>() { };
        private List<Planet> planetsDiameter = new List<Planet>() { };

        private string name;
        private double mass;
        private int diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int meanTemperature;
        private int numberOfMoons;
        private bool ringSystem;

        #region GetSet
        public List<Planet> Planets
        {
            get
            {
                return planets;
            }
            private set
            {
                planets = value;
            }
        }
        public List<Planet> PlanetsMeanTemp
        {
            get
            {
                return planetsMeanTemp;
            }
            private set
            {
                planetsMeanTemp = value;
            }
        }
        public List<Planet> PlanetsDiameter
        {
            get
            {
                return planetsDiameter;
            }
            private set
            {
                planetsDiameter = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public int Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                rotationPeriod = value;
            }
        }
        public double LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }
            set
            {
                lengthOfDay = value;
            }
        }
        public double DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                orbitalPeriod = value;
            }
        }
        public double OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }
            set
            {
                orbitalVelocity = value;
            }
        }
        public int MeanTemperature
        {
            get
            {
                return meanTemperature;
            }
            set
            {
                meanTemperature = value;
            }
        }
        public int NumberOfMoons
        {
            get
            {
                return numberOfMoons;
            }
            set
            {
                numberOfMoons = value;
            }
        }
        public bool RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                ringSystem = value;
            }
        }
        #endregion
    }
}
