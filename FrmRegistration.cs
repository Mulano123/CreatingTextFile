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
            listOfGender();
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
        }

        public void listOfGender()
        {
            string[] listOfGender = new string[] {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cmbGender.Items.Add(listOfGender[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string FileName = txtStudentNo.Text;
            string getStudentNo = "Student No: " + txtStudentNo.Text;
            string getFulltName = "FullName: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMiddleInitial.Text;
            string getProgram = "Program: " + cmbProgram.Text;
            string getGender = "Gender: " + cmbGender.Text;
            string getAge = "Age: " + txtAge.Text;
            string getBirthday = "Birthday: " + datePickerBirthday.Value.ToString("yyyy-MM-dd");
            string getContact = "Contact No: " + txtContactNo.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter stream = new StreamWriter(Path.Combine(docPath, FileName + ".txt")))
            {
                stream.WriteLine(getStudentNo);
                stream.WriteLine(getFulltName);
                stream.WriteLine(getProgram);
                stream.WriteLine(getGender);
                stream.WriteLine(getAge);
                stream.WriteLine(getBirthday);
                stream.WriteLine(getContact);

            }

            MessageBox.Show("Registered Successfully.");
            Close();
        }
    }
}
