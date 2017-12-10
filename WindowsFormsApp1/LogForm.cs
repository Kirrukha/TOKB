using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Functions;

namespace WindowsFormsApp1
{
    public partial class LogForm : Form
    {
        Func b;
        public LogForm()
        {
            b = new Func();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Файл НЕ существует.
            if (!(File.Exists("D:\\Univer\\ТОКБ\\WindowsFormsApp1\\Not_key.txt")))
            {
                string EncodePas, Key;

                // 1) Генерация ключа.
                Key = b.GenKey();

                // 2) Шифрование пароля.
                EncodePas = b.Encode(txtPas.Text, Key);

                // 3) Запись в файл.
                b.WriteInFile(EncodePas);

                // 4) Передача ключа в конструктор формы "LabelKeyForm1".
                LabelKeyForm1 f = new LabelKeyForm1(Key);

                // 5) Открытие формы "LabelKeyForm1".
                this.Hide();
                f.ShowDialog();
                this.Close();
                
            }
            // Файл существует.
            else
            {
                // 1) Передача пароля в конструктор формы "KeyForm".
                KeyForm f = new KeyForm(this.txtPas.Text);

                // 2) Открытие формы "KeyForm" для ввода ключа.
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            
        }

    }
}
