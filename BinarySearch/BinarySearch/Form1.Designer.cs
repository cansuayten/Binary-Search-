namespace BinarySearch
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ok = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.btn_sayi11 = new System.Windows.Forms.Button();
            this.btn_sayi10 = new System.Windows.Forms.Button();
            this.btn_sayi9 = new System.Windows.Forms.Button();
            this.btn_sayi8 = new System.Windows.Forms.Button();
            this.btn_sayi7 = new System.Windows.Forms.Button();
            this.btn_sayi6 = new System.Windows.Forms.Button();
            this.btn_sayi5 = new System.Windows.Forms.Button();
            this.btn_sayi4 = new System.Windows.Forms.Button();
            this.btn_sayi3 = new System.Windows.Forms.Button();
            this.btn_sayi2 = new System.Windows.Forms.Button();
            this.btn_sayi1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ok.Location = new System.Drawing.Point(240, 30);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(52, 43);
            this.ok.TabIndex = 126;
            this.ok.Text = "←";
            this.ok.Visible = false;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(419, 355);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(75, 25);
            this.lbl_sonuc.TabIndex = 125;
            this.lbl_sonuc.Text = "Sonuç:";
            this.lbl_sonuc.Visible = false;
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(495, 280);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(100, 22);
            this.txt_sayi.TabIndex = 124;
            this.txt_sayi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sayi_KeyDown);
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.AutoSize = true;
            this.lbl_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi.Location = new System.Drawing.Point(397, 270);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(79, 32);
            this.lbl_sayi.TabIndex = 123;
            this.lbl_sayi.Text = "Sayı:";
            // 
            // btn_sayi11
            // 
            this.btn_sayi11.Location = new System.Drawing.Point(126, 719);
            this.btn_sayi11.Name = "btn_sayi11";
            this.btn_sayi11.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi11.TabIndex = 122;
            this.btn_sayi11.Text = "823";
            this.btn_sayi11.UseVisualStyleBackColor = true;
            // 
            // btn_sayi10
            // 
            this.btn_sayi10.Location = new System.Drawing.Point(126, 650);
            this.btn_sayi10.Name = "btn_sayi10";
            this.btn_sayi10.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi10.TabIndex = 121;
            this.btn_sayi10.Text = "795";
            this.btn_sayi10.UseVisualStyleBackColor = true;
            // 
            // btn_sayi9
            // 
            this.btn_sayi9.Location = new System.Drawing.Point(126, 581);
            this.btn_sayi9.Name = "btn_sayi9";
            this.btn_sayi9.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi9.TabIndex = 120;
            this.btn_sayi9.Text = "781";
            this.btn_sayi9.UseVisualStyleBackColor = true;
            // 
            // btn_sayi8
            // 
            this.btn_sayi8.Location = new System.Drawing.Point(126, 512);
            this.btn_sayi8.Name = "btn_sayi8";
            this.btn_sayi8.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi8.TabIndex = 119;
            this.btn_sayi8.Text = "621";
            this.btn_sayi8.UseVisualStyleBackColor = true;
            // 
            // btn_sayi7
            // 
            this.btn_sayi7.Location = new System.Drawing.Point(126, 443);
            this.btn_sayi7.Name = "btn_sayi7";
            this.btn_sayi7.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi7.TabIndex = 118;
            this.btn_sayi7.Text = "560";
            this.btn_sayi7.UseVisualStyleBackColor = true;
            // 
            // btn_sayi6
            // 
            this.btn_sayi6.Location = new System.Drawing.Point(126, 374);
            this.btn_sayi6.Name = "btn_sayi6";
            this.btn_sayi6.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi6.TabIndex = 117;
            this.btn_sayi6.Text = "413";
            this.btn_sayi6.UseVisualStyleBackColor = true;
            // 
            // btn_sayi5
            // 
            this.btn_sayi5.Location = new System.Drawing.Point(126, 305);
            this.btn_sayi5.Name = "btn_sayi5";
            this.btn_sayi5.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi5.TabIndex = 116;
            this.btn_sayi5.Text = "378";
            this.btn_sayi5.UseVisualStyleBackColor = true;
            // 
            // btn_sayi4
            // 
            this.btn_sayi4.Location = new System.Drawing.Point(126, 236);
            this.btn_sayi4.Name = "btn_sayi4";
            this.btn_sayi4.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi4.TabIndex = 115;
            this.btn_sayi4.Text = "342";
            this.btn_sayi4.UseVisualStyleBackColor = true;
            // 
            // btn_sayi3
            // 
            this.btn_sayi3.Location = new System.Drawing.Point(126, 167);
            this.btn_sayi3.Name = "btn_sayi3";
            this.btn_sayi3.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi3.TabIndex = 114;
            this.btn_sayi3.Text = "117";
            this.btn_sayi3.UseVisualStyleBackColor = true;
            // 
            // btn_sayi2
            // 
            this.btn_sayi2.Location = new System.Drawing.Point(126, 98);
            this.btn_sayi2.Name = "btn_sayi2";
            this.btn_sayi2.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi2.TabIndex = 113;
            this.btn_sayi2.Text = "89";
            this.btn_sayi2.UseVisualStyleBackColor = true;
            // 
            // btn_sayi1
            // 
            this.btn_sayi1.Location = new System.Drawing.Point(126, 29);
            this.btn_sayi1.Name = "btn_sayi1";
            this.btn_sayi1.Size = new System.Drawing.Size(108, 44);
            this.btn_sayi1.TabIndex = 112;
            this.btn_sayi1.Text = "25";
            this.btn_sayi1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(385, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 60);
            this.button1.TabIndex = 127;
            this.button1.Text = "Tekrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(630, 737);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 52);
            this.label1.TabIndex = 128;
            this.label1.Text = "Cansu Ayten\r\n171180010\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 812);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.txt_sayi);
            this.Controls.Add(this.lbl_sayi);
            this.Controls.Add(this.btn_sayi11);
            this.Controls.Add(this.btn_sayi10);
            this.Controls.Add(this.btn_sayi9);
            this.Controls.Add(this.btn_sayi8);
            this.Controls.Add(this.btn_sayi7);
            this.Controls.Add(this.btn_sayi6);
            this.Controls.Add(this.btn_sayi5);
            this.Controls.Add(this.btn_sayi4);
            this.Controls.Add(this.btn_sayi3);
            this.Controls.Add(this.btn_sayi2);
            this.Controls.Add(this.btn_sayi1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ok;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.Label lbl_sayi;
        private System.Windows.Forms.Button btn_sayi11;
        private System.Windows.Forms.Button btn_sayi10;
        private System.Windows.Forms.Button btn_sayi9;
        private System.Windows.Forms.Button btn_sayi8;
        private System.Windows.Forms.Button btn_sayi7;
        private System.Windows.Forms.Button btn_sayi6;
        private System.Windows.Forms.Button btn_sayi5;
        private System.Windows.Forms.Button btn_sayi4;
        private System.Windows.Forms.Button btn_sayi3;
        private System.Windows.Forms.Button btn_sayi2;
        private System.Windows.Forms.Button btn_sayi1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

