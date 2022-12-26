namespace P9_1214064.view
{
    partial class FormNilai
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btExport = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMatkul = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbNilai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNPM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvNilai = new System.Windows.Forms.DataGridView();
            this.tbSiswa = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btExport);
            this.groupBox4.Controls.Add(this.tbFind);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(405, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 86);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cari";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(57, 45);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(96, 23);
            this.btExport.TabIndex = 15;
            this.btExport.Text = "Export to Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(57, 19);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(255, 20);
            this.tbFind.TabIndex = 14;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cari";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHapus);
            this.groupBox3.Controls.Add(this.btUbah);
            this.groupBox3.Controls.Add(this.btSimpan);
            this.groupBox3.Controls.Add(this.btrefresh);
            this.groupBox3.Location = new System.Drawing.Point(405, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 171);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(7, 136);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(306, 23);
            this.btHapus.TabIndex = 3;
            this.btHapus.Text = "&Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(6, 102);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(306, 23);
            this.btUbah.TabIndex = 2;
            this.btUbah.Text = "&Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(7, 68);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(306, 23);
            this.btSimpan.TabIndex = 1;
            this.btSimpan.Text = "&Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(7, 34);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(306, 23);
            this.btrefresh.TabIndex = 0;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMatkul);
            this.groupBox2.Controls.Add(this.cbCategory);
            this.groupBox2.Controls.Add(this.tbNilai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbNPM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 263);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Data";
            // 
            // cbMatkul
            // 
            this.cbMatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatkul.FormattingEnabled = true;
            this.cbMatkul.ItemHeight = 13;
            this.cbMatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Literasi Data",
            "PKN",
            "Sistem ERP",
            "General English I",
            "General English II"});
            this.cbMatkul.Location = new System.Drawing.Point(66, 33);
            this.cbMatkul.Name = "cbMatkul";
            this.cbMatkul.Size = new System.Drawing.Size(306, 21);
            this.cbMatkul.TabIndex = 12;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 13;
            this.cbCategory.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbCategory.Location = new System.Drawing.Point(66, 77);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(306, 21);
            this.cbCategory.TabIndex = 11;
            // 
            // tbNilai
            // 
            this.tbNilai.Location = new System.Drawing.Point(66, 165);
            this.tbNilai.Name = "tbNilai";
            this.tbNilai.Size = new System.Drawing.Size(306, 20);
            this.tbNilai.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nilai";
            // 
            // cbNPM
            // 
            this.cbNPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNPM.FormattingEnabled = true;
            this.cbNPM.ItemHeight = 13;
            this.cbNPM.Location = new System.Drawing.Point(66, 121);
            this.cbNPM.Name = "cbNPM";
            this.cbNPM.Size = new System.Drawing.Size(137, 21);
            this.cbNPM.TabIndex = 7;
            this.cbNPM.SelectedIndexChanged += new System.EventHandler(this.cbNPM_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvNilai);
            this.groupBox1.Location = new System.Drawing.Point(11, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Nilai Mahasiswa";
            // 
            // dtvNilai
            // 
            this.dtvNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNilai.Location = new System.Drawing.Point(7, 19);
            this.dtvNilai.Name = "dtvNilai";
            this.dtvNilai.Size = new System.Drawing.Size(701, 228);
            this.dtvNilai.TabIndex = 0;
            this.dtvNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvNilai_CellClick);
            // 
            // tbSiswa
            // 
            this.tbSiswa.Location = new System.Drawing.Point(220, 385);
            this.tbSiswa.Name = "tbSiswa";
            this.tbSiswa.Size = new System.Drawing.Size(163, 20);
            this.tbSiswa.TabIndex = 13;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 532);
            this.Controls.Add(this.tbSiswa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNilai_FormClosing);
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvNilai;
        private System.Windows.Forms.ComboBox cbMatkul;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbSiswa;
        private System.Windows.Forms.Button btExport;
    }
}