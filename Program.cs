using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baitapthuchanh6
{
    internal class Program
    {
       
        static  List<Vehicle> li = new List<Vehicle>();
        static void Main(string[] args)
        {
            int select = 0;
            LoadStudentsFromFile("student.txt"); 

            do
            {

                Console.WriteLine("============================");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Hiển thị dữ liệu");
                Console.WriteLine("3. Tìm kiếm theo id");
                Console.WriteLine("4. Tìm kiếm theo maker");
                Console.WriteLine("5. Sắp xếp theo price");
                Console.WriteLine("6. Sắp xếp theo năm sản xuất");
                Console.WriteLine("7. Delete id ");
                Console.WriteLine("8.Delete maker");
                Console.WriteLine("9.Delete model");
                Console.WriteLine("10. Kết thúc");
                Console.Write("Choice :");
                select = Convert.ToInt32(Console.ReadLine());
             
                switch (select)
                {
                  
                    case 1:

                        nhapDuLieu();
                        break;
                    case 2:
                        HienThiThongTin();
                        break;
                    case 3:
                        FindId();
                        break;

                    case 4:
                        FindMaker(); 
                        break;
                    case 5:

                        break; 

                }            
            } 
            while (select != 10);
          
        }

      

        static void LoadStudentsFromFile(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                li = new List<Vehicle>(lines.Length);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    li[i]= new Vehicle 
                    {
                       id = data[0], 
                       maker = data[1],
                       model = data[2],
                       year = Convert.ToInt32(data[3]),
                       price = Convert.ToDouble(data[4]),


                    };
                }

                Console.WriteLine("Danh sách sinh viên đã được nạp từ file thành công.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Không tìm thấy tệp " + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi khi đọc file: " + ex.Message);
            }
        }

        static void nhapDuLieu()
         {
            /* Car oto = new Car() ;
                       oto.Input();
                       li.Add(oto);

                       Truck t1 = new Truck();
                       t1.Input();
                       li.Add(t1);                      
                       Console.WriteLine("Them thanh cong :"); */

            li.Add(new Car("veh1", "Mercedes", "Huynhdai", 2015, 30000, "black"));
            li.Add(new Car("veh2", "Mercedes", "Vinfast", 2012, 40000, "brown"));
            li.Add(new Car("veh3", "BMW", "Honda", 2015, 50000, "blue"));

            li.Add(new Truck("veh5","Hyundai", "New Mighty N250", 2200, 2016, 3));
            li.Add(new Truck("veh5","Hyundai", "New Mighty 110s", 1500, 2015, 7));
            li.Add(new Truck("veh6","Isuzu", "QKR77FE4", 3000, 2017, 5));
            Console.WriteLine("Nhap du lieu thanh cong !");
           
          
            

         }
        static void HienThiThongTin()
        {
            Console.WriteLine("===Danh sach cap nhat ===");
          if(li.Count > 0)
          {
                foreach (var item in li)
                {
                    item.Output();
                    Console.WriteLine();
                }
          }
            else
            {
                Console.WriteLine("Khong co danh sach nao vui long nhap lai chuc nang :");
            }

        }

        static void FindId()
        {
            Console.Write("Moi nhap vao id can tim kiem :");
            string seachid = Console.ReadLine();
            bool found = false;
            foreach (var item in li)
            {
                if(item.id == seachid)
                {
                    item.Output(); 
                    Console.WriteLine();
                    found = true;
                }
            }
            if(!found)
            {
                Console.WriteLine("Kh co id nay trong danh sach vui long nhap lai");
            }
           

            

        }
        static void FindMaker()
        {
            Console.Write("Nhap vao maker can tim kiem :"); 
            string seachmaker = Console.ReadLine().ToLower();
            bool find = false; 
            foreach (var item in li)
            {
                if(item.maker.ToLower().Equals(seachmaker))
                {
                    item.Output(); 
                    Console.WriteLine();

                    find = true;
                }
            }
            if (!find)
            {
                Console.WriteLine("Kh co maker nay trong danh sach vui long nhap lai");
            }
        }
       
        
       

      


        
    }
}
