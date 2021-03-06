// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using QuickGraph.Unit;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void Constructor01()
        {
            this.Constructor<int, int>(int.MinValue);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void Constructor02()
        {
            this.Constructor<int, int>(0);
        }

    }
}
