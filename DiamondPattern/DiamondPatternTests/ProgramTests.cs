using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiamondPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DiamondPattern.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ValidInput()
        {
            Console.SetIn(new StringReader("Z"));
            //
            string input = DiamondPattern.Program.UserInput();

            Assert.AreEqual("Z", input);
        }


        [TestMethod()]
        public void InValidInputNumber()
        {
            Console.SetIn(new StringReader("2"));

            string input = DiamondPattern.Program.UserInput();

            string errorMessage = "Invalid Alphabet Character";

            Assert.AreEqual(errorMessage, input);
        }

        [TestMethod()]
        public void InValidInputString()
        {

            Console.SetIn(new StringReader("My String"));

            string input = DiamondPattern.Program.UserInput();


            string errorMessage = "String Character invalid character";

            Assert.AreEqual(errorMessage, input);
        }

        [TestMethod()]
        public void InValidInputSpecialChar()
        {
            Console.SetIn(new StringReader("$"));

            string input = DiamondPattern.Program.UserInput();

            string errorMessage = "Invalid Alphabet Character";

            Assert.AreEqual(errorMessage, input);
        }
    }
}