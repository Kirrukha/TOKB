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
    public partial class KeyForm : Form
    {
        int PopytkaNum = 2; // Попытки.
        Func b;
        public KeyForm(string dataPas)
        {
            // data принимает пароль из формы LogForm.
            this.data = dataPas;
            b = new Func();
            InitializeComponent();
        }
        string data;

        private void btnKey_Click(object sender, EventArgs e)
        {
            
            string Key, EncodePas; // Новый ключ сгенерированный пароль к нему.
            string EnterPas; // Введёный (Зашифрованный) пароль.
            String UserData; // Сохранённый в файле (Зашифрованный) пароль.

            // 1) Считывание пароля из файла.
            UserData = b.ReadFromFile();

            // Если длинна введенного пароля больше для зашифрованного. 
            //Такая проверка нужна потому что алгоритм не будет работать.
            if (data.Length > UserData.Length)
            {
                // 4) Сообщение об ошибке(еще 2 попытки).
                MessageBox.Show(String.Format("Неправильный пароль или ключ!\nОсталось попыток: {0}", PopytkaNum));
                PopytkaNum--;

                LogForm f = new LogForm();

                // 5) Открытие формы "LogForm" для ввода пароля.
                this.Hide();
                f.ShowDialog();
                this.Close();

                if (PopytkaNum < 0)
                {
                    MessageBox.Show("Попытки закончились!");
                    this.Close();
                }
                
            }

            // 2) Шифрование принятого пароля "data = txtPas.Text".
            EnterPas = b.Encode(data, txtKey.Text);

            // 3) Проверка зашифрованного пароля и пароля в файле(3 попытки).
            if (UserData == EnterPas) // Проверка Введённого и  Сохранённого в файле пароля.
            {

                // 4) Генерация НОВОГО ключа.
                Key = b.GenKey();

                // 5) Шифрование пароля.
                EncodePas = b.Encode(data, Key);

                // 6) Запись в файл.
                b.WriteInFile(EncodePas);

                // 7) Передача ключа в конструктор формы "LabelKeyForm1".
                LabelKeyForm1 f = new LabelKeyForm1(Key);

                // 8) Открытие формы "LabelKeyForm1".
                this.Hide();
                f.ShowDialog();
                this.Close();

            }
            else
            {
                // 4) Сообщение об ошибке(еще 2 попытки).
                MessageBox.Show(String.Format("Неправильный пароль или ключ!\nОсталось попыток: {0}", PopytkaNum));
                PopytkaNum--;
  
                LogForm f = new LogForm();

                // 5) Открытие формы "LogForm" для ввода пароля.
                this.Hide();
                f.ShowDialog();
                this.Close();

                if (PopytkaNum < 0)
                {
                    MessageBox.Show("Попытки закончились!");
                    this.Close();
                }
            }
                
        }
    }
}
