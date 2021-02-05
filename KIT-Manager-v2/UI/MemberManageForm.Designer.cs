using System.ComponentModel;

namespace KIT_Manager_v2.UI
{
    partial class MemberManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManageForm));
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.toolStripMemberManage = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxtBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnIconSearch = new System.Windows.Forms.ToolStripButton();
            this.chkBoxFilterClass = new System.Windows.Forms.CheckBox();
            this.comboBoxFilterClass = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPageNum = new System.Windows.Forms.TextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.labelQty = new System.Windows.Forms.Label();
            this.toolStripMemberManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.labelFilter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFilter.Location = new System.Drawing.Point(12, 37);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFilter.Size = new System.Drawing.Size(314, 27);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Lọc Theo";
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.labelInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfo.Location = new System.Drawing.Point(12, 262);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelInfo.Size = new System.Drawing.Size(314, 27);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Thông tin";
            // 
            // toolStripMemberManage
            // 
            this.toolStripMemberManage.AutoSize = false;
            this.toolStripMemberManage.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.toolStripMemberManage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMemberManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripButtonRefresh, this.toolStripSeparator1, this.toolStripSeparator2, this.toolStripTxtBoxSearch, this.toolStripBtnIconSearch});
            this.toolStripMemberManage.Location = new System.Drawing.Point(0, 0);
            this.toolStripMemberManage.Name = "toolStripMemberManage";
            this.toolStripMemberManage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMemberManage.Size = new System.Drawing.Size(947, 30);
            this.toolStripMemberManage.TabIndex = 3;
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(50, 27);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripTxtBoxSearch
            // 
            this.toolStripTxtBoxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTxtBoxSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripTxtBoxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTxtBoxSearch.Name = "toolStripTxtBoxSearch";
            this.toolStripTxtBoxSearch.Size = new System.Drawing.Size(200, 30);
            this.toolStripTxtBoxSearch.Text = "Search...";
            this.toolStripTxtBoxSearch.ToolTipText = "Tìm kiếm...";
            this.toolStripTxtBoxSearch.Enter += new System.EventHandler(this.toolStripTxtBoxSearch_Enter);
            this.toolStripTxtBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearchByName_TextChanged);
            // 
            // toolStripBtnIconSearch
            // 
            this.toolStripBtnIconSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStripBtnIconSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnIconSearch.AutoToolTip = false;
            this.toolStripBtnIconSearch.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnIconSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnIconSearch.Image = ((System.Drawing.Image) (resources.GetObject("toolStripBtnIconSearch.Image")));
            this.toolStripBtnIconSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnIconSearch.Name = "toolStripBtnIconSearch";
            this.toolStripBtnIconSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripBtnIconSearch.Size = new System.Drawing.Size(23, 27);
            // 
            // chkBoxFilterClass
            // 
            this.chkBoxFilterClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkBoxFilterClass.Location = new System.Drawing.Point(12, 67);
            this.chkBoxFilterClass.Name = "chkBoxFilterClass";
            this.chkBoxFilterClass.Size = new System.Drawing.Size(68, 24);
            this.chkBoxFilterClass.TabIndex = 0;
            this.chkBoxFilterClass.Text = "Lớp:";
            this.chkBoxFilterClass.UseVisualStyleBackColor = true;
            this.chkBoxFilterClass.CheckedChanged += new System.EventHandler(this.chkBoxFilterClass_CheckedChanged);
            // 
            // comboBoxFilterClass
            // 
            this.comboBoxFilterClass.FormattingEnabled = true;
            this.comboBoxFilterClass.Location = new System.Drawing.Point(119, 67);
            this.comboBoxFilterClass.Name = "comboBoxFilterClass";
            this.comboBoxFilterClass.Size = new System.Drawing.Size(207, 21);
            this.comboBoxFilterClass.TabIndex = 1;
            this.comboBoxFilterClass.SelectedValueChanged += new System.EventHandler(this.comboBoxFilterClass_SelectedValueChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxID.Location = new System.Drawing.Point(119, 292);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(207, 24);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelID.Location = new System.Drawing.Point(12, 292);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(101, 20);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "Mã Sinh Viên:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelName.Location = new System.Drawing.Point(12, 321);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(135, 20);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Họ và Tên:";
            // 
            // labelDob
            // 
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelDob.Location = new System.Drawing.Point(12, 350);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(135, 20);
            this.labelDob.TabIndex = 9;
            this.labelDob.Text = "Ngày Sinh:";
            // 
            // labelClass
            // 
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelClass.Location = new System.Drawing.Point(12, 409);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(135, 20);
            this.labelClass.TabIndex = 10;
            this.labelClass.Text = "Lớp:";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPhoneNum.Location = new System.Drawing.Point(12, 441);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(135, 20);
            this.labelPhoneNum.TabIndex = 11;
            this.labelPhoneNum.Text = "Số Điện Thoại:";
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 470);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(135, 20);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxName.Location = new System.Drawing.Point(119, 321);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 24);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxClass.Location = new System.Drawing.Point(119, 409);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(207, 24);
            this.textBoxClass.TabIndex = 6;
            // 
            // labelGender
            // 
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelGender.Location = new System.Drawing.Point(12, 379);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(135, 20);
            this.labelGender.TabIndex = 18;
            this.labelGender.Text = "Giới Tính:";
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioBtnMale.Location = new System.Drawing.Point(119, 381);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(66, 22);
            this.radioBtnMale.TabIndex = 4;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Nam";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioBtnFemale.Location = new System.Drawing.Point(268, 381);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(58, 22);
            this.radioBtnFemale.TabIndex = 5;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Nữ";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonAdd.Image = ((System.Drawing.Image) (resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(12, 520);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 25);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonModify.Image = ((System.Drawing.Image) (resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(129, 520);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(83, 25);
            this.buttonModify.TabIndex = 10;
            this.buttonModify.Text = "Sửa";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDelete.Image = ((System.Drawing.Image) (resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(243, 520);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 25);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(332, 37);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(605, 505);
            this.dataGridView.TabIndex = 19;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxPhoneNum.Location = new System.Drawing.Point(119, 441);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(207, 24);
            this.textBoxPhoneNum.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxEmail.Location = new System.Drawing.Point(119, 471);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(207, 24);
            this.textBoxEmail.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(119, 351);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(207, 24);
            this.dateTimePicker.TabIndex = 3;
            // 
            // textBoxPageNum
            // 
            this.textBoxPageNum.Enabled = false;
            this.textBoxPageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxPageNum.Location = new System.Drawing.Point(589, 550);
            this.textBoxPageNum.Name = "textBoxPageNum";
            this.textBoxPageNum.ReadOnly = true;
            this.textBoxPageNum.Size = new System.Drawing.Size(102, 24);
            this.textBoxPageNum.TabIndex = 23;
            this.textBoxPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPrevious.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonPrevious.BackgroundImage")));
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Location = new System.Drawing.Point(559, 549);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(24, 24);
            this.buttonPrevious.TabIndex = 24;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(697, 550);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(24, 24);
            this.buttonNext.TabIndex = 25;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonLast.BackgroundImage")));
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Location = new System.Drawing.Point(727, 549);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(24, 24);
            this.buttonLast.TabIndex = 26;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonFirst.BackgroundImage")));
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Location = new System.Drawing.Point(529, 549);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(24, 24);
            this.buttonFirst.TabIndex = 27;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Enabled = false;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelQty.Location = new System.Drawing.Point(790, 555);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(147, 13);
            this.labelQty.TabIndex = 28;
            this.labelQty.Text = "KIT hiện tại có100 thành viên";
            // 
            // MemberManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(947, 584);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.textBoxPageNum);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNum);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.comboBoxFilterClass);
            this.Controls.Add(this.chkBoxFilterClass);
            this.Controls.Add(this.toolStripMemberManage);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelFilter);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MemberManageForm";
            this.Text = "MemberManageForm";
            this.Shown += new System.EventHandler(this.MemberManageForm_Shown);
            this.toolStripMemberManage.ResumeLayout(false);
            this.toolStripMemberManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelQty;

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;

        private System.Windows.Forms.TextBox textBoxPageNum;

        private System.Windows.Forms.DateTimePicker dateTimePicker;

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNum;

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;

        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxClass;

        private System.Windows.Forms.Label labelEmail;

        private System.Windows.Forms.Label labelPhoneNum;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelClass;

        private System.Windows.Forms.ComboBox comboBoxFilterClass;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;

        private System.Windows.Forms.CheckBox chkBoxFilterClass;

        private System.Windows.Forms.ToolStripTextBox toolStripTxtBoxSearch;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ToolStrip toolStripMemberManage;

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripBtnIconSearch;
    }
}