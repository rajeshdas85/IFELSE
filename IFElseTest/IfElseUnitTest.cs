using System;

using IFElseSample.ConcreateClass;
using IFElseSample.ExposedClass;
using IFElseSample.Interface;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFElseTest
{
    [TestClass]
    public class IfElseUnitTest
    {
        [TestMethod]
        public void VenkatFoodTest()
        {
            IPlate plate = new Venkat();
            plate.food = "PopCorn";

            SridharSir scridharSirVenkat = new SridharSir(plate);
            string ExpectedData = "PopCorn";
            string ActualData = scridharSirVenkat.doDistrubute();
            Assert.AreEqual(ActualData, ExpectedData,"Not Equal    {0} with {1}", ActualData,ExpectedData );
            
        }
        [TestMethod]
        public void VenkeyFoodTest()
        {
            IPlate plate = new Venkey();
            plate.food = "Buscuit";
            SridharSir scridharSirVenkat = new SridharSir(plate);
            string ExpectedData = "Buscuit";
            string ActualData = scridharSirVenkat.doDistrubute();
            Assert.AreEqual(ActualData, ExpectedData);

        }
    }
}
