using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IFElseSample.Interface;

namespace IFElseSample.ConcreateClass
{
   public class Venkey : IPlate
    {
        private string _food;
        string IPlate.food { get => _food; set => _food = value; }
        public string Eating()
        {
            Console.WriteLine(_food);
            return _food;
        }
    }
}
