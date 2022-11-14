namespace Simple_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(34, 51);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(320, 34);
            this.txt_result.TabIndex = 0;
            this.txt_result.Text = "0";
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(196, 222);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(88, 88);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(102, 222);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(88, 88);
            this.btn_8.TabIndex = 10;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(8, 222);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(88, 88);
            this.btn_7.TabIndex = 11;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(196, 316);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(88, 88);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(102, 316);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(88, 88);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(8, 316);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(88, 88);
            this.btn_4.TabIndex = 14;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(196, 410);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(88, 88);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(102, 410);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(88, 88);
            this.btn_2.TabIndex = 16;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(8, 410);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(88, 88);
            this.btn_1.TabIndex = 17;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(102, 504);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(88, 88);
            this.btn_0.TabIndex = 18;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(291, 504);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(88, 88);
            this.btn_equals.TabIndex = 19;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(291, 410);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(88, 88);
            this.btn_plus.TabIndex = 20;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(291, 316);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(88, 88);
            this.btn_minus.TabIndex = 21;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(290, 222);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(88, 88);
            this.btn_multiply.TabIndex = 22;
            this.btn_multiply.Text = "X";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(291, 128);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(88, 88);
            this.btn_divide.TabIndex = 23;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_Operator_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Location = new System.Drawing.Point(196, 128);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(88, 88);
            this.btn_backspace.TabIndex = 24;
            this.btn_backspace.Text = "<-";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(102, 128);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(88, 88);
            this.btn_c.TabIndex = 25;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Location = new System.Drawing.Point(8, 128);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(88, 88);
            this.btn_ce.TabIndex = 26;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 620);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.txt_result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_ce;
    }
}

