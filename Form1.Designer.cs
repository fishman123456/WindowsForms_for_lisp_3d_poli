namespace WindowsForms_for_lisp_3d_poli
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rez_1 = new System.Windows.Forms.Button();
            this.rez_2 = new System.Windows.Forms.Button();
            this.save_f = new System.Windows.Forms.Button();
            this.clear_beg = new System.Windows.Forms.Button();
            this.clear_centr = new System.Windows.Forms.Button();
            this.clear_end = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.fonts_options = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(240, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(220, 200);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(470, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(220, 200);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mouse_click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(700, 66);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(220, 200);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // rez_1
            // 
            this.rez_1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rez_1.Location = new System.Drawing.Point(240, 19);
            this.rez_1.Name = "rez_1";
            this.rez_1.Size = new System.Drawing.Size(220, 20);
            this.rez_1.TabIndex = 3;
            this.rez_1.Text = "имя кабеля заполнить список";
            this.rez_1.UseVisualStyleBackColor = false;
            this.rez_1.Click += new System.EventHandler(this.rez_1_Click);
            // 
            // rez_2
            // 
            this.rez_2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rez_2.Location = new System.Drawing.Point(470, 19);
            this.rez_2.Name = "rez_2";
            this.rez_2.Size = new System.Drawing.Size(220, 20);
            this.rez_2.TabIndex = 4;
            this.rez_2.Text = "резерв";
            this.rez_2.UseVisualStyleBackColor = false;
            this.rez_2.Click += new System.EventHandler(this.rez_2_Click);
            // 
            // save_f
            // 
            this.save_f.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.save_f.Location = new System.Drawing.Point(701, 19);
            this.save_f.Name = "save_f";
            this.save_f.Size = new System.Drawing.Size(220, 20);
            this.save_f.TabIndex = 5;
            this.save_f.Text = "сохранить в другой файл";
            this.save_f.UseVisualStyleBackColor = false;
            this.save_f.Click += new System.EventHandler(this.save_f_Click);
            // 
            // clear_beg
            // 
            this.clear_beg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clear_beg.Location = new System.Drawing.Point(240, 288);
            this.clear_beg.Name = "clear_beg";
            this.clear_beg.Size = new System.Drawing.Size(220, 20);
            this.clear_beg.TabIndex = 6;
            this.clear_beg.Text = "очистить начало";
            this.clear_beg.UseVisualStyleBackColor = false;
            this.clear_beg.Click += new System.EventHandler(this.clear_beg_Click);
            // 
            // clear_centr
            // 
            this.clear_centr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clear_centr.Location = new System.Drawing.Point(470, 288);
            this.clear_centr.Name = "clear_centr";
            this.clear_centr.Size = new System.Drawing.Size(220, 20);
            this.clear_centr.TabIndex = 7;
            this.clear_centr.Text = "очистьть промежуточные";
            this.clear_centr.UseVisualStyleBackColor = false;
            this.clear_centr.Click += new System.EventHandler(this.clear_centr_Click);
            // 
            // clear_end
            // 
            this.clear_end.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clear_end.Location = new System.Drawing.Point(700, 288);
            this.clear_end.Name = "clear_end";
            this.clear_end.Size = new System.Drawing.Size(220, 20);
            this.clear_end.TabIndex = 8;
            this.clear_end.Text = "очистить конец";
            this.clear_end.UseVisualStyleBackColor = false;
            this.clear_end.Click += new System.EventHandler(this.clear_end_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "координаты начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "координаты середины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "координаты конец";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(911, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "очистить все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "имя кабеля";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(10, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 20);
            this.button2.TabIndex = 15;
            this.button2.Text = "очистить имя кабеля";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fonts_options
            // 
            this.fonts_options.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fonts_options.Location = new System.Drawing.Point(15, 19);
            this.fonts_options.Name = "fonts_options";
            this.fonts_options.Size = new System.Drawing.Size(220, 20);
            this.fonts_options.TabIndex = 14;
            this.fonts_options.Text = "настройна шрифт";
            this.fonts_options.UseVisualStyleBackColor = false;
            this.fonts_options.Click += new System.EventHandler(this.fonts_options_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(10, 66);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(220, 200);
            this.textBox4.TabIndex = 13;
            this.textBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(356, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Сохранять в другом файле!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fonts_options);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_end);
            this.Controls.Add(this.clear_centr);
            this.Controls.Add(this.clear_beg);
            this.Controls.Add(this.save_f);
            this.Controls.Add(this.rez_2);
            this.Controls.Add(this.rez_1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 400);
            this.Name = "Form1";
            this.Text = "U83_F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button rez_1;
        private System.Windows.Forms.Button rez_2;
        private System.Windows.Forms.Button save_f;
        private System.Windows.Forms.Button clear_beg;
        private System.Windows.Forms.Button clear_centr;
        private System.Windows.Forms.Button clear_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button fonts_options;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
    }
}

