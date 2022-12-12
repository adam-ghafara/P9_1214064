namespace P9_1214064
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNohp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbAlamat = new System.Windows.Forms.RichTextBox();
            this.cbAngkatan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNpm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMahasiswa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Mahasiswa";
            // 
            // dtvMahasiswa
            // 
            this.dtvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMahasiswa.Location = new System.Drawing.Point(7, 20);
            this.dtvMahasiswa.Name = "dtvMahasiswa";
            this.dtvMahasiswa.Size = new System.Drawing.Size(701, 228);
            this.dtvMahasiswa.TabIndex = 0;
            this.dtvMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMahasiswa_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNohp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtbAlamat);
            this.groupBox2.Controls.Add(this.cbAngkatan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbNama);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNpm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            // 
            // tbNohp
            // 
            this.tbNohp.Location = new System.Drawing.Point(52, 209);
            this.tbNohp.Name = "tbNohp";
            this.tbNohp.Size = new System.Drawing.Size(320, 20);
            this.tbNohp.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "No HP";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(52, 183);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(52, 119);
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(320, 58);
            this.rtbAlamat.TabIndex = 8;
            this.rtbAlamat.Text = "";
            // 
            // cbAngkatan
            // 
            this.cbAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAngkatan.FormattingEnabled = true;
            this.cbAngkatan.ItemHeight = 13;
            this.cbAngkatan.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbAngkatan.Location = new System.Drawing.Point(66, 92);
            this.cbAngkatan.Name = "cbAngkatan";
            this.cbAngkatan.Size = new System.Drawing.Size(306, 21);
            this.cbAngkatan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Angkatan";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(52, 63);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(320, 20);
            this.tbNama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // tbNpm
            // 
            this.tbNpm.Location = new System.Drawing.Point(52, 37);
            this.tbNpm.Name = "tbNpm";
            this.tbNpm.Size = new System.Drawing.Size(320, 20);
            this.tbNpm.TabIndex = 1;
            this.tbNpm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHapus);
            this.groupBox3.Controls.Add(this.btUbah);
            this.groupBox3.Controls.Add(this.btSimpan);
            this.groupBox3.Controls.Add(this.btrefresh);
            this.groupBox3.Location = new System.Drawing.Point(407, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 171);
            this.groupBox3.TabIndex = 2;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbFind);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(407, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 78);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cari Mahasiswa";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(49, 26);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(255, 20);
            this.tbFind.TabIndex = 14;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cari";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMahasiswa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNpm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAngkatan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAlamat;
        private System.Windows.Forms.TextBox tbNohp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.DataGridView dtvMahasiswa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label7;
    }
}

