using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IFElseSample.Interface;

namespace IFElseSample.ConcreateClass
{
    class Srikant : IPlate
    {
        private string activity;
        string IPlate.food { get => activity; set => activity = value; }

        public string Eating()
        {
            Console.WriteLine(activity);
            return activity;
        }
    }
}
