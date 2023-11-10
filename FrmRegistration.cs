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
      
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleName = txtMiddleInitial.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            string getProgram = cmbProgram.Text;
            string getGender = cmbGender.Text;
            string getContact = txtContactNo.Text;
            string setFileName = String.Concat(getStudentNo, ".txt");

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, setFileName));

            string[] info = {
                "Student No: " + getStudentNo,                           
                "FullName: " + getLastName + ", " + getFirstName + ", " + getMiddleName,                            
                "Program: " + getProgram,                             
                "Gender: " + getGender,                            
                "Age: " + getAge,                            
                "Birthday: " + getBirthday,                            
                "Contact No: " + getContact};


            Console.WriteLine(getStudentNo);
            foreach (string i in info)
            {
                outputFile.WriteLine(i);
            }
            outputFile.Close();
            MessageBox.Show("Successfully saved!!!");
            Close();

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
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
