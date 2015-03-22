using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Codility.L5StacksAndQueues
{
    [TestClass]
    public class TestBrackets
    {
        [TestMethod]
        public void TestBracketsMethod1()
        {
            SolutionBrackets s = new SolutionBrackets();
            String S = "{[()()]}";
            var result = s.solution(S); ;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestBracketsMethod2()
        {
            SolutionBrackets s = new SolutionBrackets();
            String S = "([)()]";
            var result = s.solution(S); ;
            Assert.AreEqual(0, result);
        }
    }

    class SolutionBrackets
    {
        /// <summary>
        /// <para>Given a string S consisting of N characters, returns 1</para>
        /// <para>if S is properly nested and 0 otherwise.</para>
        /// </summary>
        /// <param name="S">String consisting of brackets characters.</param>
        /// <returns>
        /// <para>1: String properly nested.</para>
        /// <para>0: String not nested properly.</para>
        /// </returns>
        public int solution(string S)
        {
            if (String.IsNullOrEmpty(S)) return 1;
            var stack = new Stack<char>(S.Length);
            foreach (var c in S)
            {
                switch (c)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return 0;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return 0;
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return 0;
                        break;
                    default:
                        return 0;
                }
            }
            if (stack.Count != 0)   return 0;
            return 1;
        }
    }
}
