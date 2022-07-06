// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-supernatural-inheritance
using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q19 extras Storm[] instead of seprate vars
            Storm[] storms = new Storm[100];
            int stormIndex = 0;

            Pupil mo = new Pupil("No origin param this test is also valid for all the child classes afterwards as mage and archmage!");

            storms[stormIndex] = mo.CastWindStorm();
            stormIndex++;

            // Q5
            storms[stormIndex] = new Storm("wind", false, "Zul'rajas");
            stormIndex++;

            // Q8
            Pupil mezil = new Pupil("Mezil-Kree", "Icecrown");
            storms[stormIndex] = mezil.CastWindStorm();
            stormIndex++;

            



            // Q12
            Mage guldan = new Mage("Gul'dan", "Draenor");
            storms[stormIndex] = guldan.CastRainStorm();
            stormIndex++;
            storms[stormIndex] = guldan.CastWindStorm();
            stormIndex++;


            // Q18
            Archmage nielas = new Archmage("Nielas Aran", "Stormwind");
            storms[stormIndex] = nielas.CastWindStorm();
            stormIndex++;
            storms[stormIndex] = nielas.CastRainStorm();
            stormIndex++;
            storms[stormIndex] = nielas.CastLightningStorm();
            stormIndex++;

            Array.Resize(ref storms, stormIndex);

            foreach (Storm storm in storms)
            {
                Console.WriteLine(storm.Announce());
            }

        }
    }
}