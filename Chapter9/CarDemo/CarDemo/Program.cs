using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CarDemo
{
    class Program
    {
        static void Main()
        {
            //Before
            Car car1 = new Car("Honda Civic", 40);
            Car car2 = new Car("Honda Accord");
            //After
            car1.mpg++;
            car2.mpg++;
            WriteLine("Car 1 MPG after: " + car1.mpg);
            WriteLine("Car 2 MPG after: " + car2.mpg);
            ReadLine();
        }
    }
    class Car
    {
        public String model;
        public int mpg;
        public Car(String model, int mpg)
        {
            this.model = model;
            this.mpg = mpg;
            WriteLine("model: {0}", this.model);
            WriteLine("mpg: {0}", this.mpg);
        }
        public Car(String model)
        {
            this.model = model;
            mpg = 20;
            WriteLine("model: {0}", this.model);
            WriteLine("mpg: {0}", mpg);
        }
        public static Car operator ++(Car car)
        {
            car.mpg += 1;
            return car;
        }
    }
}
