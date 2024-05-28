using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baitapthuchanh6
{
    class Vehicle : IVehicle

    {
        public string id { get; set; }  // ma dinh danh xe
        public string maker { get; set; }  // hang san suat
        public string model { get; set; } // ten xe
        public int year { get; set; }  // nam san xuat
        public double price { get; set; }   // gia tien
      

        public Vehicle (string id, string maker, string model, int year, double price)
        { // phuong thuc khoi tao 5 tham so 
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public Vehicle(string id )
        { // phg thuc khoi tao 1 tham so
            this.id = id; 
        }
        public Vehicle ()
        {
            // phg thuc khoi tao khong tham so 
        }

        public Vehicle(string id, string maker, string model, int year, double price, string color) : this(id, maker, model, year, price)
        {
        }

        public virtual void Input()
        {
            Console.Write("Id :"); 
            id = Console.ReadLine();

            Console.Write("Maker :");
            maker = Console.ReadLine();

            Console.Write("Model :");
            model = Console.ReadLine();
           
            Console.Write("Year :");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Price : :");
            price = Convert.ToDouble(Console.ReadLine());

        }
        public virtual void Output()
        {
            Console.WriteLine($"ID: {id}, maker: {maker}, Model: {model} , Year :{year} , Price:{price}");
        } 

        
        public override string ToString()
        {
            var str = String.Format("{0,-8}{1,-10}{2,-25}{3,10}{4,10}"               
                                     ,id, maker, model, year, price);
            return str;
        }
    }
}
