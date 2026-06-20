namespace Bayes
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Kayitlar");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Rastgele = new System.Windows.Forms.Button();
            this.Nud_OrnekSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Nud_OzellikSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Nud_OzellikDurumSayisi = new System.Windows.Forms.NumericUpDown();
            this.Nud_SonucSayisi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Sonuclar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Ornek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_RasgeleOrnek = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_OrnekSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_OzellikSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_OzellikDurumSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_SonucSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();

            // treeView1

            this.treeView1.Location = new System.Drawing.Point(15, 274);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Kayitlar";
            treeNode5.Text = "Kayitlar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(682, 258);
            this.treeView1.TabIndex = 0;

            // label1

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Örnek Sayısı : ";

            // Btn_Rastgele

            this.Btn_Rastgele.Location = new System.Drawing.Point(780, 4);
            this.Btn_Rastgele.Name = "Btn_Rastgele";
            this.Btn_Rastgele.Size = new System.Drawing.Size(75, 23);
            this.Btn_Rastgele.TabIndex = 2;
            this.Btn_Rastgele.Text = "Rastgele";
            this.Btn_Rastgele.UseVisualStyleBackColor = true;
            this.Btn_Rastgele.Click += new System.EventHandler(this.Btn_Rastgele_Click);

            // Nud_OrnekSayisi

            this.Nud_OrnekSayisi.Location = new System.Drawing.Point(93, 7);
            this.Nud_OrnekSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_OrnekSayisi.Name = "Nud_OrnekSayisi";
            this.Nud_OrnekSayisi.Size = new System.Drawing.Size(75, 20);
            this.Nud_OrnekSayisi.TabIndex = 3;
            this.Nud_OrnekSayisi.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});

            // label2

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Özellik Sayısı : ";

            // Nud_OzellikSayisi

            this.Nud_OzellikSayisi.Location = new System.Drawing.Point(278, 7);
            this.Nud_OzellikSayisi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Nud_OzellikSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_OzellikSayisi.Name = "Nud_OzellikSayisi";
            this.Nud_OzellikSayisi.Size = new System.Drawing.Size(75, 20);
            this.Nud_OzellikSayisi.TabIndex = 5;
            this.Nud_OzellikSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});

            // label3

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Özelliklerin Durum Sayısı : ";

            // Nud_OzellikDurumSayisi

            this.Nud_OzellikDurumSayisi.Location = new System.Drawing.Point(506, 7);
            this.Nud_OzellikDurumSayisi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Nud_OzellikDurumSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_OzellikDurumSayisi.Name = "Nud_OzellikDurumSayisi";
            this.Nud_OzellikDurumSayisi.Size = new System.Drawing.Size(75, 20);
            this.Nud_OzellikDurumSayisi.TabIndex = 7;
            this.Nud_OzellikDurumSayisi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});

            // Nud_SonucSayisi

            this.Nud_SonucSayisi.Location = new System.Drawing.Point(680, 7);
            this.Nud_SonucSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Nud_SonucSayisi.Name = "Nud_SonucSayisi";
            this.Nud_SonucSayisi.Size = new System.Drawing.Size(75, 20);
            this.Nud_SonucSayisi.TabIndex = 9;
            this.Nud_SonucSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});

            // label4

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sonuç Sayısı : ";

            // dataGridView1

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(682, 235);
            this.dataGridView1.TabIndex = 10;

            // dataGridView2

            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sonuclar});
            this.dataGridView2.Location = new System.Drawing.Point(703, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(152, 235);
            this.dataGridView2.TabIndex = 11;

            // Sonuclar

            this.Sonuclar.HeaderText = "Sonuçlar";
            this.Sonuclar.Name = "Sonuclar";
            this.Sonuclar.ReadOnly = true;

            // dataGridView3

            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ornek});
            this.dataGridView3.Location = new System.Drawing.Point(703, 274);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(152, 229);
            this.dataGridView3.TabIndex = 12;

            // Ornek

            this.Ornek.HeaderText = "Örnek";
            this.Ornek.Name = "Ornek";
            this.Ornek.ReadOnly = true;

            // Btn_RasgeleOrnek

            this.Btn_RasgeleOrnek.Enabled = false;
            this.Btn_RasgeleOrnek.Location = new System.Drawing.Point(703, 509);
            this.Btn_RasgeleOrnek.Name = "Btn_RasgeleOrnek";
            this.Btn_RasgeleOrnek.Size = new System.Drawing.Size(152, 23);
            this.Btn_RasgeleOrnek.TabIndex = 13;
            this.Btn_RasgeleOrnek.Text = "Rastgele Örnek";
            this.Btn_RasgeleOrnek.UseVisualStyleBackColor = true;
            this.Btn_RasgeleOrnek.Click += new System.EventHandler(this.Btn_RasgeleOrnek_Click);

            // label5

            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(15, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sonuç";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label6

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            // ...;

            // Form1

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 576);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_RasgeleOrnek);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nud_SonucSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nud_OzellikDurumSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nud_OzellikSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nud_OrnekSayisi);
            this.Controls.Add(this.Btn_Rastgele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            // ...;
            ((System.ComponentModel.ISupportInitialize)(this.Nud_OrnekSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_OzellikSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_OzellikDurumSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_SonucSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Rastgele;
        private System.Windows.Forms.NumericUpDown Nud_OrnekSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Nud_OzellikSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Nud_OzellikDurumSayisi;
        private System.Windows.Forms.NumericUpDown Nud_SonucSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuclar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ornek;
        private System.Windows.Forms.Button Btn_RasgeleOrnek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

