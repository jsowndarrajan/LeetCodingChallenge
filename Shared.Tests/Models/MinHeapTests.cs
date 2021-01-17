using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shared.Models;

namespace Shared.Tests.Models
{
    public class MinHeapTests
    {
        [Test]
        public void ShouldRemoveItemsInAscendingOrder()
        {
            var minHeap = new MinHeap();
            minHeap.Add(5);
            minHeap.Add(4);
            minHeap.Add(7);
            minHeap.Add(3);
            minHeap.Add(8);
            minHeap.Add(1);
            minHeap.Add(2);
            minHeap.Add(0);

            Assert.AreEqual(0, minHeap.Poll());
            Assert.AreEqual(1, minHeap.Poll());
            Assert.AreEqual(2, minHeap.Poll());
            Assert.AreEqual(3, minHeap.Poll());
            Assert.AreEqual(4, minHeap.Poll());
            Assert.AreEqual(5, minHeap.Poll());
            Assert.AreEqual(7, minHeap.Poll());
            Assert.AreEqual(8, minHeap.Poll());
        }
    }
}
