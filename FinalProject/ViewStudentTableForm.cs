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
    public partial class ViewStudentTableForm : Form
    {
        public ViewStudentTableForm()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.newStudentAndTasksDatabaseDataSet);

        }

        private void ViewStudentTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newStudentAndTasksDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            studentTableAdapter.Fill(this.newStudentAndTasksDatabaseDataSet.Student);

        }

        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            AddNewStudentTableForm theAddNewStudentTableForm = new AddNewStudentTableForm();

            theAddNewStudentTableForm.ShowDialog();
        }

        private void sortByArrivalDateButton_Click(object sender, EventArgs e)
        {
            studentTableAdapter.FillByArrivalDate(newStudentAndTasksDatabaseDataSet.Student);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            studentTableAdapter.Fill(newStudentAndTasksDatabaseDataSet.Student);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(newStudentAndTasksDatabaseDataSet.Student);
        }
    }
}
