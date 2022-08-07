namespace Turbo_C_Draw
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rectangle = new System.Windows.Forms.RadioButton();
            this.rectangle_fill = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.RadioButton();
            this.freeDraw = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.white = new System.Windows.Forms.Button();
            this.lightgray = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.brown = new System.Windows.Forms.Button();
            this.lightmagenta = new System.Windows.Forms.Button();
            this.magenta = new System.Windows.Forms.Button();
            this.lightred = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.lightcyan = new System.Windows.Forms.Button();
            this.cyan = new System.Windows.Forms.Button();
            this.lightgreen = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.lightblue = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.darkgray = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedColor = new System.Windows.Forms.Panel();
            this.copy_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "0,0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordinates:";
            // 
            // rectangle
            // 
            this.rectangle.AutoSize = true;
            this.rectangle.Location = new System.Drawing.Point(19, 570);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(96, 24);
            this.rectangle.TabIndex = 4;
            this.rectangle.TabStop = true;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.CheckedChanged += new System.EventHandler(this.GetChoice);
            // 
            // rectangle_fill
            // 
            this.rectangle_fill.AutoSize = true;
            this.rectangle_fill.Location = new System.Drawing.Point(19, 600);
            this.rectangle_fill.Name = "rectangle_fill";
            this.rectangle_fill.Size = new System.Drawing.Size(117, 24);
            this.rectangle_fill.TabIndex = 5;
            this.rectangle_fill.TabStop = true;
            this.rectangle_fill.Text = "Rectangle fill";
            this.rectangle_fill.UseVisualStyleBackColor = true;
            this.rectangle_fill.CheckedChanged += new System.EventHandler(this.GetChoice);
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(19, 630);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(67, 24);
            this.circle.TabIndex = 6;
            this.circle.TabStop = true;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = true;
            this.circle.CheckedChanged += new System.EventHandler(this.GetChoice);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(142, 570);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(57, 24);
            this.line.TabIndex = 7;
            this.line.TabStop = true;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.CheckedChanged += new System.EventHandler(this.GetChoice);
            // 
            // freeDraw
            // 
            this.freeDraw.AutoSize = true;
            this.freeDraw.Location = new System.Drawing.Point(142, 600);
            this.freeDraw.Name = "freeDraw";
            this.freeDraw.Size = new System.Drawing.Size(95, 24);
            this.freeDraw.TabIndex = 9;
            this.freeDraw.TabStop = true;
            this.freeDraw.Text = "Free draw";
            this.freeDraw.UseVisualStyleBackColor = true;
            this.freeDraw.CheckedChanged += new System.EventHandler(this.GetChoice);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(262, 561);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 100);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Opacity";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(678, 588);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(238, 62);
            this.refreshBtn.TabIndex = 13;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(19, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(678, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(238, 484);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.white);
            this.panel1.Controls.Add(this.lightgray);
            this.panel1.Controls.Add(this.yellow);
            this.panel1.Controls.Add(this.brown);
            this.panel1.Controls.Add(this.lightmagenta);
            this.panel1.Controls.Add(this.magenta);
            this.panel1.Controls.Add(this.lightred);
            this.panel1.Controls.Add(this.red);
            this.panel1.Controls.Add(this.lightcyan);
            this.panel1.Controls.Add(this.cyan);
            this.panel1.Controls.Add(this.lightgreen);
            this.panel1.Controls.Add(this.green);
            this.panel1.Controls.Add(this.lightblue);
            this.panel1.Controls.Add(this.blue);
            this.panel1.Controls.Add(this.darkgray);
            this.panel1.Controls.Add(this.black);
            this.panel1.Location = new System.Drawing.Point(397, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 73);
            this.panel1.TabIndex = 15;
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(227, 38);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(33, 35);
            this.white.TabIndex = 15;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.GetColor);
            // 
            // lightgray
            // 
            this.lightgray.BackColor = System.Drawing.Color.LightGray;
            this.lightgray.Location = new System.Drawing.Point(227, 3);
            this.lightgray.Name = "lightgray";
            this.lightgray.Size = new System.Drawing.Size(33, 35);
            this.lightgray.TabIndex = 14;
            this.lightgray.UseVisualStyleBackColor = false;
            this.lightgray.Click += new System.EventHandler(this.GetColor);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(195, 38);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(33, 35);
            this.yellow.TabIndex = 13;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.GetColor);
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.Brown;
            this.brown.Location = new System.Drawing.Point(195, 3);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(33, 35);
            this.brown.TabIndex = 12;
            this.brown.UseVisualStyleBackColor = false;
            this.brown.Click += new System.EventHandler(this.GetColor);
            // 
            // lightmagenta
            // 
            this.lightmagenta.BackColor = System.Drawing.Color.LightPink;
            this.lightmagenta.Location = new System.Drawing.Point(163, 38);
            this.lightmagenta.Name = "lightmagenta";
            this.lightmagenta.Size = new System.Drawing.Size(33, 35);
            this.lightmagenta.TabIndex = 11;
            this.lightmagenta.UseVisualStyleBackColor = false;
            this.lightmagenta.Click += new System.EventHandler(this.GetColor);
            // 
            // magenta
            // 
            this.magenta.BackColor = System.Drawing.Color.Magenta;
            this.magenta.Location = new System.Drawing.Point(163, 3);
            this.magenta.Name = "magenta";
            this.magenta.Size = new System.Drawing.Size(33, 35);
            this.magenta.TabIndex = 10;
            this.magenta.UseVisualStyleBackColor = false;
            this.magenta.Click += new System.EventHandler(this.GetColor);
            // 
            // lightred
            // 
            this.lightred.BackColor = System.Drawing.Color.LightCoral;
            this.lightred.Location = new System.Drawing.Point(131, 38);
            this.lightred.Name = "lightred";
            this.lightred.Size = new System.Drawing.Size(33, 35);
            this.lightred.TabIndex = 9;
            this.lightred.UseVisualStyleBackColor = false;
            this.lightred.Click += new System.EventHandler(this.GetColor);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(131, 3);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(33, 35);
            this.red.TabIndex = 8;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.GetColor);
            // 
            // lightcyan
            // 
            this.lightcyan.BackColor = System.Drawing.Color.LightCyan;
            this.lightcyan.Location = new System.Drawing.Point(99, 38);
            this.lightcyan.Name = "lightcyan";
            this.lightcyan.Size = new System.Drawing.Size(33, 35);
            this.lightcyan.TabIndex = 7;
            this.lightcyan.UseVisualStyleBackColor = false;
            this.lightcyan.Click += new System.EventHandler(this.GetColor);
            // 
            // cyan
            // 
            this.cyan.BackColor = System.Drawing.Color.Cyan;
            this.cyan.Location = new System.Drawing.Point(99, 3);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(33, 35);
            this.cyan.TabIndex = 6;
            this.cyan.UseVisualStyleBackColor = false;
            this.cyan.Click += new System.EventHandler(this.GetColor);
            // 
            // lightgreen
            // 
            this.lightgreen.BackColor = System.Drawing.Color.LightGreen;
            this.lightgreen.Location = new System.Drawing.Point(67, 38);
            this.lightgreen.Name = "lightgreen";
            this.lightgreen.Size = new System.Drawing.Size(33, 35);
            this.lightgreen.TabIndex = 5;
            this.lightgreen.UseVisualStyleBackColor = false;
            this.lightgreen.Click += new System.EventHandler(this.GetColor);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(67, 3);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(33, 35);
            this.green.TabIndex = 4;
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.GetColor);
            // 
            // lightblue
            // 
            this.lightblue.BackColor = System.Drawing.Color.LightBlue;
            this.lightblue.Location = new System.Drawing.Point(35, 38);
            this.lightblue.Name = "lightblue";
            this.lightblue.Size = new System.Drawing.Size(33, 35);
            this.lightblue.TabIndex = 3;
            this.lightblue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lightblue.UseVisualStyleBackColor = false;
            this.lightblue.Click += new System.EventHandler(this.GetColor);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(35, 3);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(33, 35);
            this.blue.TabIndex = 2;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.GetColor);
            // 
            // darkgray
            // 
            this.darkgray.BackColor = System.Drawing.Color.DarkGray;
            this.darkgray.Location = new System.Drawing.Point(3, 38);
            this.darkgray.Name = "darkgray";
            this.darkgray.Size = new System.Drawing.Size(33, 35);
            this.darkgray.TabIndex = 1;
            this.darkgray.UseVisualStyleBackColor = false;
            this.darkgray.Click += new System.EventHandler(this.GetColor);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(3, 3);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(33, 35);
            this.black.TabIndex = 0;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.GetColor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(393, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color";
            // 
            // selectedColor
            // 
            this.selectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColor.Location = new System.Drawing.Point(454, 525);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(55, 25);
            this.selectedColor.TabIndex = 17;
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(678, 520);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(238, 62);
            this.copy_btn.TabIndex = 18;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.CopyToClipBoard);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 678);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.selectedColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.freeDraw);
            this.Controls.Add(this.line);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.rectangle_fill);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turbo D";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private RadioButton rectangle;
        private RadioButton rectangle_fill;
        private RadioButton circle;
        private RadioButton line;
        private RadioButton freeDraw;
        private TrackBar trackBar1;
        private Label label3;
        private Button refreshBtn;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Button white;
        private Button lightgray;
        private Button yellow;
        private Button brown;
        private Button lightmagenta;
        private Button magenta;
        private Button lightred;
        private Button red;
        private Button lightcyan;
        private Button cyan;
        private Button lightgreen;
        private Button green;
        private Button lightblue;
        private Button blue;
        private Button darkgray;
        private Button black;
        private Label label4;
        private Panel selectedColor;
        private Button copy_btn;
    }
}