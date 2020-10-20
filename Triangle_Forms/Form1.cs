using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Forms
{
    public partial class Form1 : Form 
    {
        Button btn;
        TextBox txtb1, txtb2, txtb3;
        Label lbl;
        public Form1()
        {
            {
                InitializeComponent();
            }


            Height = 600;
            Width = 800;
            ListBox lbox = new ListBox();
            string[] colors_nimetused = new string[] { "Kollane", "Punane", "Roheline", "Sinine" };
            foreach (var item in colors_nimetused)
            {
                lbox.Items.Add(item);
            }
            lbox.Location = new Point(50, 175);
            lbox.Width = colors_nimetused.Length * 25;
            lbox.Height = colors_nimetused.Length * 15;
            Controls.Add(lbox);


            btn = new Button();
            btn.Text = "Создать Триугольник";
            btn.Location = new Point(400, 100);
            btn.Height = 50;
            btn.Width = 150;
            btn.Click += Btn_Click;
            Controls.Add(btn);




            lbl = new Label();
            lbl.Text = "Tarkvara";
            lbl.Size = new Size(150, 50);
            lbl.Location = new Point(110, 120);
            Controls.Add(lbl);



            txtb1 = new TextBox();
            txtb2 = new TextBox();
            txtb3 = new TextBox();
            txtb1.Width = 100;
            txtb1.Height = 80;
            txtb1.Location = new Point(100, 230);
            txtb1.MaxLength = 50;

            txtb2.Width = 100;
            txtb2.Height = 80;
            txtb2.Location = new Point(100, 260);
            txtb2.MaxLength = 50;

            txtb3.Width = 100;
            txtb3.Height = 80;
            txtb3.Location = new Point(100, 290);
            txtb3.MaxLength = 50;
            Controls.Add(txtb1);
            Controls.Add(txtb2);
            Controls.Add(txtb3);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c;
            MessageBox.Show(txtb1.Text);
        }

        private void lbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtb11(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtb1.Text);
            }

        }
    }
}
