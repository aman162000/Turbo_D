using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turbo_C_Draw
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Point point_x, point_y;
        Graphics graphics;
        bool isPaint = false;
        String choice;
        Pen pen = new(Color.White,1);
        int x,y,start_x,start_y,end_x,end_y;
        String selected_Color;
        public Form1()
        {
            InitializeComponent();
            Size size = new(640, 480);
            this.pictureBox1.Size = size;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.getCordinate);
            this.Opacity = 0.5;
            bm = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            graphics = Graphics.FromImage(bm);
            graphics.Clear(Color.Black);
            this.pictureBox1.Image = bm;
            this.selectedColor.BackColor = Color.White;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void getCordinate(object sender, MouseEventArgs e)
        {
            label1.Text = e.X+","+e.Y;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                graphics.Clear(Color.Black);
                pictureBox1.Image = bm;
                richTextBox1.Text = "";
            }

          
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (isPaint)
            {

                if (choice == "rectangle")
                {
                    e.Graphics.DrawRectangle(pen, Math.Min(start_x, x), Math.Min(start_y, y), Math.Abs(end_x), Math.Abs(end_y));
                }
                if(choice == "circle")
                {
                    e.Graphics.DrawEllipse(pen, Math.Min(start_x, x), Math.Min(start_y, y), Math.Abs(end_x), Math.Abs(end_y));
                }
                if(choice == "line")
                {
                    e.Graphics.DrawLine(pen, start_x, start_y, x, y);
                }
                if(choice == "rectangle_fill")
                {
                    e.Graphics.FillRectangle(new SolidBrush(pen.Color), Math.Min(start_x, x), Math.Min(start_y, y), Math.Abs(end_x), Math.Abs(end_y));
                }
            }
        }

        private void getChoice(object sender, EventArgs e)
        {
            choice = ((RadioButton)sender).Name;
        }

        private void copyToClipBoard(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "") {
                Clipboard.SetText(richTextBox1.Text);
                MessageBox.Show("Copied to clipboard.", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to copy.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            point_y = e.Location;
            start_x = e.X;
            start_y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                if (choice == "freeDraw")
                {
                    point_x = e.Location;
                    graphics.FillRectangle(new SolidBrush(pen.Color), point_x.X, point_y.Y,1,1);
                    point_y = point_x;
                    richTextBox1.Text += "putpixel(" + point_x.X + "," + point_x.Y + ","+ selected_Color + ")\n";
                }


                x = e.X;
                y = e.Y;
                end_x = e.X - start_x;
                end_y = e.Y - start_y;
              
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
            end_x = x - start_x;
            end_y = y - start_y;
            
            if(choice == "line")
            {
                graphics.DrawLine(pen,start_x,start_y,x,y);
                richTextBox1.Text += "line(" + start_x + "," + start_y + "," + x + "," + y +");\n";
            }
            if (choice== "rectangle")
            {
                graphics.DrawRectangle(pen, Math.Min(start_x, x), Math.Min(start_y, y), Math.Abs(end_x), Math.Abs(end_y));
                richTextBox1.Text += "rectangle(" + Math.Min(start_x, x) + "," + Math.Min(start_y, y) + "," + Math.Abs(end_x) + "," + Math.Abs(end_y) + ");\n";
            }

            if(choice == "rectangle_fill")
            {
                graphics.FillRectangle(new SolidBrush(pen.Color), Math.Min(start_x, x), Math.Min(start_y, y), Math.Abs(end_x), Math.Abs(end_y));
                richTextBox1.Text += "bar(" + Math.Min(start_x, x) + "," + Math.Min(start_y, y) + "," + Math.Abs(end_x) + "," + Math.Abs(end_y) + ");\n";
            }

            if(choice == "circle")
            {
                graphics.DrawEllipse(pen, Math.Min(start_x, x), Math.Min(start_y, y), Math.Abs(end_x), Math.Abs(end_y));


                if ((start_x > end_x)&(start_y > end_y))
                {

                richTextBox1.Text += "ellipse(" + (Math.Min(start_x, x) - (int)Math.Round(Math.Abs(end_x) / 2.0)) + "," + (Math.Min(start_y, y) - (int)Math.Round(Math.Abs(end_y) / 2.0)) + ",0,360," + (int)Math.Round(Math.Abs(end_x)/2.0) + "," + (int)Math.Round(Math.Abs(end_y)/2.0) + ");\n";
                }

                else if ((start_x > end_x) & (start_y < end_y))
                {

                    richTextBox1.Text += "ellipse(" + (Math.Min(start_x, x) - (int)Math.Round(Math.Abs(end_x) / 2.0)) + "," + (Math.Min(start_y, y) + (int)Math.Round(Math.Abs(end_y) / 2.0)) + ",0,360," + (int)Math.Round(Math.Abs(end_x) / 2.0) + "," + (int)Math.Round(Math.Abs(end_y) / 2.0) + ");\n";
                }
                else if ((start_x < end_x) & (start_y > end_y))
                {

                    richTextBox1.Text += "ellipse(" + (Math.Min(start_x, x) + (int)Math.Round(Math.Abs(end_x) / 2.0)) + "," + (Math.Min(start_y, y) - (int)Math.Round(Math.Abs(end_y) / 2.0)) + ",0,360," + (int)Math.Round(Math.Abs(end_x) / 2.0) + "," + (int)Math.Round(Math.Abs(end_y) / 2.0) + ");\n";
                }
                else
                {

                    richTextBox1.Text += "ellipse(" + (Math.Min(start_x, x) + (int)Math.Round(Math.Abs(end_x) / 2.0)) + "," + (Math.Min(start_y, y) + (int)Math.Round(Math.Abs(end_y) / 2.0)) + ",0,360," + (int)Math.Round(Math.Abs(end_x) / 2.0) + "," + (int)Math.Round(Math.Abs(end_y) / 2.0) + ");\n";
                }

            }
        }

        private void GetColor(object sender, EventArgs e)
        {

            pen.Color = selectedColor.BackColor = ((Button)sender).BackColor;
            selected_Color = ((Button)sender).Name.ToUpperInvariant();
            richTextBox1.Text +="setcolor("+((Button)sender).Name.ToUpperInvariant()+ ");\nsetfillstyle(SOLID_FILL,"+((Button)sender).Name.ToUpperInvariant() + ");\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
                System.Diagnostics.Debug.WriteLine(ActiveForm.Opacity+","+trackBar1.Value);
                Form1.ActiveForm.Opacity = 0.2+((double)trackBar1.Value / 10.0);            
        }
    }
}
