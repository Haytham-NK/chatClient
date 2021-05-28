using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatClient
{
    public partial class authorization : Form
    {
        public string Log { get; set; }
        public authorization()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {


            if(tb_login.Text != "" && tb_password.Text != "")
            {
                try
                {
                   
                    Form ffm = new chatForm();
                    ffm.Owner = this;
                    ffm.ShowDialog();
                    ffm.Show();
                    Log = tb_login.Text;
                    this.Hide();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля!", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }
    }
}
