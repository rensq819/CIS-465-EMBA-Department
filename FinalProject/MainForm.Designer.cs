namespace FinalProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.showPickUpFormButton = new System.Windows.Forms.Button();
            this.showStuTasFrom = new System.Windows.Forms.Button();
            this.showStuTabForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showPickUpFormButton
            // 
            this.showPickUpFormButton.BackColor = System.Drawing.Color.White;
            this.showPickUpFormButton.Location = new System.Drawing.Point(405, 179);
            this.showPickUpFormButton.Name = "showPickUpFormButton";
            this.showPickUpFormButton.Size = new System.Drawing.Size(213, 50);
            this.showPickUpFormButton.TabIndex = 0;
            this.showPickUpFormButton.Text = "Show Pick Up Form";
            this.showPickUpFormButton.UseVisualStyleBackColor = false;
            this.showPickUpFormButton.Visible = false;
            this.showPickUpFormButton.Click += new System.EventHandler(this.showPickUpFormButton_Click);
            // 
            // showStuTasFrom
            // 
            this.showStuTasFrom.BackColor = System.Drawing.Color.White;
            this.showStuTasFrom.Location = new System.Drawing.Point(405, 46);
            this.showStuTasFrom.Name = "showStuTasFrom";
            this.showStuTasFrom.Size = new System.Drawing.Size(213, 50);
            this.showStuTasFrom.TabIndex = 1;
            this.showStuTasFrom.Text = "Show Student-Task";
            this.showStuTasFrom.UseVisualStyleBackColor = false;
            this.showStuTasFrom.Click += new System.EventHandler(this.showStuTasFrom_Click);
            // 
            // showStuTabForm
            // 
            this.showStuTabForm.BackColor = System.Drawing.Color.White;
            this.showStuTabForm.Location = new System.Drawing.Point(39, 46);
            this.showStuTabForm.Name = "showStuTabForm";
            this.showStuTabForm.Size = new System.Drawing.Size(213, 50);
            this.showStuTabForm.TabIndex = 2;
            this.showStuTabForm.Text = "Show Student Info";
            this.showStuTabForm.UseVisualStyleBackColor = false;
            this.showStuTabForm.Click += new System.EventHandler(this.showStuTabForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 404);
            this.Controls.Add(this.showStuTabForm);
            this.Controls.Add(this.showStuTasFrom);
            this.Controls.Add(this.showPickUpFormButton);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showPickUpFormButton;
        private System.Windows.Forms.Button showStuTasFrom;
        private System.Windows.Forms.Button showStuTabForm;
    }
}