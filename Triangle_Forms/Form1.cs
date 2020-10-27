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
        Button btn, btn1;
        TextBox txtb1, txtb2, txtb3;
        ListView listview;
        Graphics gp;
        
        public Form1()
        {
        //    gp = panel1.CreateGraphics();
            Pen p = new Pen(Brushes.Black, 2);
            Pen p2 = new Pen(Brushes.Black, 2);
            Pen p3 = new Pen(Brushes.Black, 2);


            Height = 600;
            Width = 800;

            listview = new ListView();
            listview.Width = 300;
            listview.Height = 250;
            listview.Location = new Point(25, 25);
            listview.View = View.Details;
            listview.Columns.Add("znachenie", 100, HorizontalAlignment.Left);
            listview.Columns.Add("parametr", 100, HorizontalAlignment.Right);
            Controls.Add(listview);




            btn = new Button();
            btn.Text = "Создать Триугольник";
            btn.Location = new Point(400, 100);
            btn.Height = 50;
            btn.Width = 150;
            btn.Click += Btn_Click;
            Controls.Add(btn);


            btn1 = new Button();
            btn1.Text = "Нарисовать триугольник";
            btn1.Location = new Point(400, 170);
            btn1.Height = 50;
            btn1.Width = 150;
            btn1.Click += Btn_Click_draw;
            Controls.Add(btn1);







            txtb1 = new TextBox();
            txtb2 = new TextBox();
            txtb3 = new TextBox();
            txtb1.Width = 100;
            txtb1.Height = 80;
            txtb1.Location = new Point(100, 330);
            txtb1.MaxLength = 50;

            txtb2.Width = 100;
            txtb2.Height = 80;
            txtb2.Location = new Point(100, 360);
            txtb2.MaxLength = 50;

            txtb3.Width = 100;
            txtb3.Height = 80;
            txtb3.Location = new Point(100, 390);
            txtb3.MaxLength = 50;
            Controls.Add(txtb1);
            Controls.Add(txtb2);
            Controls.Add(txtb3);




        }

     /*   private void txtb1_Changed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtb1.Text);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show(txtb1.Text);
            }
        }*/
        private void Btn_Click(object sender, EventArgs e)
        {
                double a, b, c;
                a = Convert.ToDouble(txtb1.Text);
                b = Convert.ToDouble(txtb2.Text);
                c = Convert.ToDouble(txtb3.Text);
                Triangle triangle = new Triangle(a, b, c);
                listview.Items.Add("Сторона a = ");
                listview.Items.Add("Сторона b = ");
                listview.Items.Add("Сторона c = ");
                listview.Items.Add("Периметр = ");
                listview.Items.Add("Площадь");
                listview.Items.Add("Существует?");
                listview.Items.Add("Спецификатор");
                listview.Items[0].SubItems.Add(triangle.OutputA());
                listview.Items[1].SubItems.Add(triangle.OutputB());
                listview.Items[2].SubItems.Add(triangle.OutputC());
                listview.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listview.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { listview.Items[5].SubItems.Add("Существует"); }
                else listview.Items[5].SubItems.Add("Не существует");
            
        }

        
        private void Btn_Click_draw(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 5);
            Point p2 = new Point(150, 5);
            Point p3 = new Point(75, 30);

            //Point[] list = new Point[3] { p1, p2, p3 };
          //  gp.DrawPolygon(p, list);
        }
    }
}
