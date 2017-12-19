using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;
using ConsoleApp.ArrayManipulation;
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
            List<Tuple<int, int, long>> operations = new List<Tuple<int, int, long>>(m);
            var arrayManipulation = new ArrayManipulation(n,m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();
            Assert.That(max, Is.EqualTo(0));
        }

        [Test]
        public void IfCountOfOperationsIs0ShouldReturn0()
        {
            int n = 7;
            int m = 0;
            List<Tuple<int, int, long>> operations = new List<Tuple<int, int, long>>(m);
            var arrayManipulation = new ArrayManipulation(n, m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();
            Assert.That(max, Is.EqualTo(0));
        }

        [Test]
        public void IfCountOfOperationsIs1AndArrayConsistsOf1ElementShouldAddValueToElementAndReturnIt()
        {
            int n = 1;
            int m = 1;
            List<Tuple<int, int, long>> operations = new List<Tuple<int, int, long>>(m)
            {
                new Tuple<int, int, long>(1, 1, 100),                
            };
            int expectedMax = 100;
            var arrayManipulation = new ArrayManipulation(n, m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();
            Assert.That(max, Is.EqualTo(expectedMax));
        }

        [Test]
        public void ArrayConsistsOf1ElementShouldAddMultipleValuesToElementAndReturnIt()
        {
            int n = 1;
            int m = 2;
            List<Tuple<int, int, long>> operations = new List<Tuple<int, int, long>>(m)
            {
                new Tuple<int, int, long>(1, 1, 100),
                new Tuple<int, int, long>(1, 1, 200),
            };
            int expectedMax = 300;
            var arrayManipulation = new ArrayManipulation(n, m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();
            Assert.That(max, Is.EqualTo(expectedMax));
        }

        [Test]
        public void ShouldAddToSelectedIndexes()
        {
            int n = 2;
            int m = 2;
            List<Tuple<int, int, long>> operations = new List<Tuple<int, int, long>>(m)
            {
                new Tuple<int, int, long>(1, 1, 100),
                new Tuple<int, int, long>(2, 2, 200),
            };
            int expectedMax = 200;
            var arrayManipulation = new ArrayManipulation(n, m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();
            Assert.That(max, Is.EqualTo(expectedMax));
        }

        [Test]
        public void Example1()
        {
            int n = 5;
            int m = 3;
            List<Tuple<int, int, long>> operations = new List<Tuple<int, int, long>>(m)
            {
                new Tuple<int, int, long>(1, 2, 100),
                new Tuple<int, int, long>(2, 5, 100),
                new Tuple<int, int, long>(3, 4, 100),
            };
            int expectedMax = 200;

            var arrayManipulation = new ArrayManipulation(n, m, operations);
            var max = arrayManipulation.GetMaxAfterAllOperations();

            
            Assert.That(max, Is.EqualTo(expectedMax));


        }
    }
}
