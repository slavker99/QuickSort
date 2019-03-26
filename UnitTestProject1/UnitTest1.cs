using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeElements()
        {
            int[] array = QSort.GenerateArray(3, int.MaxValue);
            QSort.QuickSort(array);
            if (!(array[0] <= array[1]) && (array[1] <= array[2]))
                Assert.Fail();
        }

        [TestMethod]
        public void OneHundredElements()
        {
            int[] array = QSort.GenerateArray(100, int.MaxValue);
            QSort.QuickSort(array);
            for (int i = 0; i<array.Length-1; i++)
                if (array[i] >= array[i+1])
                    Assert.Fail();
        }

        [TestMethod]
        public void OneThousandElements()
        {
            Random rnd = new Random();
            int[] array = QSort.GenerateArray(1000, int.MaxValue);
            QSort.QuickSort(array);
            int a;
            for (int i = 0; i < 10; i++)
            {
                a = rnd.Next(0, 999);
                if (array[a] >= array[a + 1])
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void EmptyElements()
        {
            int[] array = new int[] {};
            QSort.QuickSort(array);
        }

        [TestMethod]
        public void SortBigArray()
        {
            var array = QSort.GenerateArray(1500000000, int.MaxValue);
            QSort.QuickSort(array);
            for (var i = 1; i < array.Length; i++)
                Assert.IsTrue(array[i - 1] < array[i]);
        }
    }
}
