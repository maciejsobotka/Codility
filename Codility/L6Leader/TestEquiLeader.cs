using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L6Leader
{
    [TestClass]
    public class TestEquiLeader
    {
        [TestMethod]
        public void TestEquiLeaderMethod1()
        {
            SolutionEquiLeader s = new SolutionEquiLeader();
            int[] A = { 4, 3, 4, 4, 4, 2 };
            var result = s.solution(A);
            Assert.AreEqual(2, result);
        }
    }

    class SolutionEquiLeader
    {
        /// <summary>
        /// <para>Given a non-empty zero-indexed array A consisting of N integers,</para>
        /// <para>returns the number of equi leaders.</para>
        /// </summary>
        /// <param name="A">Array with N integers.</param>
        /// <returns>Number of equi leaders.</returns>
        public int solution(int[] A)
        {
            int equiLeaders = 0, leaderNum = 0, leaderVal = -1;

            foreach (var i in A)            // finding leader value
            {
                if (leaderNum == 0)
                {
                    leaderNum++;
                    leaderVal = i;
                }
                else    
                    if (leaderVal != i)   leaderNum--;
                    else    leaderNum++;
            }                               // no leaders
            if (leaderNum == 0) return equiLeaders;

            int leaderCount = 0;
            foreach (var i in A)
                if (i == leaderVal) leaderCount++;
                                            // not enough leader values
            if (leaderCount <= A.Length / 2)   return equiLeaders; 

            leaderNum = 0;
            for(int i = 0; i < A.Length; ++i){
                if(A[i] == leaderVal) leaderNum++;
                var rLeaders = leaderCount - leaderNum;
                if (leaderNum > (i + 1) / 2 && rLeaders > (A.Length - i - 1) / 2)
                    equiLeaders++;
            }
            return equiLeaders;
        }
    }
}
