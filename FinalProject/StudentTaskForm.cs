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
    public partial class StudentTaskForm : Form
    {
        public StudentTaskForm()
        {
            InitializeComponent();
        }

        private void StudentTaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newStudentAndTasksDatabaseDataSet._Student_Task' table. You can move, or remove it, as needed.
            this.student_TaskTableAdapter.Fill(this.newStudentAndTasksDatabaseDataSet._Student_Task);

        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentTaskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.newStudentAndTasksDatabaseDataSet);

            MessageBox.Show("Task status submitted.");
        }
    }
}
