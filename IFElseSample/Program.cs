using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IFElseSample.ConcreateClass;
using IFElseSample.ExposedClass;
using IFElseSample.Interface;

namespace IFElseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlate iplate = new Venkat();
            iplate.food = "Milk";
            SridharSir scridharSirVenkat = new SridharSir(iplate);
            Console.WriteLine(scridharSirVenkat.doDistrubute());

            SridharSir scridharSirVenky = new SridharSir(new Venkey());
            Console.WriteLine(scridharSirVenky.doDistrubute());

            SridharSir scridharSirsrikat = new SridharSir(new Srikant());
           Console.WriteLine( scridharSirsrikat.doDistrubute());

            Console.ReadKey();
        }
    }
}
