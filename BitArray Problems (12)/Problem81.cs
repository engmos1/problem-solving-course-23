using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_solving_course_23
{

    class Problem81
    {
        //Problem 81: Light Control System.

        static void Main1()
        {
            BitArray lights = new BitArray(8);
            lights.Set(0, true);
            lights.Set(1, true);
            lights.Set(2, false);
            lights.Set(3, true);
            lights.Set(4, false);
            lights.Set(5, true);
            lights.Set(6, false);
            lights.Set(7, true);
            Console.WriteLine("Initial state of lights:");
            PrintLights(lights);
            Console.WriteLine("Toggling lights at positions 2, 4, and 6.");
            ToggleLights(lights, new int[] { 2, 4, 6 });
            Console.WriteLine("State of lights after toggling:");
            PrintLights(lights);
            Console.WriteLine("Turn off All lights :");
            lights.SetAll(false);
            PrintLights(lights);


        }
        static void PrintLights(BitArray lights)
        {
            for (int i = 0; i < lights.Count; i++)
            {
                Console.Write(lights[i] ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
        static void ToggleLights(BitArray lights, int[] positions)
        {
            foreach (int pos in positions)
            {
                if (pos >= 0 && pos < lights.Count)
                {
                    lights.Set(pos, !lights.Get(pos));
                }
                else
                {
                    Console.WriteLine($"Position {pos} is out of range.");
                }
            }
        }
    }
}
