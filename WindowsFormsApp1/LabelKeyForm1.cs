using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LabelKeyForm1 : Form
    {
        public LabelKeyForm1(string dataKey)
        {
            // data принимает Ключ из формы LogForm.
            this.data = dataKey;
            InitializeComponent();
        }
        string data;

        private void LabelKeyForm1_Load(object sender, EventArgs e)
        {
            txtKey.Text = data;
        }

        private void btnChangePas_Click(object sender, EventArgs e)
        {
            // 1) Передача ключа в конструктор формы "ChangePasForm".
            ChangePasForm f = new ChangePasForm(data);

            // 2) Открытие формы "ChangePasForm".
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
