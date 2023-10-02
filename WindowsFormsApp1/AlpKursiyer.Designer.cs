namespace WindowsFormsApp1
{
    partial class AlpKursiyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlpKursiyer));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnWhat = new System.Windows.Forms.Button();
            this.rchMesaj = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rchBulunamadi = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bilgileri kutulara CTRL+V ile yapıştırınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TELEFON";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(21, 22);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(227, 300);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // btnWhat
            // 
            this.btnWhat.Location = new System.Drawing.Point(496, 74);
            this.btnWhat.Name = "btnWhat";
            this.btnWhat.Size = new System.Drawing.Size(236, 84);
            this.btnWhat.TabIndex = 6;
            this.btnWhat.Text = "Otomatik Başla";
            this.btnWhat.UseVisualStyleBackColor = true;
            this.btnWhat.Click += new System.EventHandler(this.btnWhat_Click);
            // 
            // rchMesaj
            // 
            this.rchMesaj.Location = new System.Drawing.Point(254, 22);
            this.rchMesaj.Name = "rchMesaj";
            this.rchMesaj.Size = new System.Drawing.Size(236, 152);
            this.rchMesaj.TabIndex = 14;
            this.rchMesaj.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Excel Şablonundan Telefon Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mesaj Metni";
            // 
            // rchBulunamadi
            // 
            this.rchBulunamadi.Location = new System.Drawing.Point(254, 230);
            this.rchBulunamadi.Name = "rchBulunamadi";
            this.rchBulunamadi.Size = new System.Drawing.Size(227, 197);
            this.rchBulunamadi.TabIndex = 12;
            this.rchBulunamadi.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gönderilemeyen numaralar";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "Web Tarayıcısını aç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(514, 261);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(192, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gönderim Süresi";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(548, 309);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(110, 13);
            this.lblSure.TabIndex = 13;
            this.lblSure.Text = "Gönderim Süresi 12sn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sablon olarak kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Sablonu Aç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(583, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(496, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 22;
            // 
            // AlpKursiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 432);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchMesaj);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rchBulunamadi);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.btnWhat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlpKursiyer";
            this.Text = "AlpW";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnWhat;
        private System.Windows.Forms.RichTextBox rchMesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchBulunamadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

