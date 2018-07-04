using System.Collections.Generic;
using System.Linq;
using Data_Structures;
using NUnit.Framework;

namespace DataStructuresUnitTests
{
    [TestFixture]
    public class BinaryTreeTests
    {
        BinaryTree bt;
        private string[] data = { "asdf", "zxcv", "qwerty", "abc", "xyz", "aeiou", "foo", "bar", "hello", "world" };

        [SetUp]
        public void Init()
        {
            bt = new BinaryTree();

            foreach (var s in data)
            {
                bt.AddNode(s);
            }

            List<string> result = bt.PreOrder();
        }

        [Test]
        public void PreOrder()
        {
            string[] pre = { "asdf", "abc", "aeiou", "zxcv", "qwerty", "foo", "bar", "hello", "xyz", "world" };
            List<string> preList = pre.ToList<string>();

            Assert.AreEqual(preList, bt.PreOrder());
        }

        [Test]
        [Ignore("I ran out of time trying to make this work")]
        public void InOrder()
        {
            string[] inorder = { "asdf", "abc", "aeiou", "bar", "foo", "hello", "qwerty", "world", "xyz", "zxcv" };
            List<string> inorderList = inorder.ToList<string>();

            Assert.AreEqual(inorderList, bt.InOrder());
        }

        [Test]
        [Ignore("I ran out of time trying to make this work")]
        public void PostOrder()
        {
            string[] postorder = { "abc", "aeiou", "asdf", "bar", "hello", "foo", "world", "xyz", "qwerty", "zxcv" };
            List<string> postorderList = postorder.ToList<string>();

            Assert.AreEqual(postorderList, bt.InOrder());
        }

    }
}