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
        TextBox txtb1, txtb2, txtb3, txtb4;
        ListView listview;
        Graphics gp;
        Panel panel1;
        Label lbl, lbl2, lbl3, lbl4;
        Pen p = new Pen(Brushes.Black, 2);
        private bool byHeight;
        public Form1()
        {


            Height = 600;
            Width = 800;

            listview = new ListView();
            listview.Width = 300;
            listview.Height = 200;
            listview.Location = new Point(25, 25);
            listview.View = View.Details;
            listview.Columns.Add("Значение", 100, HorizontalAlignment.Left);
            listview.Columns.Add("Параметр", 100, HorizontalAlignment.Right);
            Controls.Add(listview);


            lbl = new Label();
            lbl.Width = 63;
            lbl.Height = 20;
            lbl.Location = new Point(30, 330);
            lbl.Text = "Сторона(A)";
            lbl.BackColor = Color.FromArgb(179, 215, 227);
            Controls.Add(lbl);


            lbl2 = new Label();
            lbl2.Width = 63;
            lbl2.Height = 20;
            lbl2.Location = new Point(30, 360);
            lbl2.Text = "Сторона(B)";
            lbl2.BackColor = Color.FromArgb(179, 215, 227);
            Controls.Add(lbl2);


            lbl3 = new Label();
            lbl3.Width = 63;
            lbl3.Height = 20;
            lbl3.Location = new Point(30, 390);
            lbl3.Text = "Сторона(C)";
            lbl3.BackColor = Color.FromArgb(179, 215, 227);
            Controls.Add(lbl3);



            lbl4 = new Label();
            lbl4.Width = 63;
            lbl4.Height = 20;
            lbl4.Location = new Point(30, 420);
            lbl4.Text = "Сторона(H)";
            lbl4.BackColor = Color.FromArgb(179, 215, 227);
            Controls.Add(lbl4);



            btn = new Button();
            btn.Text = "Создать Триугольник";
            btn.Location = new Point(400, 100);
            btn.Height = 50;
            btn.Width = 150;
            //btn.BackColor = new Color;
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
            txtb4 = new TextBox();

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


            txtb4.Width = 100;
            txtb4.Height = 80;
            txtb4.Location = new Point(100, 420);
            txtb4.MaxLength = 50;


            Controls.Add(txtb1);
            Controls.Add(txtb2);
            Controls.Add(txtb3);
            Controls.Add(txtb4);



            panel1 = new Panel();
            panel1.Size = new Size(80, 80);
            panel1.Location = new Point(120, 280);
            Controls.Add(panel1);
            gp = panel1.CreateGraphics();



        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (listview.Items.Count > 0)
            {
                listview.Items.Clear();
            }
            if (txtb1.Text.Length > 0 && txtb2.Text.Length > 0 && txtb3.Text.Length > 0)
            {


                double a, b, c;
                a = Convert.ToDouble(txtb1.Text);
                b = Convert.ToDouble(txtb2.Text);
                c = Convert.ToDouble(txtb3.Text);
                Triangle triangle = new Triangle(a, b, c);
                listview.Items.Add("Сторона a =");
                listview.Items.Add("Сторона b =");
                listview.Items.Add("Сторона c =");
                listview.Items.Add("Периметр =");
                listview.Items.Add("Площадь =");
                listview.Items.Add("Существует?");
                listview.Items.Add("Спецификатор");
                listview.Items[0].SubItems.Add(triangle.OutputA());
                listview.Items[1].SubItems.Add(triangle.OutputB());
                listview.Items[2].SubItems.Add(triangle.OutputC());
                listview.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listview.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { listview.Items[5].SubItems.Add("Существует"); }
                else listview.Items[5].SubItems.Add("Не существует");
                if (triangle.TriangleType == "Равносторонний" && triangle.ExistTriangle == true)
                {
                    panel1.Refresh();
                    Point p1 = new Point(10, 5);
                    Point p2 = new Point(70, 5);
                    Point p3 = new Point(55, 40);

                    gp.DrawLine(p, p1, p2);
                    gp.DrawLine(p, p2, p3);
                    gp.DrawLine(p, p3, p1);
                }
                else if (triangle.TriangleType == "Равнобедренный" && triangle.ExistTriangle == true)
                {
                    panel1.Refresh();
                    Point p1 = new Point(15, 5);
                    Point p2 = new Point(65, 5);
                    Point p3 = new Point(40, 40)
                    ;

                    gp.DrawLine(p, p1, p2);
                    gp.DrawLine(p, p2, p3);
                    gp.DrawLine(p, p3, p1);

                }

                else if (triangle.TriangleType == "Разносторонний" && triangle.ExistTriangle == true)
                {
                    panel1.Refresh();
                    Point p1 = new Point(10, 5);
                    Point p2 = new Point(70, 5);
                    Point p3 = new Point(55, 40);

                    gp.DrawLine(p, p1, p2);
                    gp.DrawLine(p, p2, p3);
                    gp.DrawLine(p, p3, p1);
                }
                else
                {
                    panel1.Refresh();

                }
            }
            else if (txtb1.Text.Length > 0 && txtb4.Text.Length > 0)
            {
                double a, h;
                a = Convert.ToDouble(txtb1.Text);
                h = Convert.ToDouble(txtb4.Text);
                Triangle triangle = new Triangle(byHeight, a, h);
                listview.Items.Add("Сторона a =");
                listview.Items.Add("Сторона b =");
                listview.Items.Add("Сторона c =");
                listview.Items.Add("Высота h =");
                listview.Items.Add("Периметр =");
                listview.Items.Add("Площадь =");
                listview.Items.Add("Существует?");
                listview.Items.Add("Спецификатор");
                listview.Items[0].SubItems.Add(triangle.OutputA());
                listview.Items[1].SubItems.Add(triangle.OutputB());
                listview.Items[2].SubItems.Add(triangle.OutputC());
                listview.Items[3].SubItems.Add(triangle.OutputH());
                listview.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listview.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { listview.Items[6].SubItems.Add("Существует"); }
                else listview.Items[6].SubItems.Add("Не существует");

            }
        }
        
        private void Btn_Click_draw(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtb1.Text);
            b = Convert.ToDouble(txtb2.Text);
            c = Convert.ToDouble(txtb3.Text);
            Triangle triangle = new Triangle(a, b, c);
            if (triangle.TriangleType == "Равносторонний" && triangle.ExistTriangle == true)
            {
                panel1.Refresh();
                Point p1 = new Point(10, 5);
                Point p2 = new Point(70, 5);
                Point p3 = new Point(55, 40);

                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else if (triangle.TriangleType == "Равнобедренный" && triangle.ExistTriangle == true)
            {
                panel1.Refresh();
                Point p1 = new Point(15, 5);
                Point p2 = new Point(65, 5);
                Point p3 = new Point(40, 40);

                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);

            }

            else if (triangle.TriangleType == "Разносторонний" && triangle.ExistTriangle == true)
            {
                panel1.Refresh();
                Point p1 = new Point(10, 5);
                Point p2 = new Point(70, 5);
                Point p3 = new Point(55, 40);

                gp.DrawLine(p, p1, p2);
                gp.DrawLine(p, p2, p3);
                gp.DrawLine(p, p3, p1);
            }
            else
            {
                panel1.Refresh();
            }
        }
    }
}
