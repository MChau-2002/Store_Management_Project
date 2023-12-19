using StoreManagement.BUS;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string[] message = TaiKhoanBUS.Instance.DoiMatKhau(tbxPassCu.Text, tbxPassMoi.Text, tbxXacNhan.Text);
            MessageBox.Show(message[1], message[0]);
            if (message[0] == "success")
                Close();
        }

        private void btnXemMK_Click(object sender, EventArgs e)
        {
            // Check if the current PasswordChar is '*'
            if (tbxPassCu.PasswordChar == '*')
            {
                // If it is '*', set it to 0 to display the password in plain text
                tbxPassCu.PasswordChar = '\0';
                tbxPassMoi.PasswordChar = '\0';
                tbxXacNhan.PasswordChar = '\0';
            }
            else
            {
                // If it is not '*', set it to '*' to mask the password
                tbxPassCu.PasswordChar = '*';
                tbxPassMoi.PasswordChar = '*';
                tbxXacNhan.PasswordChar = '*';
            }
        }
    }
}
