using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidTerm_Prep_Testing;
using NUnit.Framework;



namespace TestClass
{
    public class TriangleTest
    {
        [Test]

        public void TriangleTest1_Input60and60and60_OutputValidTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "This triangle is Valid";

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);


        }

        
    }
}
