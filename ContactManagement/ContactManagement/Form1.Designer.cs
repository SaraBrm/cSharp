namespace ContactManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtMobile = new TextBox();
            txtFamily = new TextBox();
            txtName = new TextBox();
            Delete = new Button();
            Update = new Button();
            Save = new Button();
            txtId = new TextBox();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(649, 178);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(txtFamily);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 223);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات مخاطبین";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 187);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 14;
            label4.Text = "تلفن:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 140);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 13;
            label3.Text = "موبایل:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 94);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 12;
            label2.Text = "فامیلی: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 47);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 11;
            label1.Text = " نام : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(9, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(135, 29);
            txtPhone.TabIndex = 10;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(9, 140);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(135, 29);
            txtMobile.TabIndex = 9;
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(9, 94);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(135, 29);
            txtFamily.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(9, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(135, 29);
            txtName.TabIndex = 7;
            // 
            // Delete
            // 
            Delete.Location = new Point(202, 251);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 39);
            Delete.TabIndex = 11;
            Delete.Text = "حذف";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(112, 251);
            Update.Name = "Update";
            Update.Size = new Size(75, 39);
            Update.TabIndex = 10;
            Update.Text = "ویرایش";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Save
            // 
            Save.Location = new Point(20, 251);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 9;
            Save.Text = "ذخیره";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(287, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(111, 29);
            txtId.TabIndex = 12;
            txtId.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Location = new Point(414, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستجوی مخاطب";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(188, 29);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 486);
            Controls.Add(groupBox2);
            Controls.Add(txtId);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Save);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "مدیریت مخاطبین";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtMobile;
        private TextBox txtFamily;
        private TextBox txtName;
        private Button Delete;
        private Button Update;
        private Button Save;
        private TextBox txtId;
        private GroupBox groupBox2;
        private TextBox txtSearch;
    }
}