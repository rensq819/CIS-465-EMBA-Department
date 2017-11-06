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
    public partial class ViewStudentTaskStatusForm : Form
    {
        public ViewStudentTaskStatusForm()
        {
            InitializeComponent();
        }

        private void ViewStudentTaskStatusForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newStudentAndTasksDatabaseDataSet.StuIDTasIDTableAdapter' table. You can move, or remove it, as needed.
            this.stuIDTasIDTableAdapterTableAdapter.FillByStuIDAndTasID(this.newStudentAndTasksDatabaseDataSet.StuIDTasIDTableAdapter);

        }

        private void addNewTaskStatusButton_Click(object sender, EventArgs e)
        {
            StudentTaskForm theStudentTaskForm = new StudentTaskForm();

            theStudentTaskForm.ShowDialog();

        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.stuIDTasIDTableAdapterTableAdapter.FillByStuIDAndTasID(this.newStudentAndTasksDatabaseDataSet.StuIDTasIDTableAdapter);
        }
    }
}
