namespace P9_1214064.view
{
    partial class FormTransaction
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
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbFind);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(524, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 78);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cari";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHapus);
            this.groupBox3.Controls.Add(this.btUbah);
            this.groupBox3.Controls.Add(this.btSimpan);
            this.groupBox3.Controls.Add(this.btrefresh);
            this.groupBox3.Location = new System.Drawing.Point(524, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 179);
            this.groupBox3.TabIndex = 10;
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
            this.groupBox2.Controls.Add(this.tbQuantity);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 263);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Data";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(68, 142);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(165, 20);
            this.tbQuantity.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.tbHarga);
            this.groupBox5.Controls.Add(this.tbProduct);
            this.groupBox5.Controls.Add(this.cbID);
            this.groupBox5.Location = new System.Drawing.Point(68, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(421, 100);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama Barang";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(227, 58);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(186, 20);
            this.tbHarga.TabIndex = 14;
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(6, 58);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.ReadOnly = true;
            this.tbProduct.Size = new System.Drawing.Size(186, 20);
            this.tbProduct.TabIndex = 13;
            // 
            // cbID
            // 
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.FormattingEnabled = true;
            this.cbID.ItemHeight = 13;
            this.cbID.Location = new System.Drawing.Point(6, 11);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(207, 21);
            this.cbID.TabIndex = 13;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(68, 172);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(306, 20);
            this.tbTotal.TabIndex = 10;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Barang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Transaksi";
            // 
            // dtvTransaksi
            // 
            this.dtvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvTransaksi.Location = new System.Drawing.Point(7, 19);
            this.dtvTransaksi.Name = "dtvTransaksi";
            this.dtvTransaksi.Size = new System.Drawing.Size(822, 228);
            this.dtvTransaksi.TabIndex = 0;
            this.dtvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvTransaksi_CellClick);
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 535);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTransaction";
            this.Text = "FormTransaction";
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvTransaksi)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvTransaksi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}