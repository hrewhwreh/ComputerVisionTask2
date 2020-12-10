
namespace ComputerVision2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maxPoolingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сверткаToolStripMenuItem,
            this.maxPoolingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1633, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сверткаToolStripMenuItem
            // 
            this.сверткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьToolStripMenuItem1});
            this.сверткаToolStripMenuItem.Name = "сверткаToolStripMenuItem";
            this.сверткаToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.сверткаToolStripMenuItem.Text = "Свертка + Relu";
            // 
            // сделатьToolStripMenuItem1
            // 
            this.сделатьToolStripMenuItem1.Name = "сделатьToolStripMenuItem1";
            this.сделатьToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.сделатьToolStripMenuItem1.Text = "Сделать";
            this.сделатьToolStripMenuItem1.Click += new System.EventHandler(this.сделатьToolStripMenuItem1_Click);
            // 
            // maxPoolingToolStripMenuItem
            // 
            this.maxPoolingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьToolStripMenuItem2});
            this.maxPoolingToolStripMenuItem.Name = "maxPoolingToolStripMenuItem";
            this.maxPoolingToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.maxPoolingToolStripMenuItem.Text = "MaxPooling";
            // 
            // сделатьToolStripMenuItem2
            // 
            this.сделатьToolStripMenuItem2.Name = "сделатьToolStripMenuItem2";
            this.сделатьToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.сделатьToolStripMenuItem2.Text = "Сделать";
            this.сделатьToolStripMenuItem2.Click += new System.EventHandler(this.сделатьToolStripMenuItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(538, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(519, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1063, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(519, 270);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(519, 270);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(538, 304);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(519, 270);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(1063, 304);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(519, 270);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картинка2ToolStripMenuItem,
            this.картинка3ToolStripMenuItem,
            this.картинка4ToolStripMenuItem,
            this.картинка5ToolStripMenuItem,
            this.картинка6ToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // картинка2ToolStripMenuItem
            // 
            this.картинка2ToolStripMenuItem.Name = "картинка2ToolStripMenuItem";
            this.картинка2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка2ToolStripMenuItem.Text = "Картинка2";
            this.картинка2ToolStripMenuItem.Click += new System.EventHandler(this.картинка2ToolStripMenuItem_Click);
            // 
            // картинка3ToolStripMenuItem
            // 
            this.картинка3ToolStripMenuItem.Name = "картинка3ToolStripMenuItem";
            this.картинка3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка3ToolStripMenuItem.Text = "Картинка3";
            this.картинка3ToolStripMenuItem.Click += new System.EventHandler(this.картинка3ToolStripMenuItem_Click);
            // 
            // картинка4ToolStripMenuItem
            // 
            this.картинка4ToolStripMenuItem.Name = "картинка4ToolStripMenuItem";
            this.картинка4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка4ToolStripMenuItem.Text = "Картинка4";
            this.картинка4ToolStripMenuItem.Click += new System.EventHandler(this.картинка4ToolStripMenuItem_Click);
            // 
            // картинка5ToolStripMenuItem
            // 
            this.картинка5ToolStripMenuItem.Name = "картинка5ToolStripMenuItem";
            this.картинка5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка5ToolStripMenuItem.Text = "Картинка5";
            this.картинка5ToolStripMenuItem.Click += new System.EventHandler(this.картинка5ToolStripMenuItem_Click);
            // 
            // картинка6ToolStripMenuItem
            // 
            this.картинка6ToolStripMenuItem.Name = "картинка6ToolStripMenuItem";
            this.картинка6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка6ToolStripMenuItem.Text = "Картинка6";
            this.картинка6ToolStripMenuItem.Click += new System.EventHandler(this.картинка6ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 647);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripMenuItem сверткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maxPoolingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка6ToolStripMenuItem;
    }
}

