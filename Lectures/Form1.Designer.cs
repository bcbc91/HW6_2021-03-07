
namespace Lectures
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
            this.dgvLectures = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIcerigi = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.ddlKategorisi = new System.Windows.Forms.ComboBox();
            this.ddlKredisi = new System.Windows.Forms.ComboBox();
            this.bKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLectures
            // 
            this.dgvLectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectures.Location = new System.Drawing.Point(34, 25);
            this.dgvLectures.Name = "dgvLectures";
            this.dgvLectures.RowHeadersWidth = 51;
            this.dgvLectures.RowTemplate.Height = 24;
            this.dgvLectures.Size = new System.Drawing.Size(749, 177);
            this.dgvLectures.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "İçeriği:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kredisi:";
            // 
            // tbIcerigi
            // 
            this.tbIcerigi.Location = new System.Drawing.Point(218, 356);
            this.tbIcerigi.Name = "tbIcerigi";
            this.tbIcerigi.Size = new System.Drawing.Size(161, 22);
            this.tbIcerigi.TabIndex = 2;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(218, 261);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(161, 22);
            this.tbAdi.TabIndex = 2;
            // 
            // ddlKategorisi
            // 
            this.ddlKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKategorisi.FormattingEnabled = true;
            this.ddlKategorisi.Location = new System.Drawing.Point(218, 307);
            this.ddlKategorisi.Name = "ddlKategorisi";
            this.ddlKategorisi.Size = new System.Drawing.Size(161, 24);
            this.ddlKategorisi.TabIndex = 3;
            // 
            // ddlKredisi
            // 
            this.ddlKredisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKredisi.FormattingEnabled = true;
            this.ddlKredisi.Location = new System.Drawing.Point(218, 399);
            this.ddlKredisi.Name = "ddlKredisi";
            this.ddlKredisi.Size = new System.Drawing.Size(161, 24);
            this.ddlKredisi.TabIndex = 3;
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(503, 376);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(138, 47);
            this.bKaydet.TabIndex = 4;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 487);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.ddlKredisi);
            this.Controls.Add(this.ddlKategorisi);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.tbIcerigi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLectures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLectures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIcerigi;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.ComboBox ddlKategorisi;
        private System.Windows.Forms.ComboBox ddlKredisi;
        private System.Windows.Forms.Button bKaydet;
    }
}

