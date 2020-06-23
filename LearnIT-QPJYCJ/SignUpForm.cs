using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnIT_QPJYCJ
{
    public partial class SignUpForm : Form
    {
        DatasEntities context = new DatasEntities();

        public SignUpForm()
        {
            InitializeComponent();
            context.Felhasznaloes.Load();
            context.Egyetems.Load();
            
            var unis = (from x in context.Egyetems select x).ToArray();
            for (int i = 0; i < unis.Length; i++)
            {
                universities.Items.Add(new KeyValuePair<string, string>(unis[i].Nev.ToString(), i.ToString()));
            }
            universities.DisplayMember = "key";
            universities.ValueMember = "value";

            applyVisual();
            this.FormClosed += SignUpForm_FormClosed;
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void applyVisual()
        {
            Color yellow = new Color();
            yellow = Color.FromArgb(246, 201, 14);

            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.FlatAppearance.BorderColor = yellow;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> boxes = new List<string>()
            {firstName.Text, lastName.Text,age.Text,email.Text,pw1.Text, pw2.Text};
            foreach (string x in boxes)
            {
                if (x == "" || x == null)
                {
                    MessageBox.Show("Please fill out every box!");
                    return;
                }
            }
            
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!r.IsMatch(email.Text))
            {
                MessageBox.Show("Enter a valid email address!");
                return;
            }
            if (pw1.Text != pw2.Text)
            {
                MessageBox.Show("The passwords must match!");
                return;
            }
            try
            {
                int.Parse(age.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number into age");
                return;
            }
            if(universities.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a University");
                return;
            }
                
            var users = (from x in context.Felhasznaloes select x).ToList();
            foreach (Felhasznalo felhasznalo in users)
            {
                if(felhasznalo.Email == email.Text.ToString())
                {
                    MessageBox.Show("This email is already registered");
                    return;
                }
            }

            Felhasznalo user = new Felhasznalo() {
                ID = users.Last().ID+1,
                KeresztNev = firstName.Text,
                VezetekNev = lastName.Text,
                Kor = int.Parse(age.Text),
                Email = email.Text,
                EgyetemID = universities.SelectedIndex,
                Jelszo = pw1.Text
            };
            context.Felhasznaloes.Add(user);

            try
            {
                context.SaveChanges();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
            this.Hide();
            var mf = new MainForm();
            mf.getData(user.ID);
            mf.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignInForm().Show();
        }
    }
}
