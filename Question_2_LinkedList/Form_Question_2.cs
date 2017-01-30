using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2_LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_FithFromLast_Integer_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            // FIFTH FROM LAST LINKED LIST USING INTEGER
            //////////////////////////////////////////////////

            RobertsLinkedList myLinkedList = new RobertsLinkedList();

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

            int nodeData = (int)fifthEndNode.nodeData;

            MessageBox.Show("Fifth From Last Node Value (INTEGER) = " + nodeData.ToString());
        }

        private void button_FithFromLast_String_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            // FIFTH FROM LAST LINKED LIST USING STRING
            //////////////////////////////////////////////////

            RobertsLinkedList myLinkedList = new RobertsLinkedList();

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

            RobertsLinkedList.Node fifthEndNode = myLinkedList.FifthFromEndNode;

            string nodeData = (string)fifthEndNode.nodeData;

            MessageBox.Show("Fifth From Last Node Value (STRING) = " + nodeData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
