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
        public double a; //Первая сторона
        public double b; //Вторая сторона
        public double c; //Третия сторона
        public double l; //Четвёртая сторона
        Button btn;
        public Form1()
        {


            Height = 800;
            Width = 800;
            ListView listView = new ListView();
            listView.Location = new Point(100, 50);
            Name = "listView";
            listView.Size = new Size(150, 150);
            listView.BackColor = Color.CadetBlue;
            listView.ForeColor = Color.Black;
            Controls.Add(listView);


            btn = new Button();
            btn.Text = "Создать Триугольник";
            btn.Location = new Point(400, 100);
            btn.Height = 50;
            btn.Width = 150;
            btn.Click += Btn_Click;
            Controls.Add(btn);

            TextBox txtb1 = new TextBox();
            TextBox txtb2 = new TextBox();
            TextBox txtb3 = new TextBox();
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

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   a = Convert.ToDouble(txtb1.Text);
       //     b = Convert.ToDouble(txtb2.Text);
     //       c = Convert.ToDouble(txtb3.Text);

        }
    }
}
