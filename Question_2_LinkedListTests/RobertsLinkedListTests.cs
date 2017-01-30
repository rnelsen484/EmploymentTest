using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question_2_LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_LinkedList.Tests
{
    [TestClass()]
    public class RobertsLinkedListTests
    {
        [TestMethod()]
        public void Test_LinkedList()
        {
            RobertsLinkedList myLinkedList = new RobertsLinkedList();

            ////////////////////////////////////////////
            // TEST LINKED LIST INTEGER
            ////////////////////////////////////////////
            myLinkedList.AppendNew(1);
            myLinkedList.AppendNew(2);
            myLinkedList.AppendNew(3);
            myLinkedList.AppendNew(4);
            myLinkedList.AppendNew(5);
            myLinkedList.AppendNew(6);
            myLinkedList.AppendNew(7);
            myLinkedList.AppendNew(8);
            myLinkedList.AppendNew(9);
            myLinkedList.AppendNew(10);
            myLinkedList.AppendNew(11);
            myLinkedList.AppendNew(12);

            RobertsLinkedList.Node fifthEndNode = myLinkedList.FifthFromEndNode;

            if (fifthEndNode == null)
            {
                Assert.Fail("No Fifth Node");
            }

            int nodeData = (int)fifthEndNode.nodeData;

            if ((int)fifthEndNode.nodeData != 7)
            {
                Assert.Fail("Unexpected result Fifth From Last Linked List");
            }

            ////////////////////////////////////////////
            // TEST LINKED LIST STRING
            ////////////////////////////////////////////

            myLinkedList = new RobertsLinkedList();

            myLinkedList.AppendNew("1");
            myLinkedList.AppendNew("2");
            myLinkedList.AppendNew("3");
            myLinkedList.AppendNew("4");
            myLinkedList.AppendNew("5");
            myLinkedList.AppendNew("6");
            myLinkedList.AppendNew("7");
            myLinkedList.AppendNew("8");
            myLinkedList.AppendNew("9");
            myLinkedList.AppendNew("10");
            myLinkedList.AppendNew("11");
            myLinkedList.AppendNew("12");

            fifthEndNode = myLinkedList.FifthFromEndNode;

            if (fifthEndNode == null)
            {
                Assert.Fail("No Fifth Node");
            }

            string nodeDataString = (string)fifthEndNode.nodeData;

            if (nodeDataString != "7")
            {
                Assert.Fail("Unexpected result Fifth From Last Linked List");
            }
        }
    }
}