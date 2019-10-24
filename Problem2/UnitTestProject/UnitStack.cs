using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;
namespace UnitTestProject
{
    [TestClass]
    public class UnitStack
    {   
        [TestMethod]
        public void TestMethodPush()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestMethodPop()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual("2", S.Pop());
        }
        [TestMethod]
        public void TestMethodPeek()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Peek());
            Assert.AreEqual(3, S.Count());
        }
        [TestMethod]
        public void TestMethodClear()
        {
            MyStack S = new MyStack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            S.Clear();
            Assert.AreEqual(0,S.Count());
        }
    }
}
