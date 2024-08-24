namespace GiaiPhuongTrinh
{
    partial class GiaiPT
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            giai = new TabControl();
            tqrq = new TabPage();
            tabPage2 = new TabPage();
            labelDapAn = new Label();
            buttonGiai = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            textBoxA2 = new TextBox();
            textBoxB2 = new TextBox();
            textBoxC2 = new TextBox();
            giai.SuspendLayout();
            tqrq.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(524, 37);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc hai (ax^2+bx+c) = 0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 69);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 124);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(31, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 173);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(31, 27);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(56, 37);
            label2.TabIndex = 4;
            label2.Text = "a =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 114);
            label3.Name = "label3";
            label3.Size = new Size(58, 37);
            label3.TabIndex = 5;
            label3.Text = "b =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 163);
            label4.Name = "label4";
            label4.Size = new Size(54, 37);
            label4.TabIndex = 6;
            label4.Text = "c =";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(30, 240);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 59);
            button1.TabIndex = 7;
            button1.Text = "Giải";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 303);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Đáp án";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 345);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 9;
            // 
            // giai
            // 
            giai.Controls.Add(tqrq);
            giai.Controls.Add(tabPage2);
            giai.Location = new Point(-1, 1);
            giai.Name = "giai";
            giai.SelectedIndex = 0;
            giai.Size = new Size(914, 534);
            giai.TabIndex = 10;
            // 
            // tqrq
            // 
            tqrq.Controls.Add(button1);
            tqrq.Controls.Add(textBox3);
            tqrq.Controls.Add(label4);
            tqrq.Controls.Add(label6);
            tqrq.Controls.Add(label3);
            tqrq.Controls.Add(textBox2);
            tqrq.Controls.Add(label5);
            tqrq.Controls.Add(label2);
            tqrq.Controls.Add(label1);
            tqrq.Controls.Add(textBox1);
            tqrq.Location = new Point(4, 29);
            tqrq.Name = "tqrq";
            tqrq.Padding = new Padding(3);
            tqrq.Size = new Size(906, 501);
            tqrq.TabIndex = 0;
            tqrq.Text = "GiảiPT";
            tqrq.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxC2);
            tabPage2.Controls.Add(textBoxB2);
            tabPage2.Controls.Add(textBoxA2);
            tabPage2.Controls.Add(textBoxC);
            tabPage2.Controls.Add(textBoxB);
            tabPage2.Controls.Add(textBoxA);
            tabPage2.Controls.Add(labelDapAn);
            tabPage2.Controls.Add(buttonGiai);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 501);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hệ phương trình";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // labelDapAn
            // 
            labelDapAn.AutoSize = true;
            labelDapAn.Location = new Point(31, 306);
            labelDapAn.Name = "labelDapAn";
            labelDapAn.Size = new Size(57, 20);
            labelDapAn.TabIndex = 13;
            labelDapAn.Text = "Đáp án";
            // 
            // buttonGiai
            // 
            buttonGiai.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGiai.ForeColor = Color.Red;
            buttonGiai.Location = new Point(31, 227);
            buttonGiai.Margin = new Padding(3, 4, 3, 4);
            buttonGiai.Name = "buttonGiai";
            buttonGiai.Size = new Size(125, 59);
            buttonGiai.TabIndex = 12;
            buttonGiai.Text = "Giải";
            buttonGiai.UseVisualStyleBackColor = true;
            buttonGiai.Click += buttonGiai_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(243, 173);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 9;
            label11.Text = "y = ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(243, 108);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 8;
            label10.Text = "y = ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(157, 173);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 5;
            label9.Text = "x + ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 108);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 4;
            label8.Text = "x + ";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 33);
            label7.Name = "label7";
            label7.Size = new Size(263, 37);
            label7.TabIndex = 1;
            label7.Text = "Giải hệ phương trình";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(103, 108);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(30, 27);
            textBoxA.TabIndex = 14;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(197, 108);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(30, 27);
            textBoxB.TabIndex = 15;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(303, 108);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(30, 27);
            textBoxC.TabIndex = 16;
            // 
            // textBoxA2
            // 
            textBoxA2.Location = new Point(103, 173);
            textBoxA2.Name = "textBoxA2";
            textBoxA2.Size = new Size(30, 27);
            textBoxA2.TabIndex = 17;
            // 
            // textBoxB2
            // 
            textBoxB2.Location = new Point(197, 173);
            textBoxB2.Name = "textBoxB2";
            textBoxB2.Size = new Size(30, 27);
            textBoxB2.TabIndex = 18;
            // 
            // textBoxC2
            // 
            textBoxC2.Location = new Point(303, 173);
            textBoxC2.Name = "textBoxC2";
            textBoxC2.Size = new Size(30, 27);
            textBoxC2.TabIndex = 19;
            // 
            // GiaiPT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 506);
            Controls.Add(giai);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GiaiPT";
            Text = "GiaiPT";
            Load += GiaiPT_Load;
            giai.ResumeLayout(false);
            tqrq.ResumeLayout(false);
            tqrq.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private TabControl giai;
        private TabPage tqrq;
        private TabPage tabPage2;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label labelDapAn;
        private Button buttonGiai;
        private TextBox textBoxC2;
        private TextBox textBoxB2;
        private TextBox textBoxA2;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private TextBox textBoxA;
    }
}
