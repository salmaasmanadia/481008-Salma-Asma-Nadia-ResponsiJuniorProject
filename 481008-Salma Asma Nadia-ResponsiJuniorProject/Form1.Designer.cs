namespace _481008_Salma_Asma_Nadia_ResponsiJuniorProject
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
            dgv = new DataGridView();
            lbNama = new Label();
            lbDep = new Label();
            tbNama = new TextBox();
            pbLogo = new PictureBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            cbDep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(52, 245);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(642, 174);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Location = new Point(52, 86);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(93, 15);
            lbNama.TabIndex = 1;
            lbNama.Text = "Nama Karyawan";
            // 
            // lbDep
            // 
            lbDep.AutoSize = true;
            lbDep.Location = new Point(52, 124);
            lbDep.Name = "lbDep";
            lbDep.Size = new Size(85, 15);
            lbDep.TabIndex = 2;
            lbDep.Text = "Dep. Karyawan";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(164, 86);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(150, 23);
            tbNama.TabIndex = 3;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(52, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(62, 58);
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ScrollBar;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(54, 185);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(91, 31);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ScrollBar;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(185, 185);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(91, 31);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(315, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Location = new Point(582, 49);
            label1.Name = "label1";
            label1.Size = new Size(90, 90);
            label1.TabIndex = 9;
            label1.Text = "ID Departemen:\r\nHR: HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Finance\r\n";
            // 
            // cbDep
            // 
            cbDep.Location = new Point(164, 116);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(150, 23);
            cbDep.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(cbDep);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(pbLogo);
            Controls.Add(tbNama);
            Controls.Add(lbDep);
            Controls.Add(lbNama);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label lbNama;
        private Label lbDep;
        private TextBox tbNama;
        private PictureBox pbLogo;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private TextBox cbDep;
    }
}