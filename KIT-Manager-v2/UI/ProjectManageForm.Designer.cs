
namespace KIT_Manager_v2.UI
{
    partial class ProjectManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManageForm));
            this.labelQty = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNum = new System.Windows.Forms.TextBox();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.toolStripMemberManage = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxtBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnIconSearch = new System.Windows.Forms.ToolStripButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewGroup)).BeginInit();
            this.toolStripMemberManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Enabled = false;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelQty.Location = new System.Drawing.Point(822, 561);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(126, 13);
            this.labelQty.TabIndex = 58;
            this.labelQty.Text = "KIT hiện tại có 100 nhóm";
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonFirst.BackgroundImage")));
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Location = new System.Drawing.Point(549, 555);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(24, 24);
            this.buttonFirst.TabIndex = 5;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonLast.BackgroundImage")));
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Location = new System.Drawing.Point(747, 555);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(24, 24);
            this.buttonLast.TabIndex = 8;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(717, 556);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(24, 24);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPrevious.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonPrevious.BackgroundImage")));
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Location = new System.Drawing.Point(579, 555);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(24, 24);
            this.buttonPrevious.TabIndex = 6;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // textBoxPageNum
            // 
            this.textBoxPageNum.Enabled = false;
            this.textBoxPageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxPageNum.Location = new System.Drawing.Point(609, 556);
            this.textBoxPageNum.Name = "textBoxPageNum";
            this.textBoxPageNum.ReadOnly = true;
            this.textBoxPageNum.Size = new System.Drawing.Size(102, 24);
            this.textBoxPageNum.TabIndex = 53;
            this.textBoxPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.AllowUserToAddRows = false;
            this.dataGridViewGroup.AllowUserToDeleteRows = false;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Location = new System.Drawing.Point(343, 44);
            this.dataGridViewGroup.MultiSelect = false;
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.ReadOnly = true;
            this.dataGridViewGroup.RowHeadersVisible = false;
            this.dataGridViewGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroup.Size = new System.Drawing.Size(605, 505);
            this.dataGridViewGroup.TabIndex = 52;
            this.dataGridViewGroup.TabStop = false;
            this.dataGridViewGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroup_CellClick);
            this.dataGridViewGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroup_CellClick);
            this.dataGridViewGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroup_CellDoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDelete.Image = ((System.Drawing.Image) (resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(254, 524);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 25);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonModify.Image = ((System.Drawing.Image) (resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(136, 524);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(83, 25);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Sửa";
            this.buttonModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonAdd.Image = ((System.Drawing.Image) (resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(12, 524);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxDescription.Location = new System.Drawing.Point(153, 457);
            this.textBoxDescription.MaxLength = 65536;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(184, 61);
            this.textBoxDescription.TabIndex = 1;
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxGroupName.Location = new System.Drawing.Point(153, 427);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(184, 24);
            this.textBoxGroupName.TabIndex = 0;
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
            this.toolStripMemberManage.Size = new System.Drawing.Size(960, 30);
            this.toolStripMemberManage.TabIndex = 35;
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
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.labelInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfo.Location = new System.Drawing.Point(12, 368);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelInfo.Size = new System.Drawing.Size(325, 27);
            this.labelInfo.TabIndex = 33;
            this.labelInfo.Text = "Thông tin";
            // 
            // labelMember
            // 
            this.labelMember.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.labelMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMember.Location = new System.Drawing.Point(12, 41);
            this.labelMember.Name = "labelMember";
            this.labelMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMember.Size = new System.Drawing.Size(325, 27);
            this.labelMember.TabIndex = 31;
            this.labelMember.Text = "Thành viên";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelDescription.Location = new System.Drawing.Point(12, 479);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(135, 20);
            this.labelDescription.TabIndex = 47;
            this.labelDescription.Text = "Mô Tả Nhóm:";
            // 
            // labelGroupName
            // 
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelGroupName.Location = new System.Drawing.Point(12, 427);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(135, 20);
            this.labelGroupName.TabIndex = 42;
            this.labelGroupName.Text = "Tên Nhóm:";
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelID.Location = new System.Drawing.Point(12, 398);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(135, 20);
            this.labelID.TabIndex = 41;
            this.labelID.Text = "Mã Nhóm:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxID.Location = new System.Drawing.Point(153, 398);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(184, 24);
            this.textBoxID.TabIndex = 30;
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridViewMember.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewMember.MultiSelect = false;
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersVisible = false;
            this.dataGridViewMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMember.Size = new System.Drawing.Size(325, 293);
            this.dataGridViewMember.TabIndex = 59;
            this.dataGridViewMember.TabStop = false;
            // 
            // ProjectManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 584);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.textBoxPageNum);
            this.Controls.Add(this.dataGridViewGroup);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.toolStripMemberManage);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelMember);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectManageForm";
            this.Text = "ProjectManageForm";
            this.Shown += new System.EventHandler(this.MemberManageForm_Shown);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewGroup)).EndInit();
            this.toolStripMemberManage.ResumeLayout(false);
            this.toolStripMemberManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.TextBox textBoxPageNum;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.ToolStrip toolStripMemberManage;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtBoxSearch;
        private System.Windows.Forms.ToolStripButton toolStripBtnIconSearch;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridViewMember;
    }
}