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
    public partial class ChangePasForm : Form
    {
        Func b;
        public ChangePasForm(string dataKey)
        {
            // data принимает Ключ из формы LogForm.
            this.data = dataKey;
            b = new Func();
            InitializeComponent();
        }
        string data;

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtPasOld.Text != "" || txtPasNew.Text != "")
            {
                string PasOld; // Зашифрованный старый пароль по новому ключу.
                String UserData; // Сохранённый в файле (Зашифрованный) пароль.

                // Для считывания зашифрованного пароля из файла.
                UserData = b.ReadFromFile();

                // 1) Шифрование старого пароля по НОВОМУ ключу.
                PasOld = b.Encode(txtPasOld.Text, data);

                // 2) Если зашифрованный старый пароль = зашифрованному паролю в файле:
                if (PasOld == UserData)
                {
                    string EncodePas, Key; // Новый пароль, новый ключ.

                    // 1) Генерация нового ключа.
                    Key = b.GenKey();

                    // 2) Шифрование нового пароля.
                    EncodePas = b.Encode(txtPasNew.Text, Key);

                    // 3) Запись в файл.
                    b.WriteInFile(EncodePas);

                    // 4) Передача ключа в конструктор формы "LabelKeyForm1".
                    LabelKeyForm1 f = new LabelKeyForm1(Key);

                    // 5) Открытие формы "LabelKeyForm1".
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Введённый пароль НЕ верен!");

            }
            else if (txtPasOld.Text == "" || txtPasNew.Text == "")
            {
                MessageBox.Show("Одно (или оба) из полей для ввода пароля пустое!");
            }
            txtPasOld.Clear();
            txtPasNew.Clear();
        }
    }
}
