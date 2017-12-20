using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTests
{
    [TestFixture]
    public class SparseArraysTests
    {
        private int N;
        private int Q;


        [Test]
        public void SimpleCaseNotMatch()
        {        
            var shelves = new string[1]
            {
                "a",                
            };
            var queries = new string[1]
            {
                "b",                
            };

            var sparseArrays = new SparseArrays();
            var result = sparseArrays.FindSubStrings(shelves, queries);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(new List<int> { 0 }));
        }

        [Test]
        public void MultipleQueriesNotMatch()
        {
            var shelves = new string[1]
            {
                "a",
            };
            var queries = new string[2]
            {
                "b",
                "c",
            };

            var sparseArrays = new SparseArrays();
            var result = sparseArrays.FindSubStrings(shelves, queries);
            
            Assert.That(result, Is.EqualTo(new List<int> { 0, 0 }));
        }

        [Test]
        public void SingleQueriesMatchToSinlgeShelve()
        {
            var shelves = new string[1]
            {
                "a",
            };
            var queries = new string[1]
            {
                "a"
            };

            var sparseArrays = new SparseArrays();
            var result = sparseArrays.FindSubStrings(shelves, queries);
            
            Assert.That(result, Is.EqualTo(new List<int> { 1 }));
        }

        [Test]
        public void SingleQueriesMatchToMultipleShelves()
        {
            var shelves = new string[2]
            {
                "a",
                "a"
            };
            var queries = new string[1]
            {
                "a"
            };

            var sparseArrays = new SparseArrays();
            var result = sparseArrays.FindSubStrings(shelves, queries);

            Assert.That(result, Is.EqualTo(new List<int> { 2 }));
        }

        
        [Test]
        public void Example1()
        {        
            //input
            //4
            //aba
            //baba
            //aba
            //xzxb
            //3
            //aba
            //xzxb
            //ab

            var shelves = new string[4]
            {
                "aba",
                "baba",
                "aba",
                "xzxb"
            };
            var queries = new string[3]
            {
                "aba",
                "xzxb",
                "ab",
            };

            var sparseArrays = new SparseArrays();
            var result = sparseArrays.FindSubStrings(shelves, queries);

            //output
            //2
            //1
            //0
            Assert.That(result,Is.EqualTo(new List<int>{2,1,0}));
        }
    }
}
