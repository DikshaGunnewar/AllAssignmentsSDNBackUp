using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ConsoleApplication2
{
    public class AddressM
    {
        public string AddressLine1 { get; set; }
        public List<PhoneNo> Phone { get; set; }
    }

    public class PhoneNo
    {
        public int Home { get; set; }
        public int Mobile { get; set; }
    }

   
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public List<AddressM> address { get; set; }
        //public string Address { get; set; }
        //public int Phone { get; set; }


    }

   
    public class Program { 
        public static void Main(string[] args)
        {
            /*List<Product> list = new List<Product>()
            {
                new Product {Id=01,Name="Alex",Email="alex@email.com",Age=30,Address="Nagpur", Phone=12523456},
                new Product {Id=02,Name="Shaun",Email="shaun@email.com",Age=32,Address="Gondia",Phone=12855554},
                new Product {Id=03,Name="Nikhil",Email="nikl@email.com",Age=24,Address="Mumbai",Phone=122236332},
                new Product {Id=04,Name="Animekh",Email="ani@email.com",Age=31,Address="Mumbai",Phone=12222582},
                new Product {Id=05,Name="Manish",Email="man@email.com",Age=32,Address="Mumbai",Phone=122263322},
                new Product {Id=06,Name="Radha",Email="radha@email.com",Age=30,Address="Mumbai",Phone=1222855222},
                new Product {Id=07,Name="Radha",Email="radha@email.com",Age=30,Address="Mumbai",Phone=12228222},
                new Product {Id=08,Name="shaam",Email="shaam@email.com",Age=30,Address="Andra Pradesh",Phone=1411222},
                new Product {Id=09,Name="tina",Email="tina@email.com",Age=30,Address="Bhandara",Phone=12229822},
                new Product {Id=10,Name="ritu",Email="ritu@email.com",Age=30,Address="Ashti",Phone=198222562},
            };*/

            List<Product> list = new List<Product>()
            
            {
                new Product {Id=01,Name="Alex",Email="alex@email.com",Age=30,AddressM.AddressLine1="Nagpur", PhoneNo.Home=7425465,PhoneNo.Mobile=5287254},

                
            };
           
            foreach (var li in list)
            {
                Console.WriteLine(li.Id + "  " + li.Name + "  " + li.Email + "  " + li.Age + "  " + li.Address + " " + li.Phone);
            }

        //For C# to Json normal serialization Method.

        /*var javaScriptSerializer = new
         System.Web.Script.Serialization.JavaScriptSerializer();
        string jsonString = javaScriptSerializer.Serialize(list);
        Console.WriteLine(jsonString);*/

       


        

        
       




        //Perform CRUD

        var flag = true;
            while (flag)
            {
                 string json = JsonConvert.SerializeObject(list, Formatting.Indented);

                //Code for json to store in current directory.

                  File.WriteAllText(Environment.CurrentDirectory + @"\diksha1.json", json);
                  string text = File.ReadAllText(Environment.CurrentDirectory+ @"\diksha1.json");
                //Console.WriteLine("{0}", text);

                //Code for save file in particular location.
                /*System.IO.File.WriteAllText(@"D:\DayUsers\Visual Studio 2015\Assignment3Diksha22\JsonFile\dilsha.json", json);
                string data = System.IO.File.ReadAllText(@"D:\DayUsers\Visual Studio 2015\Assignment3Diksha22\JsonFile\dilsha.json");
                Console.WriteLine("{0}", data);*/


                

                Console.WriteLine("Enter Your Chioce");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.display");
                Console.WriteLine("6.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Product P1 = new Product();
                        Console.WriteLine("Enter Your Id");
                        P1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Your Name");
                        P1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Your Email Id");
                        P1.Email = Console.ReadLine();
                        Console.WriteLine("Enter Your Age");
                        P1.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Your Address");
                        P1.Address = Console.ReadLine();
                        Console.WriteLine("Enter Your Phone");
                        P1.Phone = Convert.ToInt32(Console.ReadLine());
                        list.Add(P1);
                        break;

                    case 2:
                        Console.WriteLine("Enter ID U want To Search");
                        var search = Convert.ToInt32(Console.ReadLine());
                        var get = list.Where(sc => sc.Id == search).ToList<Product>();
                        foreach (var g in get)
                        {
                            Console.WriteLine(g.Id + "  " + g.Name + "  " + g.Email + "  " + g.Age+ "  " + g.Address+ " " +g.Phone);
                        }
                        break;

                    case 3:

                        Console.WriteLine("Enter Id U want To Update");
                        var update = Convert.ToInt32(Console.ReadLine());
                        var upd = list.FirstOrDefault(sb => sb.Id == update);

                        Console.WriteLine("Enter Update Your Email");
                        string e = Console.ReadLine();
                        upd.Email = e;

                        Console.WriteLine("Enter Update Your Address");
                        string bb = Console.ReadLine();
                        upd.Address = bb;

                        Console.WriteLine("Enter Update Your Phone No");
                        int a = Convert.ToInt32(Console.ReadLine());
                        upd.Phone = a;
                        break;

                    case 4:
                        Console.WriteLine("Enter Id U want To Delete");
                        var delete = Convert.ToInt32(Console.ReadLine());
                        var dele = list.Where(sd => sd.Id == delete).ToList<Product>();
                        foreach (var del in dele)
                        {
                            list.Remove(del);
                        }
                        Console.WriteLine("Record Deleted");
                        break;

                    case 5:
                        Console.WriteLine("Display All Elements In Collection");
                        foreach (var li in list)
                        {
                            Console.WriteLine(li.Id + "  " + li.Name + "  " + li.Email + "  " + li.Age + "  " + li.Address +" " +li.Phone);
                        }

                        
                        break;

                    case 6:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Enter Correct Choice");
                        break;
                }


                }

                Console.ReadLine();
        }

        
    }
}
