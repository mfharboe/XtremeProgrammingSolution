using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionGame
{
    public class Program
    {
        static List<int> m_list = new List<int>();
        static int sizeOfList = 50;

        static void Main(string[] args)
        {
            CreateList();
            //FindConsecutiveNumbers();
            PrintOutConsecutiveNumber();

        }
        public static void CreateList()
        {
            Random random = new Random();
            m_list.Add(14);
            m_list.Add(17);
            m_list.Add(19);
            //m_list.Add(3);
            //m_list.Add(4);
            //m_list.Add(7);
            //m_list.Add(8);
            //m_list.Add(10);
            //m_list.Add(4);
            //m_list.Add(16);
            //m_list.Add(17);
            //m_list.Add(16);
            //for (int i = 0; i < sizeOfList; i++)
            //{
            //    m_list.Add(random.Next(0, 20));
            //}
        }


        public static void PrintOutConsecutiveNumber()
        {
            List<int> sortedList = Consecutive(m_list);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        //internal static List<int> Consecutive(List<int> startList)
        //{
        //    List<int> sortedList = new List<int>();
        //    List<List<int>> tempList = new List<List<int>>();
        //    List<int> finalList = new List<int>();
        //    if (startList == null)
        //    {
        //        return new List<int>();
        //    }
        //    if (startList.Count == 1)
        //    {
        //        return startList;
        //    }

        //    for (int i = 0; i < startList.Count - 1; i++)
        //    {
        //        if (i != startList.Count)
        //        {
                   
        //            if (startList[i] + 1 == startList[i + 1])
        //            {

        //                sortedList.Add(startList[i]);
        //                sortedList.Add(startList[i + 1]);
        //            }
        //            else
        //            {
        //                if(sortedList.Count != 2)
        //                tempList.Add(sortedList);
        //                sortedList = new List<int>();
        //            }
        //            if (startList.Count - 2 == i)
        //            {
        //                tempList.Add(sortedList);
        //            }
        //        }
        //    }

        //    if (tempList.Count == 1)
        //    {

        //        return tempList[0];
        //    }
        //    else
        //    {
        //        int count = 0;
        //        foreach (var item in tempList)
        //        {
        //            if (item.Count > count)
        //            {
        //                count = item.Count;
        //                finalList = item;
        //            }

        //        }
        //    }

        //    for (int i = 0; i < finalList.Count - 1; i++)
        //    {
        //        if (finalList[i] == finalList[i + 1])
        //        {
        //            finalList.RemoveAt(i);
        //        }
                
        //    }
        //    //Console.WriteLine(tempList.Count);
        //    return finalList;
        //}
        internal static List<int> Consecutive(List<int> testArray)
        {
            if (testArray == null)
            {
                return new List<int>();
            }
            var listOfLists = new List<List<Int32>>();
            var resultList = new List<Int32>();
            var finalResult = new List<int>();
            listOfLists.Add(resultList);

            for (var i = 0; i < testArray.Count; i++)
            {
                if (i == 8)
                {
                    resultList.Add(testArray[0]);
                }
                else if (resultList.Last().Equals(testArray[i] - 1))
                {
                    resultList.Add(testArray[i]);
                }
                else
                {
                    resultList = new List<Int32>();
                    listOfLists.Add(resultList);
                    resultList.Add(testArray[i]);
                }
            }
            var count = 0;
            foreach (var list in listOfLists)
            {

                if (count < list.Count)
                {
                    finalResult = null;
                    finalResult = list;
                    count = list.Count;
                }
            }
            return finalResult;
        }
    }
}
