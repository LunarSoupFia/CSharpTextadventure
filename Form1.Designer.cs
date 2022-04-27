
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.questheader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.action1 = new System.Windows.Forms.Label();
            this.action2 = new System.Windows.Forms.Label();
            this.action3 = new System.Windows.Forms.Label();
            this.action4 = new System.Windows.Forms.Label();
            this.action5 = new System.Windows.Forms.Label();
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
            this.outputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(351, 753);
            this.inputbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(732, 39);
            this.inputbox.TabIndex = 1;
            this.inputbox.Text = "Eingabe";
            this.inputbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 211);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(314, 467);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // questheader
            // 
            this.questheader.AutoSize = true;
            this.questheader.Location = new System.Drawing.Point(24, 166);
            this.questheader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.questheader.Name = "questheader";
            this.questheader.Size = new System.Drawing.Size(78, 32);
            this.questheader.TabIndex = 4;
            this.questheader.Text = "label2";
            this.questheader.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
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
            this.action1.Location = new System.Drawing.Point(24, 873);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(126, 32);
            this.action1.TabIndex = 6;
            this.action1.Text = "gehe nach";
            this.action1.Click += new System.EventHandler(this.action1_Click);
            // 
            // action2
            // 
            this.action2.AutoSize = true;
            this.action2.Location = new System.Drawing.Point(156, 873);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(101, 32);
            this.action2.TabIndex = 7;
            this.action2.Text = "benutze";
            this.action2.Click += new System.EventHandler(this.action2_Click);
            // 
            // action3
            // 
            this.action3.AutoSize = true;
            this.action3.Location = new System.Drawing.Point(263, 873);
            this.action3.Name = "action3";
            this.action3.Size = new System.Drawing.Size(133, 32);
            this.action3.TabIndex = 8;
            this.action3.Text = "untersuche";
            this.action3.Click += new System.EventHandler(this.action3_Click_1);
            // 
            // action4
            // 
            this.action4.AutoSize = true;
            this.action4.Location = new System.Drawing.Point(402, 873);
            this.action4.Name = "action4";
            this.action4.Size = new System.Drawing.Size(71, 32);
            this.action4.TabIndex = 9;
            this.action4.Text = "öffne";
            this.action4.Click += new System.EventHandler(this.action4_Click);
            // 
            // action5
            // 
            this.action5.AutoSize = true;
            this.action5.Location = new System.Drawing.Point(479, 873);
            this.action5.Name = "action5";
            this.action5.Size = new System.Drawing.Size(100, 32);
            this.action5.TabIndex = 10;
            this.action5.Text = "schließe";
            this.action5.Click += new System.EventHandler(this.action5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1485, 960);
            this.Controls.Add(this.action5);
            this.Controls.Add(this.action4);
            this.Controls.Add(this.action3);
            this.Controls.Add(this.action2);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.questheader);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label questheader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label action1;
        private System.Windows.Forms.Label action2;
        private System.Windows.Forms.Label action3;
        private System.Windows.Forms.Label action4;
        private System.Windows.Forms.Label action5;
    }
}

