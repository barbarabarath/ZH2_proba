using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace ZH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckLogin(string user)
        {
            return !string.IsNullOrEmpty(user);
        }

        private bool CheckPassword(string password)
        {
            Regex r = new Regex("^[a-zA-Z0-4]{6}");
            return r.IsMatch(password);
        }

        private void textLogin_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textLogin, "");
        }

        private void textLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!CheckLogin(textLogin.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textLogin, "Felhasználónév nem lehet üres!");
            }
        }

        private void textPassword_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textPassword, "");
        }

        private void textPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!CheckPassword(textPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textPassword, "Érvénytelen jelszó!");
            }
        }

        private void btnBelepes_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            CausesValidation = true;
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztos ki szeretne lépni?", "Kilépés", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK) { e.Cancel = true; }
            else { System.Environment.Exit(1); }

        }
    }
}