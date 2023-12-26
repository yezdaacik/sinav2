namespace Yezdanur815
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
            this.dataGridViewIslem = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbGelir = new System.Windows.Forms.CheckBox();
            this.numMiktaryapip = new System.Windows.Forms.NumericUpDown();
            this.cmbTuryapip = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTanim = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktaryapip)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIslem
            // 
            this.dataGridViewIslem.AllowUserToAddRows = false;
            this.dataGridViewIslem.AllowUserToDeleteRows = false;
            this.dataGridViewIslem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslem.Location = new System.Drawing.Point(62, 266);
            this.dataGridViewIslem.Name = "dataGridViewIslem";
            this.dataGridViewIslem.ReadOnly = true;
            this.dataGridViewIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIslem.Size = new System.Drawing.Size(680, 150);
            this.dataGridViewIslem.TabIndex = 34;
            this.dataGridViewIslem.SelectionChanged += new System.EventHandler(this.dataGridViewIslem_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tanım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(203, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "GELİR GİDER TABLOSU";
            // 
            // btnKapat
            // 
            this.btnKapat.Image = global::Yezdanur815.Properties.Resources.power_button;
            this.btnKapat.Location = new System.Drawing.Point(642, 81);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 76);
            this.btnKapat.TabIndex = 27;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Yezdanur815.Properties.Resources._005_trash;
            this.btnSil.Location = new System.Drawing.Point(392, 190);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 50);
            this.btnSil.TabIndex = 26;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::Yezdanur815.Properties.Resources._006_refresh_1;
            this.btnGuncelle.Location = new System.Drawing.Point(392, 137);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 50);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::Yezdanur815.Properties.Resources._004_more;
            this.btnEkle.Location = new System.Drawing.Point(392, 81);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 50);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbGelir
            // 
            this.cbGelir.AutoSize = true;
            this.cbGelir.Location = new System.Drawing.Point(114, 223);
            this.cbGelir.Name = "cbGelir";
            this.cbGelir.Size = new System.Drawing.Size(47, 17);
            this.cbGelir.TabIndex = 23;
            this.cbGelir.Text = "Gelir";
            this.cbGelir.UseVisualStyleBackColor = true;
            // 
            // numMiktaryapip
            // 
            this.numMiktaryapip.Location = new System.Drawing.Point(114, 197);
            this.numMiktaryapip.Name = "numMiktaryapip";
            this.numMiktaryapip.Size = new System.Drawing.Size(120, 20);
            this.numMiktaryapip.TabIndex = 22;
            // 
            // cmbTuryapip
            // 
            this.cmbTuryapip.FormattingEnabled = true;
            this.cmbTuryapip.Items.AddRange(new object[] {
            "Maaş",
            "Fatura",
            "Market",
            "Pazar",
            "Ek Gelir"});
            this.cmbTuryapip.Location = new System.Drawing.Point(114, 170);
            this.cmbTuryapip.Name = "cmbTuryapip";
            this.cmbTuryapip.Size = new System.Drawing.Size(121, 21);
            this.cmbTuryapip.TabIndex = 21;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(114, 144);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 20);
            this.dtTarih.TabIndex = 20;
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(114, 118);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(100, 20);
            this.txtTanim.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewIslem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbGelir);
            this.Controls.Add(this.numMiktaryapip);
            this.Controls.Add(this.cmbTuryapip);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtTanim);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktaryapip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIslem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox cbGelir;
        private System.Windows.Forms.NumericUpDown numMiktaryapip;
        private System.Windows.Forms.ComboBox cmbTuryapip;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtTanim;
        private System.Windows.Forms.TextBox txtId;
    }
}

