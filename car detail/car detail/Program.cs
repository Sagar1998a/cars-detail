using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_detail
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.Model = "SD";
            car1.Rego = "lalbandi";
            car1.Color = "green";

            int[] num = new int[10];

             Console.WriteLine(car1.Model +car1.Rego + car1.Color );
            Console.ReadLine();


        } 
        class car
        {
            string model;
            string color;
            string rego;


            public string Model { get { return model; } set { model = value; } }
            public string Color { get { return color; } set { color = value; } }
            public string Rego { get { return rego; } set { rego = value; } }


            

        
        
                
        }
    }
}
