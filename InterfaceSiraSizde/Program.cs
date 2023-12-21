using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSiraSizde
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kitap kitap = new Kitap { Ad = "Roman Havası Kitabı♥" };
            Dergi dergi = new Dergi { Ad = "Gazete☻" };
            Ansiklopedi ansiklopedi = new Ansiklopedi { Ad = "Ansiklopedi adı bilmiom☻" };

            kitap.Oku();
            dergi.Oku();
            ansiklopedi.Oku();





        }
    }



    interface IOkunabilir
    {
        void Oku();
    }


    public class Kitap : IOkunabilir
    {
        public string Ad { get; set; }

        public void Oku()
        {
            Console.WriteLine("kitabı oku : " + Ad);
        }
    }


    public class Dergi : IOkunabilir
    {
        public string Ad { get; set; }

        public void Oku()
        {
            Console.WriteLine("dergiyi oku : " + Ad);
        }
    }


    public class Ansiklopedi : IOkunabilir
    {
        public string Ad { get; set; }

        public void Oku()
        {
            Console.WriteLine("ansiklopediyi oku : " + Ad);
        }
    }

}  
   


