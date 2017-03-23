using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Serch.Tests
{
    [TestClass]
    public class SerchTests
    {
        [TestMethod]
        public void EqualSumLeftRightSides_Array_IndexReturndet()
        {
            //Arrange

            int[] Array = new int[] { 3, 12, 24, 8, 24, 2, 1, 6, 6 };
            int Expendet = 3;

            //Arc 

            Serch Serch = new Serch();
            int Actual = Serch.EqualSumLeftRightSides(Array);

            // Asert

            Assert.AreEqual(Expendet, Actual);


        }
        [TestMethod]
        public void StringСoncatenation_StringPlusString_StringReturn()
        {
            //Arrange

            string First = "xyaabbbccccdefww";
            string Second= "xxxxyyyyabklmopq";
            string Exepted = "xyabcdefwklmopq";

            //Arc 

            Serch Serch = new Serch();
            string Actual = Serch.StringСoncatenation(First, Second);

            // Asert

            Assert.AreEqual(Exepted, Actual);
            

        }

        [TestMethod]
        public void StringAlphabet_AlphabeticalRow_StringReturn()
        {
            //Arrange

            string First = "xyabcdefwklmopq";
            string Exepted = "abcdefklmopqwxy";

            //Arc 

            Serch Serch = new Serch();
            string Actual = Serch.StringAlphabet(First);

            // Asert

            Assert.AreEqual(Exepted, Actual);
            

        }

        [TestMethod]
        public void Insert_AlphabeticalRow_StringReturn()
        {
            //Arrange

            int number1 = 8;
            int number2 = 15;
            int index1 = 0;
            int index2 = 0;
            int Exepted = 9;
            //Arc 

            Serch Serch = new Serch();
            int Actual = Serch.Insert(number1, number2, index1, index2);

            // Asert

            Assert.AreEqual(Exepted, Actual);


        }
    }
}
