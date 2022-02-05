using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text += " " + Properties.Settings.Default.Version; //Добавляем в название программы, версию.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // private void button1_Click(object sender, EventArgs e) //задание =)
            {
                textBox1.UseSystemPasswordChar = true; //шифрует данные поля2 символами 
                                                       //   }

                //Теперь главная кнопка(Войти) ,делаем еще пустую строку и пишем

                //  private void button2_Click(object sender, EventArgs e) //задание
                {
                    //"если" в поле1 значение "metro" и если в поле2 значение "pass" P.S metro - логин ; asd - пароль!!!

                    if (textBox2.Text == "metro" && textBox1.Text == "asd")
                    {
                        panel1.Visible = false; //тогда панель и её содержимое уходит!
                        //переход к другой форме
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                    else //иначе
                    {
                        MessageBox.Show("Неверный пароль или логин", "Ошибка"); //вылазит ошибка о неверном пароле!
                    }
                    //переход к другой форме
                  //  this.Hide();
                  //  Form2 f2 = new Form2();
                  //  f2.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
