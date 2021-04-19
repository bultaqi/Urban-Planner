using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building tommysHouse = new Building("123 W Easy Street")
            {
                depth = 6,
                width = 6, 
                stories = 88
            };
            
            Building gabesHouse = new Building("69 Ginger St")
            {
                depth = 6,
                width = 6, 
                stories = 88
            };
           
           tommysHouse.PrintBuilding();
           gabesHouse.PrintBuilding();
        }
    }
}
