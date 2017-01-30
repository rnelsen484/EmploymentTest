using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question_3_PrimeFactors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3_PrimeFactors.Tests
{
    [TestClass()]
    public class PrimeFactorTests
    {
        [TestMethod()]
        public void Test_PrimeFactors()
        {
            PrimeFactor PF = new PrimeFactor();

            List<int> primefactorsList = PF.FindFactors(100);

            if (primefactorsList.Count != 4)
            {
                Assert.Fail("Prime Factor Failed");

                return;
            }

            if (primefactorsList[0] != 2 ||
                primefactorsList[1] != 2 ||
                primefactorsList[2] != 5 ||
                primefactorsList[3] != 5)
            {
                Assert.Fail("Prime Factor Failed");
            }
        }
    }
}