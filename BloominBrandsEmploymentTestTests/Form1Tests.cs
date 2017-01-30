﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BloominBrandsEmploymentTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BloominBrandsEmploymentTest.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        ComputeTriangleType computeTriangleTest = new ComputeTriangleType();

        [TestMethod()]
        public void Test_ZeroValues()
        {
            if(computeTriangleTest.Compute(0, 1, 1) !=
                        ComputeTriangleType.TriangleType.Error)
            {
                Assert.Fail("Zero, or less, paramter error");
            }

            if (computeTriangleTest.Compute(1, 0, 1) != 
                        ComputeTriangleType.TriangleType.Error)
            {
                Assert.Fail("Zero, or less, paramter error");
            }

            if (computeTriangleTest.Compute(1, 1, 0) !=
                        ComputeTriangleType.TriangleType.Error)
            {
                Assert.Fail("Zero, or less, paramter error");
            }
        }

        [TestMethod()]
        public void Test_Equilateral()
        {
            if (computeTriangleTest.Compute(1,1,1) !=
                    ComputeTriangleType.TriangleType.Equilateral)
            {
                Assert.Fail("Failed Equilateral Test");
            }
        }

        [TestMethod()]
        public void Test_Isosceles()
        {
            if (computeTriangleTest.Compute(1, 1, 2) !=
                    ComputeTriangleType.TriangleType.Isosceles)
            {
                Assert.Fail("Failed Isosceles Test");
            }

            if (computeTriangleTest.Compute(2, 1, 1) !=
                     ComputeTriangleType.TriangleType.Isosceles)
            {
                Assert.Fail("Failed Isosceles Test");
            }

            if (computeTriangleTest.Compute(1, 2, 1) !=
                   ComputeTriangleType.TriangleType.Isosceles)
            {
                Assert.Fail("Failed Isosceles Test");
            }
        }

        [TestMethod()]
        public void Test_Scalene()
        {
            if (computeTriangleTest.Compute(1, 2, 3) !=
                   ComputeTriangleType.TriangleType.Scalene)
            {
                Assert.Fail("Failed Scalene Test");
            }
        }
    }
}