
namespace Textadventure
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputBox = new System.Windows.Forms.TextBox();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questBox = new System.Windows.Forms.TextBox();
            this.questheader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.action1 = new System.Windows.Forms.Label();
            this.action2 = new System.Windows.Forms.Label();
            this.action3 = new System.Windows.Forms.Label();
            this.action4 = new System.Windows.Forms.Label();
            this.action5 = new System.Windows.Forms.Label();
            this.action6 = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.option4 = new System.Windows.Forms.Label();
            this.option5 = new System.Windows.Forms.Label();
            this.option6 = new System.Windows.Forms.Label();
            this.action7 = new System.Windows.Forms.Label();
            this.action8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.action9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.Black;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(351, 211);
            this.outputBox.Margin = new System.Windows.Forms.Padding(6);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(732, 467);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "Output";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(351, 753);
            this.inputbox.Margin = new System.Windows.Forms.Padding(6);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(732, 39);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "Eingabe";
            this.inputbox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            this.inputbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputbox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 841);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "text command help sheet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // questBox
            // 
            this.questBox.Location = new System.Drawing.Point(22, 211);
            this.questBox.Margin = new System.Windows.Forms.Padding(6);
            this.questBox.Multiline = true;
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(312, 467);
            this.questBox.TabIndex = 3;
            this.questBox.TextChanged += new System.EventHandler(this.questBox_TextChanged);
            // 
            // questheader
            // 
            this.questheader.AutoSize = true;
            this.questheader.BackColor = System.Drawing.Color.Transparent;
            this.questheader.ForeColor = System.Drawing.Color.White;
            this.questheader.Location = new System.Drawing.Point(22, 166);
            this.questheader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.questheader.Name = "questheader";
            this.questheader.Size = new System.Drawing.Size(78, 32);
            this.questheader.TabIndex = 4;
            this.questheader.Text = "label2";
            this.questheader.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(316, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tageszeit und Tag";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // action1
            // 
            this.action1.AutoSize = true;
            this.action1.BackColor = System.Drawing.Color.Transparent;
            this.action1.ForeColor = System.Drawing.Color.White;
            this.action1.Location = new System.Drawing.Point(22, 873);
            this.action1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(100, 32);
            this.action1.TabIndex = 6;
            this.action1.Text = "gehe zu";
            this.action1.Click += new System.EventHandler(this.action1_Click);
            // 
            // action2
            // 
            this.action2.AutoSize = true;
            this.action2.BackColor = System.Drawing.Color.Transparent;
            this.action2.ForeColor = System.Drawing.Color.White;
            this.action2.Location = new System.Drawing.Point(124, 873);
            this.action2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(101, 32);
            this.action2.TabIndex = 7;
            this.action2.Text = "benutze";
            this.action2.Click += new System.EventHandler(this.action2_Click);
            // 
            // action3
            // 
            this.action3.AutoSize = true;
            this.action3.BackColor = System.Drawing.Color.Transparent;
            this.action3.ForeColor = System.Drawing.Color.White;
            this.action3.Location = new System.Drawing.Point(227, 873);
            this.action3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action3.Name = "action3";
            this.action3.Size = new System.Drawing.Size(127, 32);
            this.action3.TabIndex = 8;
            this.action3.Text = "frage nach";
            this.action3.Click += new System.EventHandler(this.action3_Click);
            // 
            // action4
            // 
            this.action4.AutoSize = true;
            this.action4.BackColor = System.Drawing.Color.Transparent;
            this.action4.ForeColor = System.Drawing.Color.White;
            this.action4.Location = new System.Drawing.Point(357, 873);
            this.action4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action4.Name = "action4";
            this.action4.Size = new System.Drawing.Size(74, 32);
            this.action4.TabIndex = 9;
            this.action4.Text = "fliehe";
            this.action4.Click += new System.EventHandler(this.action4_Click);
            // 
            // action5
            // 
            this.action5.AutoSize = true;
            this.action5.BackColor = System.Drawing.Color.Transparent;
            this.action5.ForeColor = System.Drawing.Color.White;
            this.action5.Location = new System.Drawing.Point(433, 873);
            this.action5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action5.Name = "action5";
            this.action5.Size = new System.Drawing.Size(121, 32);
            this.action5.TabIndex = 10;
            this.action5.Text = "bekämpfe";
            this.action5.Click += new System.EventHandler(this.action5_Click);
            // 
            // action6
            // 
            this.action6.AutoSize = true;
            this.action6.BackColor = System.Drawing.Color.Transparent;
            this.action6.ForeColor = System.Drawing.Color.White;
            this.action6.Location = new System.Drawing.Point(552, 873);
            this.action6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action6.Name = "action6";
            this.action6.Size = new System.Drawing.Size(86, 32);
            this.action6.TabIndex = 11;
            this.action6.Text = "drücke";
            this.action6.Click += new System.EventHandler(this.action6_Click);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.BackColor = System.Drawing.Color.Transparent;
            this.option1.ForeColor = System.Drawing.Color.White;
            this.option1.Location = new System.Drawing.Point(22, 919);
            this.option1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(54, 32);
            this.option1.TabIndex = 12;
            this.option1.Text = "____";
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.BackColor = System.Drawing.Color.Transparent;
            this.option2.ForeColor = System.Drawing.Color.White;
            this.option2.Location = new System.Drawing.Point(143, 919);
            this.option2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(54, 32);
            this.option2.TabIndex = 13;
            this.option2.Text = "____";
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.BackColor = System.Drawing.Color.Transparent;
            this.option3.ForeColor = System.Drawing.Color.White;
            this.option3.Location = new System.Drawing.Point(264, 919);
            this.option3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(54, 32);
            this.option3.TabIndex = 14;
            this.option3.Text = "____";
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.BackColor = System.Drawing.Color.Transparent;
            this.option4.ForeColor = System.Drawing.Color.White;
            this.option4.Location = new System.Drawing.Point(385, 919);
            this.option4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(54, 32);
            this.option4.TabIndex = 15;
            this.option4.Text = "____";
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // option5
            // 
            this.option5.AutoSize = true;
            this.option5.BackColor = System.Drawing.Color.Transparent;
            this.option5.ForeColor = System.Drawing.Color.White;
            this.option5.Location = new System.Drawing.Point(506, 919);
            this.option5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(54, 32);
            this.option5.TabIndex = 16;
            this.option5.Text = "____";
            this.option5.Click += new System.EventHandler(this.option5_Click);
            // 
            // option6
            // 
            this.option6.AutoSize = true;
            this.option6.BackColor = System.Drawing.Color.Transparent;
            this.option6.ForeColor = System.Drawing.Color.White;
            this.option6.Location = new System.Drawing.Point(627, 919);
            this.option6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(54, 32);
            this.option6.TabIndex = 17;
            this.option6.Text = "____";
            this.option6.Click += new System.EventHandler(this.option6_Click);
            // 
            // action7
            // 
            this.action7.AutoSize = true;
            this.action7.BackColor = System.Drawing.Color.Transparent;
            this.action7.ForeColor = System.Drawing.Color.White;
            this.action7.Location = new System.Drawing.Point(639, 873);
            this.action7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action7.Name = "action7";
            this.action7.Size = new System.Drawing.Size(76, 32);
            this.action7.TabIndex = 18;
            this.action7.Text = "suche";
            this.action7.Click += new System.EventHandler(this.action7_Click);
            // 
            // action8
            // 
            this.action8.AutoSize = true;
            this.action8.BackColor = System.Drawing.Color.Transparent;
            this.action8.ForeColor = System.Drawing.Color.White;
            this.action8.Location = new System.Drawing.Point(717, 873);
            this.action8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action8.Name = "action8";
            this.action8.Size = new System.Drawing.Size(95, 32);
            this.action8.TabIndex = 19;
            this.action8.Text = "höre zu";
            this.action8.Click += new System.EventHandler(this.action8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 963);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "TRENNER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 963);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "TRENNER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(264, 963);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "TRENNER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(385, 963);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "TRENNER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(506, 963);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "TRENNER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(627, 963);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "TRENNER";
            // 
            // action9
            // 
            this.action9.AutoSize = true;
            this.action9.BackColor = System.Drawing.Color.Transparent;
            this.action9.ForeColor = System.Drawing.Color.White;
            this.action9.Location = new System.Drawing.Point(820, 873);
            this.action9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.action9.Name = "action9";
            this.action9.Size = new System.Drawing.Size(75, 32);
            this.action9.TabIndex = 26;
            this.action9.Text = "schau";
            this.action9.Click += new System.EventHandler(this.action9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1753, 1004);
            this.Controls.Add(this.action9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.action8);
            this.Controls.Add(this.action7);
            this.Controls.Add(this.option6);
            this.Controls.Add(this.option5);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.action6);
            this.Controls.Add(this.action5);
            this.Controls.Add(this.action4);
            this.Controls.Add(this.action3);
            this.Controls.Add(this.action2);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.questheader);
            this.Controls.Add(this.questBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.outputBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "C# Textadventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questBox;
        private System.Windows.Forms.Label questheader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label action1;
        private System.Windows.Forms.Label action2;
        private System.Windows.Forms.Label action3;
        private System.Windows.Forms.Label action4;
        private System.Windows.Forms.Label action5;
        private System.Windows.Forms.Label action6;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.Label option4;
        private System.Windows.Forms.Label option5;
        private System.Windows.Forms.Label option6;
        private System.Windows.Forms.Label action7;
        private System.Windows.Forms.Label action8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label action9;
    }
}

