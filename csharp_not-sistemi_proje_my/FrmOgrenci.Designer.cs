namespace csharp_not_sistemi_proje_my
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbkız = new System.Windows.Forms.RadioButton();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbkulup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnara)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(909, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(722, 482);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(221, 26);
            this.txtad.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(722, 450);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(221, 26);
            this.txtid.TabIndex = 29;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(282, 444);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(113, 38);
            this.btnekle.TabIndex = 28;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(416, 444);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(113, 38);
            this.btnsil.TabIndex = 27;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(148, 444);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(113, 38);
            this.btnguncelle.TabIndex = 26;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(14, 444);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(113, 38);
            this.btnlistele.TabIndex = 25;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Öğrenci Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Öğrenci No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "ÖĞRENCİ İŞLEMLERİ PANELİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 343);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(722, 514);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(221, 26);
            this.txtsoyad.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Öğrenci Kulüp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Öğrenci Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cinsiyet:";
            // 
            // rdbkız
            // 
            this.rdbkız.AutoSize = true;
            this.rdbkız.Location = new System.Drawing.Point(722, 578);
            this.rdbkız.Name = "rdbkız";
            this.rdbkız.Size = new System.Drawing.Size(51, 24);
            this.rdbkız.TabIndex = 37;
            this.rdbkız.TabStop = true;
            this.rdbkız.Text = "Kız";
            this.rdbkız.UseVisualStyleBackColor = true;
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.Location = new System.Drawing.Point(779, 578);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(73, 24);
            this.rdberkek.TabIndex = 38;
            this.rdberkek.TabStop = true;
            this.rdberkek.Text = "Erkek";
            this.rdberkek.UseVisualStyleBackColor = true;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(14, 532);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(372, 26);
            this.txtara.TabIndex = 39;
            // 
            // btnara
            // 
            this.btnara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnara.Image = ((System.Drawing.Image)(resources.GetObject("btnara.Image")));
            this.btnara.Location = new System.Drawing.Point(392, 532);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(27, 26);
            this.btnara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnara.TabIndex = 40;
            this.btnara.TabStop = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Öğrenci Ara";
            // 
            // cmbkulup
            // 
            this.cmbkulup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkulup.FormattingEnabled = true;
            this.cmbkulup.Location = new System.Drawing.Point(722, 546);
            this.cmbkulup.Name = "cmbkulup";
            this.cmbkulup.Size = new System.Drawing.Size(221, 28);
            this.cmbkulup.TabIndex = 42;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 614);
            this.Controls.Add(this.cmbkulup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.rdberkek);
            this.Controls.Add(this.rdbkız);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbkız;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.PictureBox btnara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbkulup;
    }
}