using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloominBrandsEmploymentTest
{
    

    public class ComputeTriangleType
    {
        public enum TriangleType
        {
            Equilateral, Isosceles, Scalene, Error
        }

        /// <summary>
        /// Determine the type of a triangle
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public TriangleType Compute(int A, int B, int C)
        {
            TriangleType retval_TriangleType;

            if (A <= 0 || B <= 0 || C <= 0)  // check error
            {
                retval_TriangleType = TriangleType.Error;
            }
            else
            {
                if (A == B && A == C)
                {
                    retval_TriangleType = TriangleType.Equilateral;
                }
                else
                {
                    if (A == B || B == C || A == C)
                    {
                        retval_TriangleType = TriangleType.Isosceles;
                    }
                    else
                    {
                        retval_TriangleType = TriangleType.Scalene;
                    }
                }
            }

            return retval_TriangleType;
        }
    }
}
