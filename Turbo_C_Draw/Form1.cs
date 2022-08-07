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
        private readonly Bitmap bm;
        private Point point_x, point_y;
        private readonly Graphics graphics;
        bool isPaint;
        private string choice = "";
        private readonly Pen pen = new(Color.White, 1);
        private int x, y, start_x, start_y, end_x, end_y;
        private string selected_Color = "";
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(640, 480);
            pictureBox1.MouseMove += new MouseEventHandler(GetCordinate);
            Opacity = 0.2 + (trackBar1.Value / 10.0);
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bm);
            graphics.Clear(Color.Black);
            pictureBox1.Image = bm;
            selectedColor.BackColor = Color.White;

        }

        private void GetCordinate(object? sender, MouseEventArgs e) => label1.Text = e.X + "," + e.Y;

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                graphics.Clear(Color.Black);
                pictureBox1.Image = bm;
                richTextBox1.Text = "";
            }

          
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
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

        private void GetChoice(object sender, EventArgs e) => choice = ((RadioButton)sender).Name;

        private void More_lable_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://github.com/aman162000/Turbo_D");

            }
            catch (Exception)
            {
                using System.Diagnostics.Process cmd = new();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();


                cmd.StandardInput.WriteLine("start https://github.com/aman162000/Turbo_D");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }
        }

        private void CopyToClipBoard(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Clipboard.SetText(richTextBox1.Text);
                MessageBox.Show("Copied to clipboard.", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nothing to copy.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            point_y = e.Location;
            start_x = e.X;
            start_y = e.Y;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                if (choice == "freeDraw")
                {
                    point_x = e.Location;
                    graphics.FillRectangle(brush: new SolidBrush(pen.Color),
                                           x: point_x.X,
                                           y: point_y.Y,
                                           width: 1,
                                           height: 1);
                    point_y = point_x;
                    richTextBox1.Text += "putpixel(" + point_x.X + "," + point_x.Y + "," + selected_Color + ")\n";
                }


                x = e.X;
                y = e.Y;
                end_x = e.X - start_x;
                end_y = e.Y - start_y;
              
            }
            pictureBox1.Refresh();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
            end_x = x - start_x;
            end_y = y - start_y;

            if (choice == "line")
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


                if ((start_x > end_x) & (start_y > end_y))
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
            richTextBox1.Text += "setcolor(" + ((Button)sender).Name.ToUpperInvariant() + ");\nsetfillstyle(SOLID_FILL," + ((Button)sender).Name.ToUpperInvariant() + ");\n";
        }


        private void TrackBar1_Scroll_1(object sender, EventArgs e) => ActiveForm.Opacity = 0.2 + (trackBar1.Value / 10.0);
    }
}
