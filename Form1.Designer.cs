
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.Black;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(351, 211);
            this.outputBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.inputbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.label1.Location = new System.Drawing.Point(23, 841);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "text command help sheet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // questBox
            // 
            this.questBox.Location = new System.Drawing.Point(23, 211);
            this.questBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.questBox.Multiline = true;
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(313, 467);
            this.questBox.TabIndex = 3;
            this.questBox.TextChanged += new System.EventHandler(this.questBox_TextChanged);
            // 
            // questheader
            // 
            this.questheader.AutoSize = true;
            this.questheader.BackColor = System.Drawing.Color.Transparent;
            this.questheader.ForeColor = System.Drawing.Color.White;
            this.questheader.Location = new System.Drawing.Point(23, 166);
            this.questheader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.questheader.Name = "questheader";
            this.questheader.Size = new System.Drawing.Size(78, 32);
            this.questheader.TabIndex = 4;
            this.questheader.Text = "label2";
            this.questheader.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(315, 134);
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
            this.action1.Location = new System.Drawing.Point(23, 873);
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
            this.action2.Location = new System.Drawing.Point(125, 872);
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
            this.action3.Location = new System.Drawing.Point(227, 872);
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
            this.action4.Location = new System.Drawing.Point(356, 873);
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
            this.action5.Location = new System.Drawing.Point(432, 872);
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
            this.action6.Location = new System.Drawing.Point(556, 872);
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
            this.option1.Location = new System.Drawing.Point(23, 919);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(54, 32);
            this.option1.TabIndex = 12;
            this.option1.Text = "____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 919);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 919);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 919);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(273, 919);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "____";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1485, 960);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

