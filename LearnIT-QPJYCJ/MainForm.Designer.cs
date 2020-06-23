namespace LearnIT_QPJYCJ
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signOutBtn = new System.Windows.Forms.Button();
            this.listKurzusaim = new System.Windows.Forms.ListBox();
            this.labelKurzusaim = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listKurzusok = new System.Windows.Forms.ListBox();
            this.labelKurzusok = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.universities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.LabelKurzusAr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.signOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.signOutBtn.Location = new System.Drawing.Point(13, 13);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(100, 40);
            this.signOutBtn.TabIndex = 0;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = false;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // listKurzusaim
            // 
            this.listKurzusaim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.listKurzusaim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listKurzusaim.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKurzusaim.ForeColor = System.Drawing.Color.White;
            this.listKurzusaim.FormattingEnabled = true;
            this.listKurzusaim.ItemHeight = 27;
            this.listKurzusaim.Location = new System.Drawing.Point(40, 130);
            this.listKurzusaim.Name = "listKurzusaim";
            this.listKurzusaim.Size = new System.Drawing.Size(370, 569);
            this.listKurzusaim.TabIndex = 1;
            // 
            // labelKurzusaim
            // 
            this.labelKurzusaim.AutoSize = true;
            this.labelKurzusaim.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKurzusaim.Location = new System.Drawing.Point(140, 85);
            this.labelKurzusaim.MinimumSize = new System.Drawing.Size(150, 0);
            this.labelKurzusaim.Name = "labelKurzusaim";
            this.labelKurzusaim.Size = new System.Drawing.Size(150, 36);
            this.labelKurzusaim.TabIndex = 2;
            this.labelKurzusaim.Text = "My Courses";
            this.labelKurzusaim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearnIT_QPJYCJ.Resource.rick;
            this.pictureBox1.Location = new System.Drawing.Point(480, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // listKurzusok
            // 
            this.listKurzusok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.listKurzusok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listKurzusok.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKurzusok.ForeColor = System.Drawing.Color.White;
            this.listKurzusok.FormattingEnabled = true;
            this.listKurzusok.ItemHeight = 27;
            this.listKurzusok.Location = new System.Drawing.Point(1190, 207);
            this.listKurzusok.Name = "listKurzusok";
            this.listKurzusok.Size = new System.Drawing.Size(350, 488);
            this.listKurzusok.TabIndex = 5;
            this.listKurzusok.SelectedIndexChanged += new System.EventHandler(this.listKurzusok_SelectedIndexChanged);
            // 
            // labelKurzusok
            // 
            this.labelKurzusok.AutoSize = true;
            this.labelKurzusok.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKurzusok.Location = new System.Drawing.Point(1290, 168);
            this.labelKurzusok.MinimumSize = new System.Drawing.Size(150, 0);
            this.labelKurzusok.Name = "labelKurzusok";
            this.labelKurzusok.Size = new System.Drawing.Size(150, 36);
            this.labelKurzusok.TabIndex = 2;
            this.labelKurzusok.Text = "Other courses";
            this.labelKurzusok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(600, 613);
            this.labelCourse.MinimumSize = new System.Drawing.Size(400, 0);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(400, 36);
            this.labelCourse.TabIndex = 7;
            this.labelCourse.Text = "Course label";
            this.labelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.button1.Location = new System.Drawing.Point(750, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // universities
            // 
            this.universities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.universities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.universities.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.universities.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.universities.ForeColor = System.Drawing.Color.White;
            this.universities.FormattingEnabled = true;
            this.universities.Location = new System.Drawing.Point(1190, 130);
            this.universities.Name = "universities";
            this.universities.Size = new System.Drawing.Size(350, 35);
            this.universities.TabIndex = 19;
            this.universities.SelectedIndexChanged += new System.EventHandler(this.universities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1290, 91);
            this.label1.MinimumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "University";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(550, 4);
            this.labelWelcome.MinimumSize = new System.Drawing.Size(500, 50);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(500, 50);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "Welcome";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelKurzusAr
            // 
            this.LabelKurzusAr.AutoSize = true;
            this.LabelKurzusAr.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKurzusAr.Location = new System.Drawing.Point(600, 649);
            this.LabelKurzusAr.MinimumSize = new System.Drawing.Size(400, 0);
            this.LabelKurzusAr.Name = "LabelKurzusAr";
            this.LabelKurzusAr.Size = new System.Drawing.Size(400, 36);
            this.LabelKurzusAr.TabIndex = 21;
            this.LabelKurzusAr.Text = "Ar";
            this.LabelKurzusAr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 64);
            this.label2.MinimumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "You have: xxxx FT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.button2.Location = new System.Drawing.Point(1470, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add money";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LabelKurzusAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.universities);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.listKurzusok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelKurzusok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKurzusaim);
            this.Controls.Add(this.listKurzusaim);
            this.Controls.Add(this.signOutBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.ListBox listKurzusaim;
        private System.Windows.Forms.Label labelKurzusaim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelKurzusok;
        private System.Windows.Forms.ListBox listKurzusok;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox universities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label LabelKurzusAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}