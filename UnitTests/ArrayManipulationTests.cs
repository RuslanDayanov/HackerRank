using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ArrayManipulationTests
    {
        [Test]
        public void IfAllParamsIs0ShouldReturn0()
        {
            int n = 0;
            int m = 0;
            List<Tuple<int, int, int>> operations = new List<Tuple<int, int, int>>(m);
            var arrayManipulation = new ArrayManipulation(n,m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();
            Assert.That(max, Is.EqualTo(0));
        }
    }
}
