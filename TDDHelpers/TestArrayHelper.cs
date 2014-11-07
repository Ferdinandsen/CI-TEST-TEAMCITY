using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDHelpers
{
    class TestArrayHelper
    {
        [Test]
        public void SortAsc()
        {
            ArrayHelper helper = new ArrayHelper();
            int[] arrUnsorted = new[] { 2, 5, 1, 8, 30, 1 };
            int[] arrSorted = new[] { 1, 1, 2, 5, 8, 30 };
            // Assert.AreEqual(arrSorted, helper.ReturnAscArray(arrUnsorted));
            CollectionAssert.AreEqual(arrSorted, helper.ReturnAscArray(arrUnsorted));
            CollectionAssert.AreNotEqual(arrUnsorted, helper.ReturnAscArray(arrUnsorted));
        }
        [Test]
        public void SortDesc()
        {
            ArrayHelper helper = new ArrayHelper();
            int[] arrUnsorted = new[] { 2, 5, 1, 8, 30, 1 };
            int[] arrSorted = new[] { 30, 8, 5, 2, 1, 1 };
            CollectionAssert.AreEqual(arrSorted, helper.ReturnDescArray(arrUnsorted));
            CollectionAssert.AreNotEqual(arrUnsorted, helper.ReturnDescArray(arrUnsorted));
        }

        [Test]
        public void ReplaceXWithY()
        {
            ArrayHelper helper = new ArrayHelper();
            int[] arrUnreplaced = new[] { 2, 5, 3 };
            int[] notArrUnreplaced = new[] { 2, 5, 3 };
            int[] arrReplaced = new[] { 2, 8, 3 };
            CollectionAssert.AreNotEqual(notArrUnreplaced, helper.ReplaceXwithY(arrUnreplaced, 5, 8));
            CollectionAssert.AreEqual(arrReplaced, helper.ReplaceXwithY(arrUnreplaced, 5, 8));
        }

        [Test]
        public void CalculateAverage()
        {
            ArrayHelper helper = new ArrayHelper();
            int[] arr = new[] { 2, 5, 3, 2, 2, 2, 3, 5 };
            //CollectionAssert.AreEqual(3, helper.GetAverage(arr));
            //CollectionAssert.AreNotEqual(4, helper.GetAverage(arr));
        }

        [Test]
        public void ExtendArray()
        {
            ArrayHelper helper = new ArrayHelper();
            int[] arr = new[] { 2, 5 };
        }
    }
}
