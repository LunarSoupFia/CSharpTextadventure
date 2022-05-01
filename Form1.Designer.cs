
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
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.Black;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(270, 165);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(563, 365);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "Output";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(270, 588);
            this.inputbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(564, 31);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "Eingabe";
            this.inputbox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 657);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "text command help sheet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // questBox
            // 
            this.questBox.Location = new System.Drawing.Point(18, 165);
            this.questBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.questBox.Multiline = true;
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(242, 366);
            this.questBox.TabIndex = 3;
            this.questBox.TextChanged += new System.EventHandler(this.questBox_TextChanged);
            // 
            // questheader
            // 
            this.questheader.AutoSize = true;
            this.questheader.BackColor = System.Drawing.Color.Transparent;
            this.questheader.ForeColor = System.Drawing.Color.White;
            this.questheader.Location = new System.Drawing.Point(18, 130);
            this.questheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questheader.Name = "questheader";
            this.questheader.Size = new System.Drawing.Size(59, 25);
            this.questheader.TabIndex = 4;
            this.questheader.Text = "label2";
            this.questheader.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(242, 105);
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
            this.action1.Location = new System.Drawing.Point(18, 682);
            this.action1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(74, 25);
            this.action1.TabIndex = 6;
            this.action1.Text = "gehe zu";
            this.action1.Click += new System.EventHandler(this.action1_Click);
            // 
            // action2
            // 
            this.action2.AutoSize = true;
            this.action2.BackColor = System.Drawing.Color.Transparent;
            this.action2.ForeColor = System.Drawing.Color.White;
            this.action2.Location = new System.Drawing.Point(96, 681);
            this.action2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(75, 25);
            this.action2.TabIndex = 7;
            this.action2.Text = "benutze";
            this.action2.Click += new System.EventHandler(this.action2_Click);
            // 
            // action3
            // 
            this.action3.AutoSize = true;
            this.action3.BackColor = System.Drawing.Color.Transparent;
            this.action3.ForeColor = System.Drawing.Color.White;
            this.action3.Location = new System.Drawing.Point(175, 681);
            this.action3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action3.Name = "action3";
            this.action3.Size = new System.Drawing.Size(95, 25);
            this.action3.TabIndex = 8;
            this.action3.Text = "frage nach";
            this.action3.Click += new System.EventHandler(this.action3_Click_1);
            // 
            // action4
            // 
            this.action4.AutoSize = true;
            this.action4.BackColor = System.Drawing.Color.Transparent;
            this.action4.ForeColor = System.Drawing.Color.White;
            this.action4.Location = new System.Drawing.Point(274, 682);
            this.action4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action4.Name = "action4";
            this.action4.Size = new System.Drawing.Size(54, 25);
            this.action4.TabIndex = 9;
            this.action4.Text = "fliehe";
            this.action4.Click += new System.EventHandler(this.action4_Click);
            // 
            // action5
            // 
            this.action5.AutoSize = true;
            this.action5.BackColor = System.Drawing.Color.Transparent;
            this.action5.ForeColor = System.Drawing.Color.White;
            this.action5.Location = new System.Drawing.Point(332, 681);
            this.action5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action5.Name = "action5";
            this.action5.Size = new System.Drawing.Size(92, 25);
            this.action5.TabIndex = 10;
            this.action5.Text = "bekämpfe";
            this.action5.Click += new System.EventHandler(this.action5_Click);
            // 
            // action6
            // 
            this.action6.AutoSize = true;
            this.action6.BackColor = System.Drawing.Color.Transparent;
            this.action6.ForeColor = System.Drawing.Color.White;
            this.action6.Location = new System.Drawing.Point(428, 681);
            this.action6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.action6.Name = "action6";
            this.action6.Size = new System.Drawing.Size(65, 25);
            this.action6.TabIndex = 11;
            this.action6.Text = "drücke";
            this.action6.Click += new System.EventHandler(this.action6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 750);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

