namespace HMS_in_C_Sharp
{
    partial class Room_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Details));
            this.btnViewAllRoomDetail = new Guna.UI.WinForms.GunaButton();
            this.dgvRoomDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Label = new System.Windows.Forms.Label();
            this.Line = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.cbSortByType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbSortByFloor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnSaveChange = new Guna.UI.WinForms.GunaButton();
            this.tbSeats = new System.Windows.Forms.TextBox();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbFloor = new System.Windows.Forms.TextBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetails)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAllRoomDetail
            // 
            this.btnViewAllRoomDetail.AnimationHoverSpeed = 0.07F;
            this.btnViewAllRoomDetail.AnimationSpeed = 0.03F;
            this.btnViewAllRoomDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllRoomDetail.BaseColor = System.Drawing.Color.DimGray;
            this.btnViewAllRoomDetail.BorderColor = System.Drawing.Color.Black;
            this.btnViewAllRoomDetail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewAllRoomDetail.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewAllRoomDetail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllRoomDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewAllRoomDetail.Image = null;
            this.btnViewAllRoomDetail.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewAllRoomDetail.Location = new System.Drawing.Point(851, 127);
            this.btnViewAllRoomDetail.Name = "btnViewAllRoomDetail";
            this.btnViewAllRoomDetail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnViewAllRoomDetail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewAllRoomDetail.OnHoverForeColor = System.Drawing.Color.White;
            this.btnViewAllRoomDetail.OnHoverImage = null;
            this.btnViewAllRoomDetail.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewAllRoomDetail.Radius = 17;
            this.btnViewAllRoomDetail.Size = new System.Drawing.Size(129, 36);
            this.btnViewAllRoomDetail.TabIndex = 35;
            this.btnViewAllRoomDetail.Text = "View All";
            this.btnViewAllRoomDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewAllRoomDetail.Click += new System.EventHandler(this.btnViewAllRoomDetail_Click);
            // 
            // dgvRoomDetails
            // 
            this.dgvRoomDetails.AllowUserToAddRows = false;
            this.dgvRoomDetails.AllowUserToDeleteRows = false;
            this.dgvRoomDetails.AllowUserToResizeColumns = false;
            this.dgvRoomDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvRoomDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoomDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoomDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoomDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoomDetails.ColumnHeadersHeight = 40;
            this.dgvRoomDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoomDetails.EnableHeadersVisualStyles = false;
            this.dgvRoomDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvRoomDetails.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvRoomDetails.Location = new System.Drawing.Point(89, 193);
            this.dgvRoomDetails.Name = "dgvRoomDetails";
            this.dgvRoomDetails.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoomDetails.RowHeadersVisible = false;
            this.dgvRoomDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvRoomDetails.RowTemplate.DividerHeight = 5;
            this.dgvRoomDetails.RowTemplate.Height = 30;
            this.dgvRoomDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomDetails.Size = new System.Drawing.Size(891, 407);
            this.dgvRoomDetails.TabIndex = 34;
            this.dgvRoomDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvRoomDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvRoomDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRoomDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRoomDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRoomDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRoomDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRoomDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvRoomDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvRoomDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRoomDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoomDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRoomDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRoomDetails.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRoomDetails.ThemeStyle.ReadOnly = true;
            this.dgvRoomDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRoomDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoomDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRoomDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRoomDetails.ThemeStyle.RowsStyle.Height = 30;
            this.dgvRoomDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRoomDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRoomDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomDetails_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Floor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fees";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Available Seats";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Edit";
            this.Column6.Image = ((System.Drawing.Image)(resources.GetObject("Column6.Image")));
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Label.Location = new System.Drawing.Point(12, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(203, 41);
            this.Label.TabIndex = 33;
            this.Label.Text = "Total Rooms: ";
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Transparent;
            this.Line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Line.LineThickness = 1;
            this.Line.Location = new System.Drawing.Point(12, 53);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(1045, 20);
            this.Line.TabIndex = 36;
            this.Line.Transparency = 255;
            this.Line.Vertical = false;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalRooms.Location = new System.Drawing.Point(195, 13);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(41, 41);
            this.lblTotalRooms.TabIndex = 33;
            this.lblTotalRooms.Text = " 2";
            // 
            // cbSortByType
            // 
            this.cbSortByType.BackColor = System.Drawing.Color.Transparent;
            this.cbSortByType.BorderRadius = 18;
            this.cbSortByType.BorderThickness = 0;
            this.cbSortByType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortByType.FocusedColor = System.Drawing.Color.Empty;
            this.cbSortByType.FocusedState.Parent = this.cbSortByType;
            this.cbSortByType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSortByType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortByType.FormattingEnabled = true;
            this.cbSortByType.HoverState.Parent = this.cbSortByType;
            this.cbSortByType.ItemHeight = 30;
            this.cbSortByType.ItemsAppearance.Parent = this.cbSortByType;
            this.cbSortByType.Location = new System.Drawing.Point(249, 127);
            this.cbSortByType.Name = "cbSortByType";
            this.cbSortByType.ShadowDecoration.Parent = this.cbSortByType;
            this.cbSortByType.Size = new System.Drawing.Size(111, 36);
            this.cbSortByType.TabIndex = 44;
            this.cbSortByType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbSortByType.SelectedIndexChanged += new System.EventHandler(this.cbSortByType_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(116, 133);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(136, 25);
            this.lbl1.TabIndex = 43;
            this.lbl1.Text = "Show by Type: ";
            // 
            // cbSortByFloor
            // 
            this.cbSortByFloor.BackColor = System.Drawing.Color.Transparent;
            this.cbSortByFloor.BorderRadius = 18;
            this.cbSortByFloor.BorderThickness = 0;
            this.cbSortByFloor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortByFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortByFloor.FocusedColor = System.Drawing.Color.Empty;
            this.cbSortByFloor.FocusedState.Parent = this.cbSortByFloor;
            this.cbSortByFloor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSortByFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortByFloor.FormattingEnabled = true;
            this.cbSortByFloor.HoverState.Parent = this.cbSortByFloor;
            this.cbSortByFloor.ItemHeight = 30;
            this.cbSortByFloor.ItemsAppearance.Parent = this.cbSortByFloor;
            this.cbSortByFloor.Location = new System.Drawing.Point(539, 127);
            this.cbSortByFloor.Name = "cbSortByFloor";
            this.cbSortByFloor.ShadowDecoration.Parent = this.cbSortByFloor;
            this.cbSortByFloor.Size = new System.Drawing.Size(111, 36);
            this.cbSortByFloor.TabIndex = 45;
            this.cbSortByFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbSortByFloor.SelectedIndexChanged += new System.EventHandler(this.cbSortByFloor_SelectedIndexChanged);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.panelEdit.Controls.Add(this.btnCancel);
            this.panelEdit.Controls.Add(this.btnSaveChange);
            this.panelEdit.Controls.Add(this.tbSeats);
            this.panelEdit.Controls.Add(this.tbFees);
            this.panelEdit.Controls.Add(this.tbType);
            this.panelEdit.Controls.Add(this.tbFloor);
            this.panelEdit.Controls.Add(this.tbRoom);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Location = new System.Drawing.Point(333, 253);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(396, 378);
            this.panelEdit.TabIndex = 46;
            this.panelEdit.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(280, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 8;
            this.btnCancel.Size = new System.Drawing.Size(87, 42);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.AnimationHoverSpeed = 0.07F;
            this.btnSaveChange.AnimationSpeed = 0.03F;
            this.btnSaveChange.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChange.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSaveChange.BorderColor = System.Drawing.Color.Black;
            this.btnSaveChange.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveChange.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveChange.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChange.Image")));
            this.btnSaveChange.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveChange.Location = new System.Drawing.Point(117, 305);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.btnSaveChange.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveChange.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveChange.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSaveChange.OnHoverImage")));
            this.btnSaveChange.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveChange.Radius = 8;
            this.btnSaveChange.Size = new System.Drawing.Size(149, 42);
            this.btnSaveChange.TabIndex = 52;
            this.btnSaveChange.Text = "Save Changes";
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // tbSeats
            // 
            this.tbSeats.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbSeats.Location = new System.Drawing.Point(184, 228);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(183, 32);
            this.tbSeats.TabIndex = 51;
            // 
            // tbFees
            // 
            this.tbFees.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbFees.Location = new System.Drawing.Point(184, 179);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(183, 32);
            this.tbFees.TabIndex = 51;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbType.Location = new System.Drawing.Point(184, 130);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(183, 32);
            this.tbType.TabIndex = 51;
            // 
            // tbFloor
            // 
            this.tbFloor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbFloor.Location = new System.Drawing.Point(184, 81);
            this.tbFloor.Name = "tbFloor";
            this.tbFloor.Size = new System.Drawing.Size(183, 32);
            this.tbFloor.TabIndex = 51;
            // 
            // tbRoom
            // 
            this.tbRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbRoom.Location = new System.Drawing.Point(184, 32);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(183, 32);
            this.tbRoom.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(29, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Available Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(112, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(116, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Floor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(73, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Room No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(393, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Show by Floor: ";
            // 
            // Room_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1069, 693);
            this.ControlBox = false;
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.cbSortByFloor);
            this.Controls.Add(this.cbSortByType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTotalRooms);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.btnViewAllRoomDetail);
            this.Controls.Add(this.dgvRoomDetails);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room_Details";
            this.Text = "Room_Details";
            this.Load += new System.EventHandler(this.Room_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomDetails)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnViewAllRoomDetail;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoomDetails;
        private System.Windows.Forms.Label Label;
        private Bunifu.Framework.UI.BunifuSeparator Line;
        private System.Windows.Forms.Label lblTotalRooms;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortByType;
        private System.Windows.Forms.Label lbl1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortByFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbFloor;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btnSaveChange;
        private System.Windows.Forms.TextBox tbSeats;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private System.Windows.Forms.Label label5;
    }
}