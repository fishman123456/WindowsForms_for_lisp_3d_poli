using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_for_lisp_3d_poli
{
    public partial class Form1 : Form
    {
        public string name_kab = " ";
        public string sbor = " ";
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.lsp)|*.lsp|All files(*.*)|*.*";

        }

        private void clear_beg_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void clear_centr_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void clear_end_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void save_f_Click(object sender, EventArgs e)
        {

            sbor += "; ; файл разработан Фишмном Денисом в рамках проекта WF  12-02-2023 \n";
            sbor += "(defun  C:PL100 (/ x1 x2 x3)\n";
            sbor += "(vl-load-com)\n";
            sbor += " (command \"_.-layer\" \"_m\" \"";
            name_kab = textBox4.Text.ToString();
            sbor += name_kab;
            sbor += " \" \"\")\n ";
            //sbor += "(command \"_.3Dpoly '(";
            //sbor += "0 100 100";
            //sbor += ")";
            //sbor += " \"\")\n";
            sbor += ")";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename,sbor);
            MessageBox.Show("Файл сохранен");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void rez_1_Click(object sender, EventArgs e)
        {
           
        }

        private void rez_2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void fonts_options_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            textBox1.Font = fontDialog1.Font;
            textBox2.Font = fontDialog1.Font;
            textBox3.Font = fontDialog1.Font;
            textBox4.Font = fontDialog1.Font;
            // установка цвета шрифта
            textBox1.ForeColor = fontDialog1.Color;
            textBox2.ForeColor = fontDialog1.Color;
            textBox3.ForeColor = fontDialog1.Color;
            textBox4.ForeColor = fontDialog1.Color;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
