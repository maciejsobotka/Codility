using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Codility.L5StacksAndQueues
{
    [TestClass]
    public class TestStoneWall
    {
        [TestMethod]
        public void TestStoneWallMethod1()
        {
            SolutionStoneWall s = new SolutionStoneWall();
            int[] H = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            var result = s.solution(H);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestStoneWallMethod2()
        {
            SolutionStoneWall s = new SolutionStoneWall();
            int[] H = { 8 };
            var result = s.solution(H);
            Assert.AreEqual(1, result);
        }
    }

    class SolutionStoneWall
    {
        /// <summary>
        /// <para>Given a zero-indexed array H of N positive integers specifying</para>
        /// <para>the height of the wall, returns the minimum number of blocks</para>
        /// <para>needed to build it.</para>
        /// </summary>
        /// <param name="H">Array with heights of the wall.</param>
        /// <returns>Minimum number of blocks needed to build the wall.</returns>
        public int solution(int[] H)
        {
            Stack<int> heights = new Stack<int>();
            int blocks = 0;

            foreach (var i in H)
            {
                if (heights.Count == 0) 
                {
                    blocks++;
                    heights.Push(i);
                }
                else
                {
                    if (heights.Peek() > i)
                    {
                        blocks++;
                        heights.Pop();
                        while (heights.Count != 0)
                        {
                            if (heights.Peek() < i) break;
                            if (heights.Peek() == i)
                            {
                                blocks--;
                                break;
                            }
                            heights.Pop();
                        }
                        heights.Push(i);
                    }
                    if (heights.Peek() < i)
                    {
                        blocks++;
                        heights.Push(i);
                    }
                }
            }
            return blocks;
        }
    }
}
