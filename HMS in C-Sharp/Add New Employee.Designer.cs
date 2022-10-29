namespace HMS_in_C_Sharp
{
    partial class Add_New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Employee));
            this.lbl1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbResidential = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tbCnic = new System.Windows.Forms.TextBox();
            this.datepickerDOB = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbFatherName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblSession = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picAddNewJob = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(92, 172);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 25);
            this.lbl1.TabIndex = 38;
            this.lbl1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(72, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mobile#";
            // 
            // tbMobile
            // 
            this.tbMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMobile.Location = new System.Drawing.Point(184, 364);
            this.tbMobile.Multiline = true;
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(265, 31);
            this.tbMobile.TabIndex = 13;
            // 
            // tbResidential
            // 
            this.tbResidential.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResidential.Location = new System.Drawing.Point(184, 299);
            this.tbResidential.Multiline = true;
            this.tbResidential.Name = "tbResidential";
            this.tbResidential.Size = new System.Drawing.Size(776, 31);
            this.tbResidential.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Residential";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl4.Location = new System.Drawing.Point(617, 237);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(49, 25);
            this.lbl4.TabIndex = 44;
            this.lbl4.Text = "Cnic";
            // 
            // tbCnic
            // 
            this.tbCnic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCnic.Location = new System.Drawing.Point(696, 234);
            this.tbCnic.Multiline = true;
            this.tbCnic.Name = "tbCnic";
            this.tbCnic.Size = new System.Drawing.Size(265, 31);
            this.tbCnic.TabIndex = 43;
            this.tbCnic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCnic_KeyDown);
            this.tbCnic.Validating += new System.ComponentModel.CancelEventHandler(this.tbCnic_Validating);
            // 
            // datepickerDOB
            // 
            this.datepickerDOB.BackColor = System.Drawing.Color.Gray;
            this.datepickerDOB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datepickerDOB.BorderRadius = 0;
            this.datepickerDOB.ForeColor = System.Drawing.Color.White;
            this.datepickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerDOB.FormatCustom = null;
            this.datepickerDOB.Location = new System.Drawing.Point(184, 234);
            this.datepickerDOB.Name = "datepickerDOB";
            this.datepickerDOB.Size = new System.Drawing.Size(265, 31);
            this.datepickerDOB.TabIndex = 42;
            this.datepickerDOB.Value = new System.DateTime(2021, 12, 26, 15, 55, 29, 0);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl3.Location = new System.Drawing.Point(36, 237);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(118, 25);
            this.lbl3.TabIndex = 41;
            this.lbl3.Text = "Date of Birth";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(547, 172);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(119, 25);
            this.lbl2.TabIndex = 40;
            this.lbl2.Text = "Father Name";
            // 
            // tbFatherName
            // 
            this.tbFatherName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFatherName.Location = new System.Drawing.Point(695, 169);
            this.tbFatherName.Multiline = true;
            this.tbFatherName.Name = "tbFatherName";
            this.tbFatherName.Size = new System.Drawing.Size(265, 31);
            this.tbFatherName.TabIndex = 39;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(184, 169);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(265, 31);
            this.tbName.TabIndex = 37;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSession.Location = new System.Drawing.Point(368, 57);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(272, 40);
            this.lblSession.TabIndex = 45;
            this.lblSession.Text = "Employement Form";
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(696, 370);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(142, 29);
            this.cbRole.TabIndex = 46;
            this.cbRole.Text = " -- Select Role --";
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            this.cbRole.Click += new System.EventHandler(this.cbRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(617, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Role";
            // 
            // picAddNewJob
            // 
            this.picAddNewJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddNewJob.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewJob.Image")));
            this.picAddNewJob.Location = new System.Drawing.Point(844, 370);
            this.picAddNewJob.Name = "picAddNewJob";
            this.picAddNewJob.Size = new System.Drawing.Size(37, 31);
            this.picAddNewJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddNewJob.TabIndex = 47;
            this.picAddNewJob.TabStop = false;
            this.picAddNewJob.Click += new System.EventHandler(this.AddNewJob_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(794, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 46);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(881, 370);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(37, 31);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 49;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picEdit
            // 
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Image = ((System.Drawing.Image)(resources.GetObject("picEdit.Image")));
            this.picEdit.Location = new System.Drawing.Point(918, 370);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(37, 31);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 50;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1050, 689);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picAddNewJob);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbResidential);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.tbCnic);
            this.Controls.Add(this.datepickerDOB);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tbFatherName);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_New_Employee";
            this.Text = "Add_New_Employee";
            this.Load += new System.EventHandler(this.Add_New_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbResidential;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbCnic;
        private Bunifu.Framework.UI.BunifuDatepicker datepickerDOB;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbFatherName;
        private System.Windows.Forms.TextBox tbName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSession;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAddNewJob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}