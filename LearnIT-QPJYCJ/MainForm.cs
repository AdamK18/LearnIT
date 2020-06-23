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
    public partial class MainForm : Form
    {
        public int userID { get; set; }
        DatasEntities context = new DatasEntities();

        public List<string> kurzusaim;
        public List<string> kurzusok;
        Felhasznalo user;
        Kurzu kurzus;
        public MainForm()
        {
            InitializeComponent();
            listKurzusaim.DisplayMember = "Nev";
            listKurzusok.DisplayMember = "Nev";

            var unis = (from x in context.Egyetems select x).ToList();
            for (int i = 0; i < unis.Count-1; i++)
            {
                universities.Items.Add(new KeyValuePair<string, int>(unis[i].Nev.ToString(), i));
            }
            universities.Items.Add(new KeyValuePair<string, int>("Összes", 4));
            universities.DisplayMember = "key";
            universities.ValueMember = "value";
            universities.SelectedIndex = 4;

            applyVisual();
            this.FormClosed += MainForm_FormClosed;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void applyVisual()
        {
            Color yellow = new Color();
            yellow = Color.FromArgb(246, 201, 14);

            signOutBtn.FlatStyle = FlatStyle.Flat;
            signOutBtn.FlatAppearance.BorderColor = yellow;
            
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = yellow;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = yellow;
        }

        public void getData(int value)
        {
            userID = value;

            user = (from x in context.Felhasznaloes where x.ID == userID select x).FirstOrDefault();
            showData();
            refreshMoney();
            labelWelcome.Text = "Welcome " + user.VezetekNev + " " + user.KeresztNev;
        }

        private void refreshMoney()
        {
            label2.Text = "You have: " + user.Penz + " FT";
        }

        private void showData()
        {
            kurzusaim = (from x in context.FelhasznaloKurzus where x.FelhasznaloID == userID select x.Kurzu.Targy.Nev).ToList();
            listKurzusaim.DataSource = kurzusaim;
            if (universities.SelectedIndex == 4) kurzusok = (from x in context.Targies select x.Nev).ToList();
            else kurzusok = (from x in context.Kurzus where x.EgyetemID == universities.SelectedIndex select x.Targy.Nev).ToList();
            foreach (string x in kurzusaim)
            {
                kurzusok.Remove(x);
            }
            listKurzusok.DataSource = kurzusok;
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignInForm().Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var current = kurzusok[listKurzusok.SelectedIndex];
            var kurzus = getKurzus();
            if(kurzus.Ar.Ertek > user.Penz)
            {
                MessageBox.Show("Not enough money!");
                return;
            }
            context.FelhasznaloKurzus.Add(new FelhasznaloKurzu() {ID = ((from x in context.FelhasznaloKurzus select x).ToList().LastOrDefault().ID + 1),
            FelhasznaloID = userID, KurzusID = kurzus.ID});
            user.Penz -= kurzus.Ar.Ertek;

            context.SaveChanges();
            kurzusok.Remove(current);
            kurzusaim.Add(current);
            showData();
            refreshMoney();
        }

        private Kurzu getKurzus()
        {
            var current = kurzusok[listKurzusok.SelectedIndex];
            var targyID = ((from x in context.Targies where x.Nev == current select x).ToList().LastOrDefault().ID);
            var kurzus = ((from x in context.Kurzus where x.ID == targyID select x).ToList().LastOrDefault());
            return kurzus;
        }

        private void universities_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void listKurzusok_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCourse.Text = kurzusok[listKurzusok.SelectedIndex];
            var kurzus = getKurzus();
            var ar = (from x in context.Kurzus where x.ID == kurzus.ID select x.Ar.Ertek).ToList().FirstOrDefault().ToString();
            LabelKurzusAr.Text = ar + " FT";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.Penz += 2000;
            showData();
            context.SaveChanges();
            refreshMoney();
        }
    }
}
