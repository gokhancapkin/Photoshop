namespace YazLabForm
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
            this.btnGriYap = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Aynala2 = new System.Windows.Forms.Button();
            this.negatifBtn = new System.Windows.Forms.Button();
            this.maviYap = new System.Windows.Forms.Button();
            this.yesilYap = new System.Windows.Forms.Button();
            this.kirmiziYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ileriBtn = new System.Windows.Forms.Button();
            this.geriBtn = new System.Windows.Forms.Button();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.solDondurBtn = new System.Windows.Forms.Button();
            this.sagDondurBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.redch = new System.Windows.Forms.CheckBox();
            this.bluech = new System.Windows.Forms.CheckBox();
            this.greench = new System.Windows.Forms.CheckBox();
            this.grich = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.olcekUygula = new System.Windows.Forms.Button();
            this.btnRkanal = new System.Windows.Forms.Button();
            this.btnBkanal = new System.Windows.Forms.Button();
            this.btnGkanal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGriYap
            // 
            this.btnGriYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGriYap.Location = new System.Drawing.Point(25, 192);
            this.btnGriYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGriYap.Name = "btnGriYap";
            this.btnGriYap.Size = new System.Drawing.Size(150, 28);
            this.btnGriYap.TabIndex = 2;
            this.btnGriYap.Text = "Gri Skala";
            this.btnGriYap.UseVisualStyleBackColor = true;
            this.btnGriYap.Click += new System.EventHandler(this.btnGriYap_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(25, 228);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Yatay Aynala";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAynala_Click);
            // 
            // Aynala2
            // 
            this.Aynala2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Aynala2.Location = new System.Drawing.Point(25, 264);
            this.Aynala2.Margin = new System.Windows.Forms.Padding(4);
            this.Aynala2.Name = "Aynala2";
            this.Aynala2.Size = new System.Drawing.Size(150, 28);
            this.Aynala2.TabIndex = 4;
            this.Aynala2.Text = "Dikey Aynala";
            this.Aynala2.UseVisualStyleBackColor = true;
            this.Aynala2.Click += new System.EventHandler(this.Aynala2_Click);
            // 
            // negatifBtn
            // 
            this.negatifBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.negatifBtn.Location = new System.Drawing.Point(25, 300);
            this.negatifBtn.Margin = new System.Windows.Forms.Padding(4);
            this.negatifBtn.Name = "negatifBtn";
            this.negatifBtn.Size = new System.Drawing.Size(150, 28);
            this.negatifBtn.TabIndex = 5;
            this.negatifBtn.Text = "Negatif";
            this.negatifBtn.UseVisualStyleBackColor = true;
            this.negatifBtn.Click += new System.EventHandler(this.negatifBtn_Click);
            // 
            // maviYap
            // 
            this.maviYap.BackColor = System.Drawing.Color.Gainsboro;
            this.maviYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maviYap.ForeColor = System.Drawing.Color.Blue;
            this.maviYap.Location = new System.Drawing.Point(777, 43);
            this.maviYap.Margin = new System.Windows.Forms.Padding(4);
            this.maviYap.Name = "maviYap";
            this.maviYap.Size = new System.Drawing.Size(145, 31);
            this.maviYap.TabIndex = 11;
            this.maviYap.Text = "Mavi Filtre";
            this.maviYap.UseVisualStyleBackColor = false;
            this.maviYap.Click += new System.EventHandler(this.maviYap_Click);
            // 
            // yesilYap
            // 
            this.yesilYap.BackColor = System.Drawing.Color.Gainsboro;
            this.yesilYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yesilYap.ForeColor = System.Drawing.Color.Green;
            this.yesilYap.Location = new System.Drawing.Point(624, 43);
            this.yesilYap.Margin = new System.Windows.Forms.Padding(4);
            this.yesilYap.Name = "yesilYap";
            this.yesilYap.Size = new System.Drawing.Size(145, 31);
            this.yesilYap.TabIndex = 12;
            this.yesilYap.Text = "Yeşil Filtre";
            this.yesilYap.UseVisualStyleBackColor = false;
            this.yesilYap.Click += new System.EventHandler(this.yesilYap_Click);
            // 
            // kirmiziYap
            // 
            this.kirmiziYap.BackColor = System.Drawing.Color.Gainsboro;
            this.kirmiziYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kirmiziYap.ForeColor = System.Drawing.Color.Red;
            this.kirmiziYap.Location = new System.Drawing.Point(471, 43);
            this.kirmiziYap.Margin = new System.Windows.Forms.Padding(4);
            this.kirmiziYap.Name = "kirmiziYap";
            this.kirmiziYap.Size = new System.Drawing.Size(145, 31);
            this.kirmiziYap.TabIndex = 13;
            this.kirmiziYap.Text = "Kırmızı Filtre";
            this.kirmiziYap.UseVisualStyleBackColor = false;
            this.kirmiziYap.Click += new System.EventHandler(this.kirmiziYap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(1057, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 350);
            this.panel1.TabIndex = 16;
            // 
            // ileriBtn
            // 
            this.ileriBtn.Image = global::Proje.Properties.Resources.ileri_icon__Copy_;
            this.ileriBtn.Location = new System.Drawing.Point(232, 1);
            this.ileriBtn.Name = "ileriBtn";
            this.ileriBtn.Size = new System.Drawing.Size(70, 70);
            this.ileriBtn.TabIndex = 21;
            this.ileriBtn.UseVisualStyleBackColor = true;
            this.ileriBtn.Click += new System.EventHandler(this.ileriBtn_Click);
            // 
            // geriBtn
            // 
            this.geriBtn.Image = global::Proje.Properties.Resources.geri_icon1;
            this.geriBtn.Location = new System.Drawing.Point(156, 1);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(70, 70);
            this.geriBtn.TabIndex = 20;
            this.geriBtn.UseVisualStyleBackColor = true;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Image = global::Proje.Properties.Resources.resim_ekle_icon2__Copy_;
            this.btnResimYukle.Location = new System.Drawing.Point(4, 1);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(70, 70);
            this.btnResimYukle.TabIndex = 19;
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::Proje.Properties.Resources.Floppy_Drive_3_5__Copy_;
            this.btnKaydet.Location = new System.Drawing.Point(80, 1);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(70, 70);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // solDondurBtn
            // 
            this.solDondurBtn.Image = global::Proje.Properties.Resources.soladonduricon__Copy_;
            this.solDondurBtn.Location = new System.Drawing.Point(46, 102);
            this.solDondurBtn.Margin = new System.Windows.Forms.Padding(4);
            this.solDondurBtn.Name = "solDondurBtn";
            this.solDondurBtn.Size = new System.Drawing.Size(50, 50);
            this.solDondurBtn.TabIndex = 8;
            this.solDondurBtn.UseVisualStyleBackColor = true;
            this.solDondurBtn.Click += new System.EventHandler(this.solDondurBtn_Click);
            // 
            // sagDondurBtn
            // 
            this.sagDondurBtn.Image = global::Proje.Properties.Resources.sagadonduricon1__Copy_;
            this.sagDondurBtn.Location = new System.Drawing.Point(104, 102);
            this.sagDondurBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sagDondurBtn.Name = "sagDondurBtn";
            this.sagDondurBtn.Size = new System.Drawing.Size(50, 50);
            this.sagDondurBtn.TabIndex = 6;
            this.sagDondurBtn.UseVisualStyleBackColor = true;
            this.sagDondurBtn.Click += new System.EventHandler(this.sagDondurBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(233, 83);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(799, 511);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // redch
            // 
            this.redch.AutoSize = true;
            this.redch.BackColor = System.Drawing.Color.Gainsboro;
            this.redch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.redch.ForeColor = System.Drawing.Color.Red;
            this.redch.Location = new System.Drawing.Point(1057, 382);
            this.redch.Name = "redch";
            this.redch.Size = new System.Drawing.Size(77, 30);
            this.redch.TabIndex = 23;
            this.redch.Text = "Red";
            this.redch.UseVisualStyleBackColor = false;
            // 
            // bluech
            // 
            this.bluech.AutoSize = true;
            this.bluech.BackColor = System.Drawing.Color.Gainsboro;
            this.bluech.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bluech.ForeColor = System.Drawing.Color.Green;
            this.bluech.Location = new System.Drawing.Point(1140, 382);
            this.bluech.Name = "bluech";
            this.bluech.Size = new System.Drawing.Size(99, 30);
            this.bluech.TabIndex = 24;
            this.bluech.Text = "Green";
            this.bluech.UseVisualStyleBackColor = false;
            // 
            // greench
            // 
            this.greench.AutoSize = true;
            this.greench.BackColor = System.Drawing.Color.Gainsboro;
            this.greench.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.greench.ForeColor = System.Drawing.Color.Blue;
            this.greench.Location = new System.Drawing.Point(1245, 382);
            this.greench.Name = "greench";
            this.greench.Size = new System.Drawing.Size(82, 30);
            this.greench.TabIndex = 25;
            this.greench.Text = "Blue";
            this.greench.UseVisualStyleBackColor = false;
            // 
            // grich
            // 
            this.grich.AutoSize = true;
            this.grich.BackColor = System.Drawing.Color.Gainsboro;
            this.grich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grich.ForeColor = System.Drawing.Color.DimGray;
            this.grich.Location = new System.Drawing.Point(1333, 382);
            this.grich.Name = "grich";
            this.grich.Size = new System.Drawing.Size(85, 30);
            this.grich.TabIndex = 26;
            this.grich.Text = "Gray";
            this.grich.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1054, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Histogram";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearBtn.Location = new System.Drawing.Point(25, 335);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(150, 28);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "Orijinal";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(418, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(418, 649);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Y:";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWidth.Location = new System.Drawing.Point(451, 614);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(98, 26);
            this.txtWidth.TabIndex = 37;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHeight.Location = new System.Drawing.Point(451, 646);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(98, 26);
            this.txtHeight.TabIndex = 38;
            // 
            // olcekUygula
            // 
            this.olcekUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olcekUygula.Location = new System.Drawing.Point(451, 684);
            this.olcekUygula.Name = "olcekUygula";
            this.olcekUygula.Size = new System.Drawing.Size(98, 28);
            this.olcekUygula.TabIndex = 39;
            this.olcekUygula.Text = "Ölçekle";
            this.olcekUygula.UseVisualStyleBackColor = true;
            this.olcekUygula.Click += new System.EventHandler(this.olcekUygula_Click);
            // 
            // btnRkanal
            // 
            this.btnRkanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRkanal.Location = new System.Drawing.Point(25, 370);
            this.btnRkanal.Name = "btnRkanal";
            this.btnRkanal.Size = new System.Drawing.Size(150, 28);
            this.btnRkanal.TabIndex = 40;
            this.btnRkanal.Text = "Red Kanal";
            this.btnRkanal.UseVisualStyleBackColor = true;
            this.btnRkanal.Click += new System.EventHandler(this.btnRkanal_Click);
            // 
            // btnBkanal
            // 
            this.btnBkanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBkanal.Location = new System.Drawing.Point(25, 400);
            this.btnBkanal.Name = "btnBkanal";
            this.btnBkanal.Size = new System.Drawing.Size(150, 28);
            this.btnBkanal.TabIndex = 41;
            this.btnBkanal.Text = "Blue Kanal";
            this.btnBkanal.UseVisualStyleBackColor = true;
            this.btnBkanal.Click += new System.EventHandler(this.btnBkanal_Click);
            // 
            // btnGkanal
            // 
            this.btnGkanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGkanal.Location = new System.Drawing.Point(25, 430);
            this.btnGkanal.Name = "btnGkanal";
            this.btnGkanal.Size = new System.Drawing.Size(150, 28);
            this.btnGkanal.TabIndex = 42;
            this.btnGkanal.Text = "Green Kanal";
            this.btnGkanal.UseVisualStyleBackColor = true;
            this.btnGkanal.Click += new System.EventHandler(this.btnGkanal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1743, 726);
            this.Controls.Add(this.btnGkanal);
            this.Controls.Add(this.btnBkanal);
            this.Controls.Add(this.btnRkanal);
            this.Controls.Add(this.olcekUygula);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grich);
            this.Controls.Add(this.greench);
            this.Controls.Add(this.bluech);
            this.Controls.Add(this.redch);
            this.Controls.Add(this.ileriBtn);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kirmiziYap);
            this.Controls.Add(this.yesilYap);
            this.Controls.Add(this.maviYap);
            this.Controls.Add(this.solDondurBtn);
            this.Controls.Add(this.sagDondurBtn);
            this.Controls.Add(this.negatifBtn);
            this.Controls.Add(this.Aynala2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGriYap);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGriYap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Aynala2;
        private System.Windows.Forms.Button negatifBtn;
        private System.Windows.Forms.Button sagDondurBtn;
        private System.Windows.Forms.Button solDondurBtn;
        private System.Windows.Forms.Button maviYap;
        private System.Windows.Forms.Button yesilYap;
        private System.Windows.Forms.Button kirmiziYap;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Button ileriBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox redch;
        private System.Windows.Forms.CheckBox bluech;
        private System.Windows.Forms.CheckBox greench;
        private System.Windows.Forms.CheckBox grich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button olcekUygula;
        private System.Windows.Forms.Button btnRkanal;
        private System.Windows.Forms.Button btnBkanal;
        private System.Windows.Forms.Button btnGkanal;
    }
}

