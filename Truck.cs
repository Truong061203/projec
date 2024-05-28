using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Baitapthuchanh6
{
     class Truck:Vehicle
    {
        public int Truckload {  get; set; }
        public Truck() : base()
        {
        }
        public Truck(string id, string maker, string model, int year, double price, int Truckload) : base(id, maker, model, year, price)
        {
            this .Truckload = Truckload;

        }
        public override void Input()
        {
            base.Input();
            Console.Write("Truckload :"); 
            Truckload = Convert.ToInt32(Console.ReadLine());

        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("TruckLoad :" +Truckload);
        }
    }
}
