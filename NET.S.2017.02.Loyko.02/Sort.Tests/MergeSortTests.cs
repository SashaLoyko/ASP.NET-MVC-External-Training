using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort.Tests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void MergeSort_UnsortedArray_SortedArrayreturned()
        {
            //Arrange

            int[] Array = new int[] { 150, 101, 1, 2, 0, 43, 100, 101, 8, 25, 102 };               
            int[] ExpectedArray = new int[] { 0, 1, 2, 8, 25, 43, 100, 101, 101, 102, 150, };

            //Arc 

            Sort MergeSort = new Sort();
            int[] Actual = Sort.MergeSort(Array);
            

            //Asert
            CollectionAssert.AreEqual(ExpectedArray, Actual);



        }
    }
}
