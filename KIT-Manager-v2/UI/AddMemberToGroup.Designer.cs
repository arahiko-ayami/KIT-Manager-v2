
namespace KIT_Manager_v2.UI
{
    partial class AddMemberToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemberToGroup));
            this.dataGridViewStudentOnDb = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentInGroup = new System.Windows.Forms.DataGridView();
            this.textBoxSearchFromDb = new System.Windows.Forms.TextBox();
            this.textBoxSearchFromGroup = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudentOnDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudentInGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentOnDb
            // 
            this.dataGridViewStudentOnDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentOnDb.Location = new System.Drawing.Point(4, 32);
            this.dataGridViewStudentOnDb.MultiSelect = false;
            this.dataGridViewStudentOnDb.Name = "dataGridViewStudentOnDb";
            this.dataGridViewStudentOnDb.RowHeadersVisible = false;
            this.dataGridViewStudentOnDb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentOnDb.Size = new System.Drawing.Size(446, 562);
            this.dataGridViewStudentOnDb.TabIndex = 0;
            this.dataGridViewStudentOnDb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentOnDb_CellClick);
            this.dataGridViewStudentOnDb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentOnDb_CellClick);
            // 
            // dataGridViewStudentInGroup
            // 
            this.dataGridViewStudentInGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentInGroup.Location = new System.Drawing.Point(516, 32);
            this.dataGridViewStudentInGroup.MultiSelect = false;
            this.dataGridViewStudentInGroup.Name = "dataGridViewStudentInGroup";
            this.dataGridViewStudentInGroup.RowHeadersVisible = false;
            this.dataGridViewStudentInGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentInGroup.Size = new System.Drawing.Size(446, 562);
            this.dataGridViewStudentInGroup.TabIndex = 1;
            this.dataGridViewStudentInGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentInGroup_CellClick);
            this.dataGridViewStudentInGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentInGroup_CellClick);
            // 
            // textBoxSearchFromDb
            // 
            this.textBoxSearchFromDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxSearchFromDb.Location = new System.Drawing.Point(4, 3);
            this.textBoxSearchFromDb.Name = "textBoxSearchFromDb";
            this.textBoxSearchFromDb.Size = new System.Drawing.Size(446, 24);
            this.textBoxSearchFromDb.TabIndex = 2;
            this.textBoxSearchFromDb.TextChanged += new System.EventHandler(this.textBoxSearchFromDb_TextChanged);
            // 
            // textBoxSearchFromGroup
            // 
            this.textBoxSearchFromGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxSearchFromGroup.Location = new System.Drawing.Point(516, 3);
            this.textBoxSearchFromGroup.Name = "textBoxSearchFromGroup";
            this.textBoxSearchFromGroup.Size = new System.Drawing.Size(446, 24);
            this.textBoxSearchFromGroup.TabIndex = 3;
            this.textBoxSearchFromGroup.TextChanged += new System.EventHandler(this.textBoxSearchFromGroup_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(467, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(32, 32);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("buttonRemove.BackgroundImage")));
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Location = new System.Drawing.Point(467, 308);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // AddMemberToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 601);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearchFromGroup);
            this.Controls.Add(this.textBoxSearchFromDb);
            this.Controls.Add(this.dataGridViewStudentInGroup);
            this.Controls.Add(this.dataGridViewStudentOnDb);
            this.Name = "AddMemberToGroup";
            this.Text = "AddMemberToGroup";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudentOnDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudentInGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentOnDb;
        private System.Windows.Forms.DataGridView dataGridViewStudentInGroup;
        private System.Windows.Forms.TextBox textBoxSearchFromDb;
        private System.Windows.Forms.TextBox textBoxSearchFromGroup;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
    }
}