using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L99FutureTraning
{
    [TestClass]
    public class TestTreeHeight
    {
        [TestMethod]
        public void TestTreeHeightMethod1()
        {
            SolutionTreeHeight s = new SolutionTreeHeight();
            Tree t4 = new Tree(20 , null, null);
            Tree t5 = new Tree(21, null, null);
            Tree t6 = new Tree(1, null, null);
            Tree t2 = new Tree(3, t4, t5);
            Tree t3 = new Tree(10, t6, null);
            Tree t1 = new Tree(5, t2, t3);
            var result = s.solution(t1);
            Assert.AreEqual(2, result);
        }
    }

    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;

        public Tree() { }
        public Tree(int x, Tree l, Tree r)
        {
            this.x = x;
            this.l = l;
            this.r = r;
        }
    };

    class SolutionTreeHeight
    {
        /// <summary>
        /// Finds Tree height.
        /// </summary>
        /// <param name="T">Tree to find its height.</param>
        /// <returns>Tree height.</returns>
        public int solution(Tree T)
        {
            return TreeHeight(0, T);
        }

        /// <summary>
        /// Seeks Tree height recursively.
        /// </summary>
        /// <param name="height">Current height.</param>
        /// <param name="T">Tree to search<./param>
        /// <returns>Tree height.</returns>
        public int TreeHeight(int height, Tree T)
        {
            int h1=height, h2=height;
            if (T.l != null) h1 = TreeHeight(height + 1, T.l);
            if (T.r != null) h2 = TreeHeight(height + 1, T.r);
            return Math.Max(h1, h2);
        }
    }
}
