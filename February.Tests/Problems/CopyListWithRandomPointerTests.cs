using February.Problems;
using Newtonsoft.Json;
using NUnit.Framework;
using Shared.Models;

namespace February.Tests.Problems
{
    public class CopyListWithRandomPointerTests
    {
        [Test]
        public void CopyRandomList()
        {
            var i1 = new Node(7);
            var i2 = new Node(13);
            var i3 = new Node(11);
            var i4 = new Node(10);
            var i5 = new Node(1);

            i1.Next = i2;
            i2.Next = i3;
            i3.Next = i4;
            i4.Next = i5;

            i2.Random = i1;
            i3.Random = i5;
            i4.Random = i3;
            i5.Random = i1;

            var e1 = new Node(7);
            var e2 = new Node(13);
            var e3 = new Node(11);
            var e4 = new Node(10);
            var e5 = new Node(1);

            e1.Next = e2;
            e2.Next = e3;
            e3.Next = e4;
            e4.Next = e5;

            e2.Random = e1;
            e3.Random = e5;
            e4.Random = e3;
            e5.Random = e1;

            var sut = new CopyListWithRandomPointer();
            var actual = sut.CopyRandomList(i1);
            Assert.AreNotSame(e1, actual);
            Assert.AreEqual(JsonConvert.SerializeObject(e1,
                    Formatting.None,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }),
                JsonConvert.SerializeObject(actual,
                    Formatting.None,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }));
        }
    }
}
