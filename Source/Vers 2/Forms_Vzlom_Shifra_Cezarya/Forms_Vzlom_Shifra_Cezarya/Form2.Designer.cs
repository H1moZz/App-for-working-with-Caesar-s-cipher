
namespace Forms_Vzlom_Shifra_Cezarya
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Shifr = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.Hack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифрованныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифрованныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.взломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Shifr
            // 
            this.Shifr.BackColor = System.Drawing.Color.FloralWhite;
            this.Shifr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shifr.Location = new System.Drawing.Point(51, 82);
            this.Shifr.Multiline = true;
            this.Shifr.Name = "Shifr";
            this.Shifr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Shifr.Size = new System.Drawing.Size(366, 329);
            this.Shifr.TabIndex = 1;
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.FloralWhite;
            this.Results.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.Location = new System.Drawing.Point(524, 82);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Results.Size = new System.Drawing.Size(366, 329);
            this.Results.TabIndex = 2;
            // 
            // Hack
            // 
            this.Hack.BackColor = System.Drawing.Color.SeaShell;
            this.Hack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hack.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.Hack.FlatAppearance.BorderSize = 2;
            this.Hack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hack.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.Hack.Location = new System.Drawing.Point(399, 439);
            this.Hack.Name = "Hack";
            this.Hack.Size = new System.Drawing.Size(138, 36);
            this.Hack.TabIndex = 3;
            this.Hack.Text = "Взломать";
            this.Hack.UseVisualStyleBackColor = false;
            this.Hack.Click += new System.EventHandler(this.Hack_Click);
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
            this.menuStrip1.TabIndex = 6;
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
            this.зашифрованныйТекстToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
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
            this.исходныйТекстToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.исходныйТекстToolStripMenuItem.Text = "Расшифрованный текст";
            this.исходныйТекстToolStripMenuItem.Click += new System.EventHandler(this.ИсходныйТекстСохранить_Click);
            // 
            // зашифрованныйToolStripMenuItem
            // 
            this.зашифрованныйToolStripMenuItem.Name = "зашифрованныйToolStripMenuItem";
            this.зашифрованныйToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.зашифрованныйToolStripMenuItem.Text = "Зашифрованный текст";
            this.зашифрованныйToolStripMenuItem.Click += new System.EventHandler(this.ЗашифрованныйТекстСохранить_Click);
            // 
            // взломToolStripMenuItem
            // 
            this.взломToolStripMenuItem.Name = "взломToolStripMenuItem";
            this.взломToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.взломToolStripMenuItem.Text = "Вернуться на главную";
            this.взломToolStripMenuItem.Click += new System.EventHandler(this.ВернутьсяНаГлавную_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-272, -104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 739);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(592, -115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(612, 785);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(151, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Текст для взлома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(586, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Результат взлома";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(394, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(947, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Hack);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Shifr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Взлом Ширфа Цезаря";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Shifr;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Button Hack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифрованныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифрованныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem взломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}