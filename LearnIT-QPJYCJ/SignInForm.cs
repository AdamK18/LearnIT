using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnIT_QPJYCJ
{
    public partial class SignInForm : Form
    {
        DatasEntities context = new DatasEntities();

        public SignInForm()
        {
            InitializeComponent();
            context.Felhasznaloes.Load();
            context.Mentetts.Load();
            applyVisual();
            this.FormClosed += SignInForm_FormClosed;
        }

        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void applyVisual()
        {
            Color yellow = new Color();
            yellow = Color.FromArgb(246, 201, 14);

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = yellow;

            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.FlatAppearance.BorderColor = yellow;

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            var jelszo = textBox2.Text;

            var felhasznalo = (from x in context.Felhasznaloes where x.Email == email select x).FirstOrDefault();
            if(felhasznalo is null)
            {
                MessageBox.Show("User does not exist!");
                return;
            }
            
            if (felhasznalo.Email == email && felhasznalo.Jelszo == jelszo)
            {
                this.Hide();
                var mf = new MainForm();
                var value = (from x in context.Felhasznaloes where x.Email == textBox1.Text select x).FirstOrDefault().ID;
                mf.getData(value);
                mf.Show();
            }
            else
            {
                MessageBox.Show("Incorrect E-mail or password! Please try again.  " + felhasznalo.Email + " " + felhasznalo.Jelszo);
                textBox1.Clear(); textBox2.Clear();
                email = ""; jelszo = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }
    }
}
