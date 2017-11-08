using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showStuTasFrom_Click(object sender, EventArgs e)
        {
            ViewStudentTaskStatusForm theViewStudentTaskStatusForm = new ViewStudentTaskStatusForm();

            theViewStudentTaskStatusForm.ShowDialog();
        }

        private void showStuTabForm_Click(object sender, EventArgs e)
        {
            ViewStudentTableForm theViewStudentTableForm = new ViewStudentTableForm();

            theViewStudentTableForm.ShowDialog();
        }

        private void showPickUpFormButton_Click(object sender, EventArgs e)
        {
            PickUpForm thePickUpForm = new PickUpForm();

            thePickUpForm.ShowDialog();
        }
    }
}
