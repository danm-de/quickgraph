// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using QuickGraph.Unit;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueTest
    {
        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum01()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum02()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum03()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0
               = new KeyValuePair<int, int>(-1000341494, default(int));
            keyValuePairs[1] = s0;
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum04()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0
               = new KeyValuePair<int, int>(-1000341494, default(int));
            keyValuePairs[1] = s0;
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum05()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(3);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(745284394, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(745284394, default(int));
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(745284394, default(int));
            keyValuePairs[2] = s2;
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum06()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
            KeyValuePair<int, int> s0
               = new KeyValuePair<int, int>(-1087961024, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1
               = new KeyValuePair<int, int>(-1087961024, default(int));
            keyValuePairs[1] = s1;
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum07()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(4);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[4];
            KeyValuePair<int, int> s0
               = new KeyValuePair<int, int>(-1862136912, default(int));
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1
               = new KeyValuePair<int, int>(-1862136912, default(int));
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(402653436, default(int));
            keyValuePairs[2] = s2;
            KeyValuePair<int, int> s3
               = new KeyValuePair<int, int>(-1862136912, default(int));
            keyValuePairs[3] = s3;
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueTest))]
        public void InsertAndMinimum08()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(4);
            KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[5];
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(-771751936, default(int))
              ;
            keyValuePairs[0] = s0;
            KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(-771751936, default(int))
              ;
            keyValuePairs[1] = s1;
            KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(2127912987, default(int))
              ;
            keyValuePairs[2] = s2;
            KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(-771751936, default(int))
              ;
            keyValuePairs[3] = s3;
            KeyValuePair<int, int> s4 = new KeyValuePair<int, int>(-771751936, default(int))
              ;
            keyValuePairs[4] = s4;
            this.InsertAndMinimum<int, int>(binaryHeap, keyValuePairs);
        }

    }
}
