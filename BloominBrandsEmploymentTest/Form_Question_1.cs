using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BloominBrandsEmploymentTest
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Object used to calculate the type of a triangle
        /// </summary>
        RobertsComputeTriangleType computeTriangleType = new RobertsComputeTriangleType();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateScreenTriangleType();
        }

        /////////////////////////////////////////////////////////////
        //
        // QUESTION 1 - TRIANGLE
        //
        /////////////////////////////////////////////////////////////

        private void UpdateScreenTriangleType()
        {
            Label_answer.Text =
                computeTriangleType.Compute((int)numericUpDown_A.Value,
                                        (int)numericUpDown_B.Value,
                                        (int)numericUpDown_C.Value).ToString();
        }

        private void numericUpDown_A_ValueChanged(object sender, EventArgs e)
        {
            UpdateScreenTriangleType();
        }

        private void numericUpDown_C_ValueChanged(object sender, EventArgs e)
        {
            UpdateScreenTriangleType();
        }

        private void numericUpDown_B_ValueChanged(object sender, EventArgs e)
        {
            UpdateScreenTriangleType();
        }

  

 
    }
}
