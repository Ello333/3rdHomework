

namespace Homework3
{
    public class Car
{
        public string Brand { get; set; }
        public string Number { get; set; }
        public double Speed { get; set; }

    public void Start()
        {
            Speed = 5;
            Console.WriteLine("Begin driving");
        }
        public void GoFaster()
        {
            Speed += 5;
                Console.WriteLine("Ātrums -" + Speed);
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Apstāšanās");
        }

        public void SlowDown()
        {
            Speed -= 5;
            Console.WriteLine("Ātrums -" + Speed);
        }
        public void Beep()
        {
            Console.WriteLine("Beep Beep");
        }
    }


}
