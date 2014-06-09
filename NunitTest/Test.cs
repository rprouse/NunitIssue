using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NunitTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCaseSource(typeof(MySource), "TestDataVonBisIdentisch")]
        public void ZeitraumTests(IEnumerable<Zeitraum> testCases)
        {}
    }

    public class MySource : TestCaseData
    {
        private static IEnumerable TestDataVonBisIdentisch()
        {
            yield return new TestCaseData(new[]
                {
                    new Zeitraum(DateTime.Now),
                    new Zeitraum(DateTime.Now),
                    new Zeitraum(DateTime.Now),
                });
        }
    }

    public struct Zeitraum : IComparable
    {
        public Zeitraum(DateTime? date)
        {}

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
