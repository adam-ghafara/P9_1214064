namespace P9_1214064.view
{
    partial class FormProduct
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvProduk = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduk)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHapus);
            this.groupBox3.Controls.Add(this.btUbah);
            this.groupBox3.Controls.Add(this.btSimpan);
            this.groupBox3.Controls.Add(this.btrefresh);
            this.groupBox3.Location = new System.Drawing.Point(397, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 185);
            this.groupBox3.TabIndex = 9;
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
            this.groupBox2.Controls.Add(this.tbHarga);
            this.groupBox2.Controls.Add(this.tbProduct);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 159);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Data";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(85, 81);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(297, 20);
            this.tbHarga.TabIndex = 11;
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(85, 37);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(297, 20);
            this.tbProduct.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvProduk);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 254);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Barang";
            // 
            // dtvProduk
            // 
            this.dtvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProduk.Location = new System.Drawing.Point(7, 19);
            this.dtvProduk.Name = "dtvProduk";
            this.dtvProduk.Size = new System.Drawing.Size(701, 228);
            this.dtvProduk.TabIndex = 0;
            this.dtvProduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvProduk_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbFind);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(3, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 78);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cari";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(85, 22);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(297, 20);
            this.tbFind.TabIndex = 14;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cari Produk";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 509);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProduk)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvProduk;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label7;
    }
}