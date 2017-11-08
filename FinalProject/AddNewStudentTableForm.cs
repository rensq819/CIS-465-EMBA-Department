using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class AddNewStudentTableForm : Form
    {
        public AddNewStudentTableForm()
        {
            InitializeComponent();
        }

        private void yesHousingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            commentsTextBox.Location = new Point(545, 338);
            commentLBL.Location = new Point(471, 341);
            housingTextBox.Location = new Point(544, 261);
            housingLBL.Location = new Point(363, 264);
            housingLBL.Visible = true;
            housingTextBox.Visible = true;
        }

        private void noHousingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            commentsTextBox.Location = new Point(544, 261);
            commentLBL.Location = new Point(471, 264);
            housingTextBox.Location = new Point(545, 358);
            housingLBL.Location = new Point(363, 361);
            housingLBL.Visible = false;
            housingTextBox.Visible = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();

            newStudent.LastName = lastNameTextBox.Text;
            newStudent.FirstName = firstNameTextBox.Text;
            newStudent.EnglishName = englishNameTextBox.Text;
            newStudent.Dob = DOB_DateTimePicker.Value.Date;
            newStudent.Gender = genderComboBox.Text;
            newStudent.Email = emailTextBox.Text;
            newStudent.ArrivalDate = arrivalDateDateTimePicker.Value.Date;
            newStudent.ArrivalTime = arrivalTimeDateTimePicker1.Value.TimeOfDay;
            newStudent.Airline = airlineTextBox.Text;
            newStudent.FlightNum = flightNumberTextBox.Text;
            newStudent.Transport = false;
            newStudent.Housing = false;
            newStudent.HousingAddress = housingTextBox.Text;
            newStudent.Comments = commentsTextBox.Text;

            if (yesTransportationRadioButton.Checked)
            {
                newStudent.Transport = true;
            }

            if (yesHousingRadioButton.Checked)
            {
                newStudent.Housing = true;
            }

            newStudent.SaveData();
        }

        private void AddNewStudentTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newStudentAndTasksDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.newStudentAndTasksDatabaseDataSet.Student);
        }
    }
}