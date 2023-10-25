using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

using ToolTip = System.Windows.Forms.ToolTip;

namespace WindowsForms_for_lisp_3d_poli
{
    public partial class Form1 : Form
    {
        public string name_kab;
        public string sbor = " ";
        //список имя кабеля
        public List<string> str_box_name = new List<string>();
        //список начало кабеля
        public List<string> begin = new List<string>();
        //список середина кабеля
        public List<string> centr = new List<string>();
        //список конец кабеля
        public List<string> end = new List<string>();
        // непонятно что это!!!!!!!!!!!
        private IEnumerable<object> etr_box_name;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.lsp)|*.lsp|All files(*.*)|*.*";
            // описание подсказок
            ToolTip t_one = new ToolTip();
            t_one.SetToolTip(textBox2, "Начало кабельной линии (X Y Z) много точек можно");
            ToolTip t_two = new ToolTip();
            t_two.SetToolTip(textBox3, "Промежуточные точки кабельной линии (X Y Z) много точек можно");
            ToolTip t_three = new ToolTip();
            t_three.SetToolTip(textBox4, "Конец кабельной линии (X Y Z) много точек можно");
            ToolTip t_four = new ToolTip();
            t_four.SetToolTip(textBox1, "Имя кабельной линии (X Y Z) много имен можно");

        }

        private void clear_beg_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void clear_centr_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void clear_end_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void save_f_Click(object sender, EventArgs e)
        {
            // заполняем список текстбоксом 1, имя кабеля
            CheckDate();
            str_box_name.Append(textBox1.TextLength.ToString());
            if (!string.IsNullOrEmpty(Convert.ToString(textBox1.Text)))
            {
                str_box_name = new List<string>();
                string IdOrder = Convert.ToString(textBox1.Text.Trim());
                string temp = IdOrder.Replace("\r\n", " ");
                string[] text_name = Regex.Split(temp, " ");
                for (int i = 0; i < text_name.Length; i++)
                {
                    str_box_name.Add(text_name[i]);
                }
            }
            // заполняем список текстбоксом 2, начало кабеля
            begin.Append(textBox2.TextLength.ToString());
            if (!string.IsNullOrEmpty(Convert.ToString(textBox2.Text)))
            {
                begin = new List<string>();
                string IdOrder = Convert.ToString(textBox1.Text.Trim());
                string temp = IdOrder.Replace("\r\n", " ");
                string[] begin_coor = Regex.Split(temp, " ");
                for (int i = 0; i < begin_coor.Length; i++)
                {
                    begin.Add(begin_coor[i]);
                }
            }

            // заполняем список текстбоксом 3, координаты середины
            centr.Append(textBox3.TextLength.ToString());
            if (!string.IsNullOrEmpty(Convert.ToString(textBox3.Text)))
            {
                centr = new List<string>();
                string IdOrder = Convert.ToString(textBox3.Text.Trim());
                string temp = IdOrder.Replace("\r", "");
                string[] centr_coor = temp.Split('\n');
                for (int i = 0; i < centr_coor.Length; i++)
                {
                    centr.Add(centr_coor[i]);
                }
            }
            // заполняем список текстбоксом 4 , координаты конца кабеля
            end.Append(textBox4.TextLength.ToString());
            if (!string.IsNullOrEmpty(Convert.ToString(textBox3.Text)))
            {
                end = new List<string>();
                string IdOrder = Convert.ToString(textBox4.Text.Trim());
                string temp = IdOrder.Replace("\r", "");
                string[] end_coor = temp.Split('\n');
                for (int i = 0; i < end_coor.Length; i++)
                {
                    end.Add(end_coor[i]);
                }
            }


            sbor = "";
            sbor += "; ; автор Фишман Денис в рамках проекта WF  12-02-2023 \n";
            sbor += "(defun  C:PL100 (/ x1 x2 x3)\n";
            sbor += "(vl-load-com)\n";
            int name_c = 0;
            int begin_c = 0;
            int centr_c = 0;
            int end_c = 0;
            try
            {

                if (textBox1.Text.Length > 0)
                {
                    foreach (string s in str_box_name)
                    {

                        sbor += " (command \"_.-layer\" \"_m\" \"";
                        //имя кабеля берем из текстбокса 1
                        // name_kab = textBox1.Text.ToString();
                        sbor += s;
                        sbor += "\" \"\")\n";
                        // дополняем координатами начало, конец. Середину потом запихнем 14-02-2023

                        // середину запихали осталось чуть..... 17-03-2023

                        sbor += "(command \"_.3Dpoly\" '(";
                        sbor += textBox2.Lines[begin_c].ToString(); // место для начала кабеля переменная стринг
                                                                    // одно начало  29-08-2023
                                                                    // много начала 30-08-2023
                        sbor += ")";
                        begin_c++;
                        // здесь нужно середину вставить
                        // много точек в середине 21-09-2023 думаю
                        if (textBox3.Text.Length > 0)
                        {
                            string[] lines = textBox3.Text.Split('\n');
                            foreach (string line in lines)
                            {
                                {
                                    sbor += "'(";
                                    sbor += textBox3.Lines[centr_c].ToString(); // место для промежуточных вершин кабеля переменная стринг
                                    sbor += ")";
                                    centr_c++;
                                }
                            }
                            centr_c = 0;
                        }
                            // конец добавляем
                            sbor += "'(";
                            sbor += textBox4.Lines[end_c].ToString(); // место для конечных вершин кабеля переменная стринг
                            sbor += ")";
                            end_c++;

                            sbor += " \"\")\n";
                            //name_c++;
                        }
                    }
                    sbor += ")";
                // закрываем скобку, обнуляем координаты begin_c, centr_c, end_c, можно занова начинать
                begin_c = 0; centr_c = 0; end_c = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, sbor);
            MessageBox.Show("Файл сохранен");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
        }

        private void rez_1_Click(object sender, EventArgs e)
        {

        }

        private void rez_2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void fonts_options_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            textBox2.Font = fontDialog1.Font;
            textBox3.Font = fontDialog1.Font;
            textBox4.Font = fontDialog1.Font;
            textBox1.Font = fontDialog1.Font;
            // установка цвета шрифта
            textBox2.ForeColor = fontDialog1.Color;
            textBox3.ForeColor = fontDialog1.Color;
            textBox4.ForeColor = fontDialog1.Color;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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

        private void mouse_click(object sender, MouseEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #region
        // проверка по дате использования
        public static void CheckDate()
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse("01/01/2024");


            if (dt1.Date > dt2.Date)
            {
                MessageBox.Show("Срок истек...");
                // Выход из проложения добавил 12-07-2023. Чтобы порядок был....
                Application.Exit();
                //w1.Close();
            }
            else
            {

                MessageBox.Show("Работайте до   " + dt2.ToString());
            }

        }
        #endregion
    }
}
