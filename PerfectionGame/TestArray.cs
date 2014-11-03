using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PerfectionGame
{
    [TestFixture]
    static class TestArray
    {
       
        [SetUp]
        public static void SetUp()
        {
            
            Console.WriteLine("Setup called");
        }
        public static void TearDown()
        {
            Console.WriteLine("TearDown called");
        }
        
        [Test]
        public static void TestGroupConsecutives()
        {
            List<int> startList = new List<int> { 1, 2, 3, 8, 3, 5,6,8,8,6,7,8,9,10,11,33,44,12 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 6,7,8,9,10,11 };
            CollectionAssert.AreEqual(correctList, endArray);
  
        }
        [Test]
        public static void TestStig()
        {
            List<int> startList = new List<int> { 7,5,17,18,19,1,3,27 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 17,18,19 };
            CollectionAssert.AreEqual(correctList, endArray);

        }
        [Test]
        public static void TestSmallConsecutives()
        {
            List<int> startList = new List<int> {1,2};
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> {1,2};
            CollectionAssert.AreEqual(correctList, endArray);

        }
        [Test]
        public static void TestLastCon()
        {
            List<int> startList = new List<int> { 1, 2,3,4,5,6,50 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 1, 2, 3, 4 , 5,6};
            CollectionAssert.AreEqual(correctList, endArray);

        }
        [Test]
        public static void TestfirstCon()
        {
            List<int> startList = new List<int> { 4, 1, 2,3 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 1, 2, 3 };
            CollectionAssert.AreEqual(correctList, endArray);
        }
        [Test]
        public static void TestOneInt()
        {
            List<int> startList = new List<int> { 1 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 1 };
            CollectionAssert.AreEqual(correctList, endArray);
        }
        [Test]
        public static void TestForNull()
        {
            List<int> startList = null;
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int>();
            CollectionAssert.AreEqual(correctList, endArray);
        }

        [Test]
        public static void Test1()
        {
            List<int> startList = new List<int> { 1,2,3 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 1, 2, 3 };
            CollectionAssert.AreEqual(correctList, endArray);
        }

        [Test]
        public static void Test2()
        {
            List<int> startList = new List<int> { 1, 2, 7,9,10 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 1,2 };
            CollectionAssert.AreEqual(correctList, endArray);
        }

        [Test]
        public static void Test3()
        {
            List<int> startList = new List<int> { 5,4,3,2,1};
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 5 };
            CollectionAssert.AreEqual(correctList, endArray);
        }

        [Test]
        public static void Test4()
        {
            List<int> startList = new List<int> { 14, 17, 19 };
            List<int> endArray = new List<int>();
            endArray = Program.Consecutive(startList);
            List<int> correctList = new List<int> { 14 };
            CollectionAssert.AreEqual(correctList, endArray);
        }
    }
}
