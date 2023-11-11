using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            listOfProgram();
        }

        public void listOfProgram()
        {
            string[] ListOfPrograms = new string[] {
                "BS in Information Technology",
                "BS in Computer Science",
                "BS in Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < ListOfPrograms.Length; i++)
            {
                cmbProgram.Items.Add(ListOfPrograms[i].ToString());
            }

            string[] listOfGender = new string[] {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cmbGender.Items.Add(listOfGender[i].ToString());
            }
        }
    }
}
