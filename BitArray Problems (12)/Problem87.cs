using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem87
    {
        //Problem 87: Traffic Light Simulation.

        static void Main1()
        {
            BitArray trafficLights = new BitArray(3);

            // Green at intersection 1
            trafficLights[2] = true;

            // Change light to Yellow
            trafficLights[2] = false;
            trafficLights[1] = true;

            Console.WriteLine("Intersection 1 Lights:");
            Console.WriteLine($"Red: {trafficLights[0]}, Yellow: {trafficLights[1]}, Green: {trafficLights[2]}");
          
        }

    }
}
