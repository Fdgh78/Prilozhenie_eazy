using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using WindowsFormsApp6.Properties;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text += " " + Properties.Settings.Default.Version; //Добавляем в название программы, версию.
             textBox1.Text = Properties.Settings.Default.Param1; // Загружаем ранее сохраненный текст
            textBox2.Text = Properties.Settings.Default.Param2;
            textBox3.Text = Properties.Settings.Default.Param3;
            textBox4.Text = Properties.Settings.Default.Param4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Param1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //картинка
        private void pictureBox4_Click(object sender, EventArgs e)
        {

    

            string w;
            w = "";

            w = textBox1.Text;
            if (textBox1.Text == "")
            {

            }
            else
            {

                Properties.Settings.Default.Save(); // Сохраняем переменные.
            }

            textBox1.Text = "pass";*/

        }




       private void button1_Click(object sender, EventArgs e)

        {
            //переход к другой форме
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.Param1 = textBox1.Text; // Записываем содержимое textBox1 в Param1
            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
    
            Properties.Settings.Default.Param4 = textBox4.Text; // Записываем содержимое textBox1 в Param4

            Properties.Settings.Default.Save();
            MessageBox.Show("Текст сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // Говорим пользователю, что сохранили текст.
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

            Properties.Settings.Default.Param4 = textBox4.Text; // Записываем содержимое textBox1 в Param1
            Properties.Settings.Default.Save();



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           // richTextBox1.Text = Properties.Settings.Default.Param1; // Загружаем ранее сохраненный текст
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Param2 = textBox2.Text; // Записываем содержимое textBox1 в Param1
            Properties.Settings.Default.Save();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Param3 = textBox3.Text; // Записываем содержимое textBox1 в Param1
            Properties.Settings.Default.Save();
        }
    }
}
