using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;


namespace N_Unit
{
    [TestFixture]
    public class TestClass
    {
        Calc cal = new Calc();
        
        
        [TestCase]
        public void AddTest()
        {
            int res = cal.Add(10, 10);
            Assert.AreEqual(20, res);
           
        }

    }
}
