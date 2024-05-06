
namespace Forms_Vzlom_Shifra_Cezarya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ishodnoe = new System.Windows.Forms.TextBox();
            this.Zashifrovannoe = new System.Windows.Forms.TextBox();
            this.Coding = new System.Windows.Forms.Button();
            this.Kluch = new System.Windows.Forms.TextBox();
            this.Decoding = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифрованныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифрованныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Ishodnoe
            // 
            this.Ishodnoe.BackColor = System.Drawing.Color.FloralWhite;
            this.Ishodnoe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ishodnoe.Location = new System.Drawing.Point(51, 71);
            this.Ishodnoe.Multiline = true;
            this.Ishodnoe.Name = "Ishodnoe";
            this.Ishodnoe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ishodnoe.Size = new System.Drawing.Size(366, 329);
            this.Ishodnoe.TabIndex = 0;
            // 
            // Zashifrovannoe
            // 
            this.Zashifrovannoe.BackColor = System.Drawing.Color.FloralWhite;
            this.Zashifrovannoe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Zashifrovannoe.Location = new System.Drawing.Point(524, 71);
            this.Zashifrovannoe.Multiline = true;
            this.Zashifrovannoe.Name = "Zashifrovannoe";
            this.Zashifrovannoe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Zashifrovannoe.Size = new System.Drawing.Size(366, 329);
            this.Zashifrovannoe.TabIndex = 1;
            // 
            // Coding
            // 
            this.Coding.BackColor = System.Drawing.Color.SeaShell;
            this.Coding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Coding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coding.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Coding.FlatAppearance.BorderSize = 2;
            this.Coding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coding.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Coding.Location = new System.Drawing.Point(158, 434);
            this.Coding.Name = "Coding";
            this.Coding.Size = new System.Drawing.Size(145, 36);
            this.Coding.TabIndex = 2;
            this.Coding.Text = "Зашифровать";
            this.Coding.UseVisualStyleBackColor = false;
            this.Coding.Click += new System.EventHandler(this.Coding_Click);
            // 
            // Kluch
            // 
            this.Kluch.Location = new System.Drawing.Point(419, 442);
            this.Kluch.MaxLength = 2;
            this.Kluch.Name = "Kluch";
            this.Kluch.Size = new System.Drawing.Size(100, 20);
            this.Kluch.TabIndex = 3;
            this.Kluch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kluch_KeyPress);
            // 
            // Decoding
            // 
            this.Decoding.BackColor = System.Drawing.Color.SeaShell;
            this.Decoding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decoding.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Decoding.FlatAppearance.BorderSize = 2;
            this.Decoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decoding.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Decoding.Location = new System.Drawing.Point(645, 434);
            this.Decoding.Name = "Decoding";
            this.Decoding.Size = new System.Drawing.Size(154, 36);
            this.Decoding.TabIndex = 4;
            this.Decoding.Text = "Расшифровать";
            this.Decoding.UseVisualStyleBackColor = false;
            this.Decoding.Click += new System.EventHandler(this.Decoding_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.взломToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйТекстToolStripMenuItem,
            this.зашифрованныйТекстToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // обычныйТекстToolStripMenuItem
            // 
            this.обычныйТекстToolStripMenuItem.Name = "обычныйТекстToolStripMenuItem";
            this.обычныйТекстToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.обычныйТекстToolStripMenuItem.Text = "Исходный текст";
            this.обычныйТекстToolStripMenuItem.Click += new System.EventHandler(this.ИсходныйТекстОткрыть_Click);
            // 
            // зашифрованныйТекстToolStripMenuItem
            // 
            this.зашифрованныйТекстToolStripMenuItem.Name = "зашифрованныйТекстToolStripMenuItem";
            this.зашифрованныйТекстToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.зашифрованныйТекстToolStripMenuItem.Text = "Зашифрованный текст";
            this.зашифрованныйТекстToolStripMenuItem.Click += new System.EventHandler(this.ЗашифрованныйТекстОткрыть_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходныйТекстToolStripMenuItem,
            this.зашифрованныйToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // исходныйТекстToolStripMenuItem
            // 
            this.исходныйТекстToolStripMenuItem.Name = "исходныйТекстToolStripMenuItem";
            this.исходныйТекстToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.исходныйТекстToolStripMenuItem.Text = "Исходный текст";
            this.исходныйТекстToolStripMenuItem.Click += new System.EventHandler(this.ИсходныйТекстСохранить_Click);
            // 
            // зашифрованныйToolStripMenuItem
            // 
            this.зашифрованныйToolStripMenuItem.Name = "зашифрованныйToolStripMenuItem";
            this.зашифрованныйToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.зашифрованныйToolStripMenuItem.Text = "Зашифрованный текст";
            this.зашифрованныйToolStripMenuItem.Click += new System.EventHandler(this.ЗашифрованныйТекстСохранить_Click);
            // 
            // взломToolStripMenuItem
            // 
            this.взломToolStripMenuItem.Name = "взломToolStripMenuItem";
            this.взломToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.взломToolStripMenuItem.Text = "Взлом";
            this.взломToolStripMenuItem.Click += new System.EventHandler(this.взломToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(435, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ключ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-262, -105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 739);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(592, -119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 790);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(165, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(544, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Зашифрованный текст";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(395, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(947, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Decoding);
            this.Controls.Add(this.Kluch);
            this.Controls.Add(this.Coding);
            this.Controls.Add(this.Zashifrovannoe);
            this.Controls.Add(this.Ishodnoe);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифратор Цезаря";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ishodnoe;
        private System.Windows.Forms.TextBox Zashifrovannoe;
        private System.Windows.Forms.Button Coding;
        private System.Windows.Forms.TextBox Kluch;
        private System.Windows.Forms.Button Decoding;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифрованныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифрованныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйТекстToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem взломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

