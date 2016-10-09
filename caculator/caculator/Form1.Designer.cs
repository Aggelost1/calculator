namespace caculator
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.deciml = new System.Windows.Forms.Button();
            this.memminus = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.memplus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.over = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.memrecal = new System.Windows.Forms.Button();
            this.memclear = new System.Windows.Forms.Button();
            this.memstore = new System.Windows.Forms.Button();
            this.oneoverx = new System.Windows.Forms.Button();
            this.clearlall = new System.Windows.Forms.Button();
            this.clearlast = new System.Windows.Forms.Button();
            this.sgn = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 433);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "scientific";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(11, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 46);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.nullcase);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(11, 271);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(46, 48);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(166, 271);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(46, 48);
            this.times.TabIndex = 5;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(167, 325);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 48);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(11, 325);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(46, 48);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(115, 325);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(46, 48);
            this.three.TabIndex = 8;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(63, 325);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(46, 48);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(218, 325);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(55, 102);
            this.equals.TabIndex = 10;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(166, 379);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 48);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(11, 379);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(98, 48);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // deciml
            // 
            this.deciml.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deciml.Location = new System.Drawing.Point(115, 379);
            this.deciml.Name = "deciml";
            this.deciml.Size = new System.Drawing.Size(46, 48);
            this.deciml.TabIndex = 13;
            this.deciml.Tag = " ";
            this.deciml.Text = ".";
            this.deciml.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deciml.UseVisualStyleBackColor = true;
            this.deciml.Click += new System.EventHandler(this.deciml_Click);
            // 
            // memminus
            // 
            this.memminus.Location = new System.Drawing.Point(63, 109);
            this.memminus.Name = "memminus";
            this.memminus.Size = new System.Drawing.Size(46, 48);
            this.memminus.TabIndex = 14;
            this.memminus.Text = "Mem-";
            this.memminus.UseVisualStyleBackColor = true;
            this.memminus.Click += new System.EventHandler(this.memminus_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(11, 217);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(46, 48);
            this.seven.TabIndex = 15;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // memplus
            // 
            this.memplus.Location = new System.Drawing.Point(13, 109);
            this.memplus.Name = "memplus";
            this.memplus.Size = new System.Drawing.Size(46, 48);
            this.memplus.TabIndex = 16;
            this.memplus.Text = "Mem+";
            this.memplus.UseVisualStyleBackColor = true;
            this.memplus.Click += new System.EventHandler(this.memplus_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(114, 271);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(46, 48);
            this.six.TabIndex = 17;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(63, 271);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(46, 48);
            this.five.TabIndex = 18;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(63, 217);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(46, 48);
            this.eight.TabIndex = 19;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // over
            // 
            this.over.Location = new System.Drawing.Point(166, 217);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(46, 48);
            this.over.TabIndex = 20;
            this.over.Text = "/";
            this.over.UseVisualStyleBackColor = true;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(114, 217);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(46, 48);
            this.nine.TabIndex = 21;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(218, 217);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(55, 48);
            this.sqrt.TabIndex = 22;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(218, 271);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(55, 48);
            this.power.TabIndex = 23;
            this.power.Text = "x^y";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.presentage_Click);
            // 
            // memrecal
            // 
            this.memrecal.Location = new System.Drawing.Point(115, 109);
            this.memrecal.Name = "memrecal";
            this.memrecal.Size = new System.Drawing.Size(46, 48);
            this.memrecal.TabIndex = 24;
            this.memrecal.Text = "Mem recal";
            this.memrecal.UseVisualStyleBackColor = true;
            this.memrecal.Click += new System.EventHandler(this.memrecal_Click);
            // 
            // memclear
            // 
            this.memclear.Location = new System.Drawing.Point(219, 109);
            this.memclear.Name = "memclear";
            this.memclear.Size = new System.Drawing.Size(54, 48);
            this.memclear.TabIndex = 25;
            this.memclear.Text = "Mem cle";
            this.memclear.UseVisualStyleBackColor = true;
            this.memclear.Click += new System.EventHandler(this.memclear_Click);
            // 
            // memstore
            // 
            this.memstore.Location = new System.Drawing.Point(167, 109);
            this.memstore.Name = "memstore";
            this.memstore.Size = new System.Drawing.Size(46, 48);
            this.memstore.TabIndex = 26;
            this.memstore.Text = "mem store";
            this.memstore.UseVisualStyleBackColor = true;
            this.memstore.Click += new System.EventHandler(this.memstore_Click);
            // 
            // oneoverx
            // 
            this.oneoverx.Location = new System.Drawing.Point(11, 163);
            this.oneoverx.Name = "oneoverx";
            this.oneoverx.Size = new System.Drawing.Size(46, 48);
            this.oneoverx.TabIndex = 27;
            this.oneoverx.Text = "1/x";
            this.oneoverx.UseVisualStyleBackColor = true;
            this.oneoverx.Click += new System.EventHandler(this.oneoverx_Click);
            // 
            // clearlall
            // 
            this.clearlall.Location = new System.Drawing.Point(63, 163);
            this.clearlall.Name = "clearlall";
            this.clearlall.Size = new System.Drawing.Size(46, 48);
            this.clearlall.TabIndex = 28;
            this.clearlall.Text = "CE";
            this.clearlall.UseVisualStyleBackColor = true;
            this.clearlall.Click += new System.EventHandler(this.clearlall_Click);
            // 
            // clearlast
            // 
            this.clearlast.Location = new System.Drawing.Point(115, 163);
            this.clearlast.Name = "clearlast";
            this.clearlast.Size = new System.Drawing.Size(46, 48);
            this.clearlast.TabIndex = 29;
            this.clearlast.Text = "C";
            this.clearlast.UseVisualStyleBackColor = true;
            // 
            // sgn
            // 
            this.sgn.Location = new System.Drawing.Point(167, 163);
            this.sgn.Name = "sgn";
            this.sgn.Size = new System.Drawing.Size(46, 48);
            this.sgn.TabIndex = 30;
            this.sgn.Text = "sgn";
            this.sgn.UseVisualStyleBackColor = true;
            this.sgn.Click += new System.EventHandler(this.sgn_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(218, 163);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(55, 48);
            this.backspace.TabIndex = 31;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(260, 25);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 462);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.sgn);
            this.Controls.Add(this.clearlast);
            this.Controls.Add(this.clearlall);
            this.Controls.Add(this.oneoverx);
            this.Controls.Add(this.memstore);
            this.Controls.Add(this.memclear);
            this.Controls.Add(this.memrecal);
            this.Controls.Add(this.power);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.over);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.memplus);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.memminus);
            this.Controls.Add(this.deciml);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.times);
            this.Controls.Add(this.four);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button deciml;
        private System.Windows.Forms.Button memminus;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button memplus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button over;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button memrecal;
        private System.Windows.Forms.Button memclear;
        private System.Windows.Forms.Button memstore;
        private System.Windows.Forms.Button oneoverx;
        private System.Windows.Forms.Button clearlall;
        private System.Windows.Forms.Button clearlast;
        private System.Windows.Forms.Button sgn;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.TextBox textBox2;
    }
}

