using System.Text.RegularExpressions;

namespace homeswork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkbuton_Click(object sender, EventArgs e)
        {
            string password = passwd.Text;


            if (password.Length < 8)
            {
                MessageBox.Show("Sifre minimum 8 simvol olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                MessageBox.Show("Sifrede ən az 1 böyük hərf  olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                MessageBox.Show("Sifrede ən az 1 kiçik hərf  olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                MessageBox.Show("Sifrede ən az 1 rəqəm  olmalıdır.");
                return;
            }

            if (!Regex.IsMatch(password, @"[@#$%!*\^&\-_]"))
            {
                MessageBox.Show("Sifrede ən az 1 xususi isare (@, #, $, %, !, * və s.) olmalıdır.");
                return;
            }

            string lower = password.ToLower();
            for (int i = 0; i < lower.Length - 2; i++)
            {
                if ((lower[i + 1] == lower[i] + 1) && (lower[i + 2] == lower[i] + 2))
                {
                    MessageBox.Show("Sifrede 123 və ya abc kimi ardıcıl simvollar olmamalıdır.");
                    return;
                }
            }

            MessageBox.Show("Sifre duzgundur!");
        }

        private void clickexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
