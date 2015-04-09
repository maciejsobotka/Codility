using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Codility.L5StacksAndQueues
{
    [TestClass]
    public class TestFish
    {
        [TestMethod]
        public void TestFishMethod1()
        {
            SolutionFish s = new SolutionFish();
            int[] A = { 4, 3, 2, 1, 5 };
            int[] B = { 0, 1, 0, 0, 0 };
            var result = s.solution(A,B);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestFishMethod2()
        {
            SolutionFish s = new SolutionFish();
            int[] A = { 4, 3, 5, 1, 2 };
            int[] B = { 0, 1, 0, 0, 0 };
            var result = s.solution(A, B);
            Assert.AreEqual(4, result);
        }
    }

    class SolutionFish
    {
        /// <summary>
        /// <para>Given two non-empty zero-indexed arrays A and B consistingof</para>
        /// <para>N integers, returns the number of fish that will stay alive.</para>
        /// </summary>
        /// <param name="A">Array with sizes of the fish.</param>
        /// <param name="B">Array contains directions of the fish.</param>
        /// <returns>Number of fish that will stay alive.</returns>
        public int solution(int[] A, int[] B)
        {
            Stack<int> conflictFish = new Stack<int>();
            int fish = A.Length;

            for (int i = 0; i < B.Length; ++i)
            {
                if (B[i] == 1) conflictFish.Push(A[i]);

                if (B[i] == 0)
                    while (conflictFish.Count!=0)
                    {
                        fish--;
                        if (conflictFish.Peek() < A[i]) conflictFish.Pop();
                        else break;
                    }
            }
            return fish;
        }
    }
}
