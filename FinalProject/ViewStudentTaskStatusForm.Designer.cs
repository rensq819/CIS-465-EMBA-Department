﻿namespace FinalProject
{
    partial class ViewStudentTaskStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentTaskStatusForm));
            this.newStudentAndTasksDatabaseDataSet = new FinalProject.NewStudentAndTasksDatabaseDataSet();
            this.stuIDTasIDTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuIDTasIDTableAdapterTableAdapter = new FinalProject.NewStudentAndTasksDatabaseDataSetTableAdapters.StuIDTasIDTableAdapterTableAdapter();
            this.tableAdapterManager = new FinalProject.NewStudentAndTasksDatabaseDataSetTableAdapters.TableAdapterManager();
            this.stuIDTasIDTableAdapterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.stuIDTasIDTableAdapterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewTaskStatusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentAndTasksDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuIDTasIDTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuIDTasIDTableAdapterBindingNavigator)).BeginInit();
            this.stuIDTasIDTableAdapterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuIDTasIDTableAdapterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newStudentAndTasksDatabaseDataSet
            // 
            this.newStudentAndTasksDatabaseDataSet.DataSetName = "NewStudentAndTasksDatabaseDataSet";
            this.newStudentAndTasksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuIDTasIDTableAdapterBindingSource
            // 
            this.stuIDTasIDTableAdapterBindingSource.DataMember = "StuIDTasIDTableAdapter";
            this.stuIDTasIDTableAdapterBindingSource.DataSource = this.newStudentAndTasksDatabaseDataSet;
            // 
            // stuIDTasIDTableAdapterTableAdapter
            // 
            this.stuIDTasIDTableAdapterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Student_TaskTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.NewStudentAndTasksDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stuIDTasIDTableAdapterBindingNavigator
            // 
            this.stuIDTasIDTableAdapterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stuIDTasIDTableAdapterBindingNavigator.BindingSource = this.stuIDTasIDTableAdapterBindingSource;
            this.stuIDTasIDTableAdapterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stuIDTasIDTableAdapterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stuIDTasIDTableAdapterBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stuIDTasIDTableAdapterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorRefreshItem});
            this.stuIDTasIDTableAdapterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stuIDTasIDTableAdapterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stuIDTasIDTableAdapterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stuIDTasIDTableAdapterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stuIDTasIDTableAdapterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stuIDTasIDTableAdapterBindingNavigator.Name = "stuIDTasIDTableAdapterBindingNavigator";
            this.stuIDTasIDTableAdapterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stuIDTasIDTableAdapterBindingNavigator.Size = new System.Drawing.Size(1360, 39);
            this.stuIDTasIDTableAdapterBindingNavigator.TabIndex = 0;
            this.stuIDTasIDTableAdapterBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshItem.Image")));
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(28, 36);
            this.bindingNavigatorRefreshItem.Text = "Refresh";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // stuIDTasIDTableAdapterDataGridView
            // 
            this.stuIDTasIDTableAdapterDataGridView.AutoGenerateColumns = false;
            this.stuIDTasIDTableAdapterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuIDTasIDTableAdapterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.stuIDTasIDTableAdapterDataGridView.DataSource = this.stuIDTasIDTableAdapterBindingSource;
            this.stuIDTasIDTableAdapterDataGridView.Location = new System.Drawing.Point(41, 75);
            this.stuIDTasIDTableAdapterDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stuIDTasIDTableAdapterDataGridView.Name = "stuIDTasIDTableAdapterDataGridView";
            this.stuIDTasIDTableAdapterDataGridView.RowTemplate.Height = 28;
            this.stuIDTasIDTableAdapterDataGridView.Size = new System.Drawing.Size(1269, 454);
            this.stuIDTasIDTableAdapterDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TaskStatus";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TaskStatus";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TaskID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TaskID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TaskName";
            this.dataGridViewTextBoxColumn5.HeaderText = "TaskName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TaskCategory";
            this.dataGridViewTextBoxColumn6.HeaderText = "TaskCategory";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // addNewTaskStatusButton
            // 
            this.addNewTaskStatusButton.Location = new System.Drawing.Point(180, 571);
            this.addNewTaskStatusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewTaskStatusButton.Name = "addNewTaskStatusButton";
            this.addNewTaskStatusButton.Size = new System.Drawing.Size(239, 74);
            this.addNewTaskStatusButton.TabIndex = 2;
            this.addNewTaskStatusButton.Text = "Add New Task Status";
            this.addNewTaskStatusButton.UseVisualStyleBackColor = true;
            this.addNewTaskStatusButton.Click += new System.EventHandler(this.addNewTaskStatusButton_Click);
            // 
            // ViewStudentTaskStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(1360, 674);
            this.Controls.Add(this.addNewTaskStatusButton);
            this.Controls.Add(this.stuIDTasIDTableAdapterDataGridView);
            this.Controls.Add(this.stuIDTasIDTableAdapterBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewStudentTaskStatusForm";
            this.Text = "ViewStudentTaskStatusForm";
            this.Load += new System.EventHandler(this.ViewStudentTaskStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newStudentAndTasksDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuIDTasIDTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuIDTasIDTableAdapterBindingNavigator)).EndInit();
            this.stuIDTasIDTableAdapterBindingNavigator.ResumeLayout(false);
            this.stuIDTasIDTableAdapterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuIDTasIDTableAdapterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewStudentAndTasksDatabaseDataSet newStudentAndTasksDatabaseDataSet;
        private System.Windows.Forms.BindingSource stuIDTasIDTableAdapterBindingSource;
        private NewStudentAndTasksDatabaseDataSetTableAdapters.StuIDTasIDTableAdapterTableAdapter stuIDTasIDTableAdapterTableAdapter;
        private NewStudentAndTasksDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stuIDTasIDTableAdapterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView stuIDTasIDTableAdapterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button addNewTaskStatusButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
    }
}