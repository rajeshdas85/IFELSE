using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IFElseSample.Interface;

namespace IFElseSample.ExposedClass
{
   public class SridharSir
    {
        private IPlate plate { get; set; }
       
        public SridharSir(IPlate Plate1)
        {
            plate = Plate1;
        }
        public string doDistrubute()
        {
          return  plate.Eating();
        }
    }
}
