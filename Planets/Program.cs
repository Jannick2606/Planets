using System;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet mercury = new Planet("Mercury", 4879, 167);
            Planet venus = new Planet("Venus", 12104, 464);
            Planet earth = new Planet("Earth", 12756, 15);
            Planet mars = new Planet("Mars", 6792, -65);
            Planet jupiter = new Planet("Jupiter", 152984, -110);
            Planet saturn = new Planet("Saturn", 120536, -140);
            Planet uranus = new Planet("Uranus", 51118, -195);
            Planet neptun = new Planet("Neptun", 49528, -200);
            Planet pluto = new Planet("Pluto", 2370, -225);

            Logic l = new Logic();

            l.Add(mercury);
            l.Add(earth);
            l.Add(mars);
            l.Add(jupiter);
            l.Add(saturn);
            l.Add(uranus);
            l.Add(neptun);
            l.Add(pluto);
            Console.WriteLine(l.ReturnPlanetList());
            l.Insert(1, venus);
            Console.WriteLine(l.ReturnPlanetList());
            l.Remove(pluto);
            Console.WriteLine(l.ReturnPlanetList());
            l.Add(pluto);
            Console.WriteLine(l.ReturnPlanetList());
            Console.WriteLine($"Amount of planets: {l.Count()}");
            l.AddMeanTemp(0);
            Console.WriteLine(l.ReturnPlanetMeanTempList());
            l.AddDiameter(10000, 50000);
            Console.WriteLine(l.ReturnPlanetDiameterList());
            l.RemoveAll();
            Console.WriteLine(l.ReturnPlanetList());
        }
    }
}
