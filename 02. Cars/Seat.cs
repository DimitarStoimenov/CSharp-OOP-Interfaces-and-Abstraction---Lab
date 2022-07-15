using System;
namespace Cars
{
    public class Seat : ICar
    {
        
        public string Model { get; private set; }
        public string Color { get; private set; }

        public Seat(string model, string color)
           
        {
            this.Model = model;
            this.Color = color;
        }


        public void Start()
        {
            Console.WriteLine("Engine start");
        }



        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }

        public override string ToString()
        {
            Console.WriteLine($"{this.Color} Seat {this.Model}");
            Start();
            Stop();
            return "";
        }

    }
}
