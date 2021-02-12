using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using Shared.Helpers;
using Shared.Models;

namespace Shared.Tests.Helpers
{
    public class ListHelperTests
    {
        [Test, TestCaseSource(nameof(TestCaseSource))]
        public void ConvertStringToListNodeWithRandomPointer(string input, Node expected)
        {
            var actual = ListHelper.ConvertStringToListNodeWithRandomPointer(input);
            Assert.AreEqual(JsonConvert.SerializeObject(expected,
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

        public static object[] TestCaseSource => new[]
        {
            new object[]
            {
                "[[7,null],[13,0],[11,4],[10,2],[1,0]]",
                GetExpected1()
            }
        };

        private static Node GetExpected1()
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

            return i1;
        }
    }
}
