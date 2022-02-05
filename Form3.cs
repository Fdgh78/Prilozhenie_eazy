using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
 
        public Form3()

        {
    
            InitializeComponent();
        this.Text += " " + Properties.Settings.Default.Version; //Добавляем в название программы, версию.
        Properties.Settings.Default.Sum_otcr++; //++; //Добавляем +1 к кол-ву запусков программы.(Счетчик заходов в прогу)
        label1.Text = Properties.Settings.Default.Sum_otcr.ToString(); //выводим в Label2 кол-во запусков программы.(Счетчик заходов в прогу)
            label3.Text = Properties.Settings.Default.Version;  //МОЯ ПРОГА

            //richTextBox1.Text = Properties.Settings.Default.Save_text1; // Загружаем ранее сохраненный текст
            richTextBox1.Text = Properties.Settings.Default.Param1; // Загружаем ранее сохраненный текст
            richTextBox2.Text = Properties.Settings.Default.Param2; // Загружаем ранее сохраненный текст
            richTextBox3.Text = Properties.Settings.Default.Param3; // Загружаем ранее сохраненный текст
            richTextBox4.Text = Properties.Settings.Default.Param4; // Загружаем ранее сохраненный текст
            Properties.Settings.Default.Save();  // Сохраняем переменные.
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
           


            Properties.Settings.Default.Save_text1 = richTextBox1.Text; // Записываем содержимое richTextBox1 в Save_text
            Properties.Settings.Default.Save(); // Сохраняем переменные.


            Properties.Settings.Default.Save_text2 = richTextBox2.Text; // Записываем содержимое richTextBox1 в Save_text
           Properties.Settings.Default.Save(); // Сохраняем переменные.
            Properties.Settings.Default.Save_text3 = richTextBox3.Text; // Записываем содержимое richTextBox1 в Save_text
            Properties.Settings.Default.Save(); // Сохраняем переменные.
            Properties.Settings.Default.Save_text4 = richTextBox4.Text; // Записываем содержимое richTextBox1 в Save_text
            Properties.Settings.Default.Save(); // Сохраняем переменные.
            MessageBox.Show("Текст сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Говорим пользователю, что сохранили текст.
                                                                                                          
       }


        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //переход к другой форме
            this.Hide();
            Form2 f5 = new Form2();
            f5.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = Properties.Settings.Default.Param1; // Загружаем ранее сохраненный текст
            richTextBox1.Text = Properties.Settings.Default.Save_text1 + Properties.Settings.Default.Param1;
            richTextBox2.Text = Properties.Settings.Default.Save_text2 + Properties.Settings.Default.Param2;
            richTextBox3.Text = Properties.Settings.Default.Save_text3 + Properties.Settings.Default.Param3;
            richTextBox4.Text = Properties.Settings.Default.Save_text4 + Properties.Settings.Default.Param4;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
