using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // enums = special "class" that contains a set of named constants.
            //         Use enums when you have values that you know will not change
            //         To get the integer value from an item, you must explicitly convert to an int

            //         name = integer

            //Console.WriteLine($"Planet {Planets.Saturn} is number {(int)Planets.Saturn}");
            //Console.WriteLine($"Planet {Planets.Neptune} is number {(int)Planets.Neptune}");

            string name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Venus);


            Console.WriteLine($"Planet {name} has a radius of {radius} km");
            Console.WriteLine($"Radius:Venus {volume}");


            Console.ReadKey();
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 5832,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }


}