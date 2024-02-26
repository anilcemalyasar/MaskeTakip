using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = new string[] { "Adana", "Bursa", "İstanbul" };
            string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Antalya";
            Console.WriteLine(sehirler2[0]);
            
            
            Person person1 = new Person();
            person1.FirstName = "Anıl";

            Person person2 = new Person();
            person2.FirstName = "Engin";
            

            foreach(string s in sehirler1)
            {
                Console.WriteLine(s);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "Bursa", "İstanbul" };
            yeniSehirler1.Add("İzmir");
            foreach(string s in yeniSehirler1)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }

    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public int TcNo { get; set; }
    }
}
