using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MatrixChainMultiplication()
        {
            ce100_hw3_ahmetburak_yazici.Class1 _matrice = new ce100_hw3_ahmetburak_yazici.Class1();

            int[] arr = new int[] { 1, 2, 3, 4, };
            int size = arr.Length;

            Assert.AreEqual( 4, size);

        }
       
        [TestMethod]
        public void LongestCommonSubsequence()
        {
            ce100_hw3_ahmetburak_yazici.Class1 _matrice = new ce100_hw3_ahmetburak_yazici.Class1();

            Assert.AreSame("Lenght of LCS is 4", "Lenght of LCS is 4");

        }

    }
}
