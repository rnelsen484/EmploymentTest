using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3_PrimeFactors
{
    public partial class Form_Question_3 : Form
    {
        public Form_Question_3()
        {
            InitializeComponent();
        }

        private void Form_Question_3_Load(object sender, EventArgs e)
        {

        }

        private void button_GeneratePrimeNumbers_Click(object sender, EventArgs e)
        {
            // Read text file
            string[] linesRead = File.ReadAllLines("PrimNumbersInputFile.txt");

            PrimeFactor PF = new PrimeFactor();

            int inputValue;

            foreach (string line in linesRead)
            {
                if (int.TryParse(line, out inputValue) == false)
                {
                    MessageBox.Show("Input Value [ " + line + " ] is not an integer");
                    return;
                }

                List<int> PrimeFactorsList = PF.FindFactors(inputValue);

                string entry = "[ " + inputValue.ToString() + " ] =";

                foreach (int pf in PrimeFactorsList)
                {
                    entry = entry + " " + pf.ToString() + ",";
                }

                entry = entry.TrimEnd(',');

                listBox_primeFactors.Items.Add(entry);
            }
        }

        private void button_ViewFile_Click_1(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "PrimNumbersInputFile.txt");
        }
    }
}
