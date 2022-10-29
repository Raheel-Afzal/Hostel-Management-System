namespace HMS_in_C_Sharp
{
    partial class Fees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancelEnrollment = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEarnig = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI.WinForms.GunaButton();
            this.dgvFees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelClearDues = new System.Windows.Forms.Panel();
            this.tbSubmitDues = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnPayDues = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDefaultDues = new System.Windows.Forms.Label();
            this.lblAllotRoom = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnFeesReset = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            this.panelClearDues.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(432, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fees Management";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(41, 97);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 32);
            this.lbl1.TabIndex = 33;
            this.lbl1.Text = "Filter by: ";
            // 
            // cbSortBy
            // 
            this.cbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSortBy.BorderRadius = 18;
            this.cbSortBy.BorderThickness = 0;
            this.cbSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbSortBy.FocusedState.Parent = this.cbSortBy;
            this.cbSortBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortBy.FormattingEnabled = true;
            this.cbSortBy.HoverState.Parent = this.cbSortBy;
            this.cbSortBy.ItemHeight = 30;
            this.cbSortBy.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Pending"});
            this.cbSortBy.ItemsAppearance.Parent = this.cbSortBy;
            this.cbSortBy.Location = new System.Drawing.Point(156, 90);
            this.cbSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.ShadowDecoration.Parent = this.cbSortBy;
            this.cbSortBy.Size = new System.Drawing.Size(147, 36);
            this.cbSortBy.StartIndex = 0;
            this.cbSortBy.TabIndex = 34;
            this.cbSortBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
            // 
            // btnCancelEnrollment
            // 
            this.btnCancelEnrollment.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelEnrollment.BorderThickness = 5;
            this.btnCancelEnrollment.CheckedState.Parent = this.btnCancelEnrollment;
            this.btnCancelEnrollment.CustomImages.Parent = this.btnCancelEnrollment;
            this.btnCancelEnrollment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelEnrollment.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCancelEnrollment.ForeColor = System.Drawing.Color.White;
            this.btnCancelEnrollment.HoverState.Parent = this.btnCancelEnrollment;
            this.btnCancelEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelEnrollment.Location = new System.Drawing.Point(951, 702);
            this.btnCancelEnrollment.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelEnrollment.Name = "btnCancelEnrollment";
            this.btnCancelEnrollment.ShadowDecoration.Parent = this.btnCancelEnrollment;
            this.btnCancelEnrollment.Size = new System.Drawing.Size(223, 44);
            this.btnCancelEnrollment.TabIndex = 47;
            this.btnCancelEnrollment.Text = "Cancel Enrollment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(944, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Month:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonth.Location = new System.Drawing.Point(1035, 97);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMonth.Size = new System.Drawing.Size(120, 32);
            this.lblMonth.TabIndex = 33;
            this.lblMonth.Text = "April,2022";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(868, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fee Collected:";
            // 
            // lblEarnig
            // 
            this.lblEarnig.AutoSize = true;
            this.lblEarnig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblEarnig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEarnig.Location = new System.Drawing.Point(1039, 132);
            this.lblEarnig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEarnig.Name = "lblEarnig";
            this.lblEarnig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEarnig.Size = new System.Drawing.Size(0, 32);
            this.lblEarnig.TabIndex = 33;
            // 
            // btnPay
            // 
            this.btnPay.AnimationHoverSpeed = 0.07F;
            this.btnPay.AnimationSpeed = 0.03F;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BaseColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = null;
            this.btnPay.ImageOffsetX = 6;
            this.btnPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPay.Location = new System.Drawing.Point(1207, 700);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPay.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPay.OnHoverImage = null;
            this.btnPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnPay.Radius = 16;
            this.btnPay.Size = new System.Drawing.Size(149, 46);
            this.btnPay.TabIndex = 48;
            this.btnPay.Text = "PAY";
            this.btnPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToAddRows = false;
            this.dgvFees.AllowUserToDeleteRows = false;
            this.dgvFees.AllowUserToResizeColumns = false;
            this.dgvFees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFees.BackgroundColor = System.Drawing.Color.White;
            this.dgvFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFees.ColumnHeadersHeight = 40;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column8,
            this.Column6,
            this.Column10,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFees.EnableHeadersVisualStyles = false;
            this.dgvFees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvFees.Location = new System.Drawing.Point(47, 185);
            this.dgvFees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFees.RowHeadersVisible = false;
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvFees.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvFees.RowTemplate.DividerHeight = 5;
            this.dgvFees.RowTemplate.Height = 30;
            this.dgvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFees.Size = new System.Drawing.Size(1309, 489);
            this.dgvFees.TabIndex = 49;
            this.dgvFees.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvFees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvFees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvFees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvFees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFees.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvFees.ThemeStyle.ReadOnly = true;
            this.dgvFees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFees.ThemeStyle.RowsStyle.Height = 30;
            this.dgvFees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panelClearDues
            // 
            this.panelClearDues.Controls.Add(this.tbSubmitDues);
            this.panelClearDues.Controls.Add(this.label7);
            this.panelClearDues.Controls.Add(this.btnCancel);
            this.panelClearDues.Controls.Add(this.btnPayDues);
            this.panelClearDues.Controls.Add(this.label4);
            this.panelClearDues.Controls.Add(this.label6);
            this.panelClearDues.Controls.Add(this.label5);
            this.panelClearDues.Controls.Add(this.lblDefaultDues);
            this.panelClearDues.Controls.Add(this.lblAllotRoom);
            this.panelClearDues.Controls.Add(this.lblFatherName);
            this.panelClearDues.Controls.Add(this.lblName);
            this.panelClearDues.Controls.Add(this.lbl);
            this.panelClearDues.Location = new System.Drawing.Point(443, 244);
            this.panelClearDues.Name = "panelClearDues";
            this.panelClearDues.Size = new System.Drawing.Size(400, 390);
            this.panelClearDues.TabIndex = 50;
            // 
            // tbSubmitDues
            // 
            this.tbSubmitDues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubmitDues.Location = new System.Drawing.Point(209, 269);
            this.tbSubmitDues.Margin = new System.Windows.Forms.Padding(4);
            this.tbSubmitDues.MaxLength = 15;
            this.tbSubmitDues.Multiline = true;
            this.tbSubmitDues.Name = "tbSubmitDues";
            this.tbSubmitDues.Size = new System.Drawing.Size(149, 37);
            this.tbSubmitDues.TabIndex = 50;
            this.tbSubmitDues.Text = "0";
            this.tbSubmitDues.TextChanged += new System.EventHandler(this.tbSubmitDues_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Submit Dues:";
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageOffsetX = 6;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(98, 326);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 5;
            this.btnCancel.Size = new System.Drawing.Size(93, 33);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPayDues
            // 
            this.btnPayDues.AnimationHoverSpeed = 0.07F;
            this.btnPayDues.AnimationSpeed = 0.03F;
            this.btnPayDues.BackColor = System.Drawing.Color.Transparent;
            this.btnPayDues.BaseColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPayDues.BorderColor = System.Drawing.Color.Black;
            this.btnPayDues.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayDues.FocusedColor = System.Drawing.Color.Empty;
            this.btnPayDues.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayDues.ForeColor = System.Drawing.Color.White;
            this.btnPayDues.Image = null;
            this.btnPayDues.ImageOffsetX = 6;
            this.btnPayDues.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPayDues.Location = new System.Drawing.Point(199, 326);
            this.btnPayDues.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayDues.Name = "btnPayDues";
            this.btnPayDues.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPayDues.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPayDues.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPayDues.OnHoverImage = null;
            this.btnPayDues.OnPressedColor = System.Drawing.Color.Black;
            this.btnPayDues.Radius = 5;
            this.btnPayDues.Size = new System.Drawing.Size(75, 33);
            this.btnPayDues.TabIndex = 48;
            this.btnPayDues.Text = "PAY";
            this.btnPayDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPayDues.Click += new System.EventHandler(this.btnPayDues_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "Default Dues:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 31);
            this.label6.TabIndex = 40;
            this.label6.Text = "Allot Room:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Father Name:";
            // 
            // lblDefaultDues
            // 
            this.lblDefaultDues.AutoSize = true;
            this.lblDefaultDues.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultDues.ForeColor = System.Drawing.Color.White;
            this.lblDefaultDues.Location = new System.Drawing.Point(203, 210);
            this.lblDefaultDues.Name = "lblDefaultDues";
            this.lblDefaultDues.Size = new System.Drawing.Size(0, 31);
            this.lblDefaultDues.TabIndex = 42;
            // 
            // lblAllotRoom
            // 
            this.lblAllotRoom.AutoSize = true;
            this.lblAllotRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllotRoom.ForeColor = System.Drawing.Color.White;
            this.lblAllotRoom.Location = new System.Drawing.Point(203, 151);
            this.lblAllotRoom.Name = "lblAllotRoom";
            this.lblAllotRoom.Size = new System.Drawing.Size(0, 31);
            this.lblAllotRoom.TabIndex = 42;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.ForeColor = System.Drawing.Color.White;
            this.lblFatherName.Location = new System.Drawing.Point(203, 92);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(0, 31);
            this.lblFatherName.TabIndex = 42;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(203, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 31);
            this.lblName.TabIndex = 42;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(93, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 31);
            this.lbl.TabIndex = 42;
            this.lbl.Text = "Name:";
            // 
            // btnFeesReset
            // 
            this.btnFeesReset.BorderColor = System.Drawing.Color.Transparent;
            this.btnFeesReset.BorderThickness = 5;
            this.btnFeesReset.CheckedState.Parent = this.btnFeesReset;
            this.btnFeesReset.CustomImages.Parent = this.btnFeesReset;
            this.btnFeesReset.FillColor = System.Drawing.SystemColors.GrayText;
            this.btnFeesReset.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnFeesReset.ForeColor = System.Drawing.Color.White;
            this.btnFeesReset.HoverState.Parent = this.btnFeesReset;
            this.btnFeesReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFeesReset.Location = new System.Drawing.Point(47, 702);
            this.btnFeesReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeesReset.Name = "btnFeesReset";
            this.btnFeesReset.ShadowDecoration.Parent = this.btnFeesReset;
            this.btnFeesReset.Size = new System.Drawing.Size(126, 44);
            this.btnFeesReset.TabIndex = 47;
            this.btnFeesReset.Text = "Fees Reset";
            this.btnFeesReset.Click += new System.EventHandler(this.btnFeesReset_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 104.8124F;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 104.8124F;
            this.Column2.HeaderText = "Father Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 104.8124F;
            this.Column5.HeaderText = "Cnic";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 77.00534F;
            this.Column3.HeaderText = "Allot Room";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 104.8124F;
            this.Column8.HeaderText = "Admission Fees";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 104.8124F;
            this.Column6.HeaderText = "Room Fees";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 104.8124F;
            this.Column10.HeaderText = "Remaining Dues";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 89.30766F;
            this.Column4.HeaderText = "Fees Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1404, 805);
            this.Controls.Add(this.panelClearDues);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnFeesReset);
            this.Controls.Add(this.btnCancelEnrollment);
            this.Controls.Add(this.cbSortBy);
            this.Controls.Add(this.lblEarnig);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).EndInit();
            this.panelClearDues.ResumeLayout(false);
            this.panelClearDues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2Button btnCancelEnrollment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEarnig;
        private Guna.UI.WinForms.GunaButton btnPay;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFees;
        private System.Windows.Forms.Panel panelClearDues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbSubmitDues;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaButton btnPayDues;
        private System.Windows.Forms.Label lblDefaultDues;
        private System.Windows.Forms.Label lblAllotRoom;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnFeesReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}