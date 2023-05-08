using System;
using System.Collections.Generic;

namespace HomeworkTwentyThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runs = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();

            runs.Add(person);
            runs.Add(animal);

            foreach (IRun run in runs)
            {
                if (run is Person p)
                {
                    p.LanguageUsed = "Filipino";
                }

                if (run is Animal a)
                {
                    a.Species = "Tiger";
                }
            }

            using (Person per = new Person())
            {

            }

            Console.ReadLine();
        }
    }

    public interface IRun : IDisposable
    {
        double NumberOfMeterPerHour { get; set; }
        void StartRun();
        void StopRun();
    }

    public class Person : IRun
    {
        public string LanguageUsed { get; set; }
        public double NumberOfMeterPerHour { get; set; }

        public void Dispose()
        {
            // End task
        }

        public void StartRun()
        {
            
        }

        public void StopRun()
        {
            
        }
    }

    public class Animal : IRun
    {
        public string Species { get; set; }
        public double NumberOfMeterPerHour { get; set; }

        public void Dispose()
        {
            // End task
        }

        public void StartRun()
        {

        }

        public void StopRun()
        {

        }
    }
}
