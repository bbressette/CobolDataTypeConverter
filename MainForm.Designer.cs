namespace CobolDataTypeConverter
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
            this.txtRawPic = new System.Windows.Forms.TextBox();
            this.txtOutPic = new System.Windows.Forms.TextBox();
            this.txtRawValue = new System.Windows.Forms.TextBox();
            this.txtOutValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRawPic
            // 
            this.txtRawPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtRawPic.Location = new System.Drawing.Point(243, 66);
            this.txtRawPic.Name = "txtRawPic";
            this.txtRawPic.ReadOnly = true;
            this.txtRawPic.Size = new System.Drawing.Size(203, 34);
            this.txtRawPic.TabIndex = 0;
            // 
            // txtOutPic
            // 
            this.txtOutPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOutPic.Location = new System.Drawing.Point(243, 110);
            this.txtOutPic.Name = "txtOutPic";
            this.txtOutPic.ReadOnly = true;
            this.txtOutPic.Size = new System.Drawing.Size(203, 34);
            this.txtOutPic.TabIndex = 1;
            // 
            // txtRawValue
            // 
            this.txtRawValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtRawValue.Location = new System.Drawing.Point(577, 66);
            this.txtRawValue.Name = "txtRawValue";
            this.txtRawValue.ReadOnly = true;
            this.txtRawValue.Size = new System.Drawing.Size(203, 34);
            this.txtRawValue.TabIndex = 2;
            // 
            // txtOutValue
            // 
            this.txtOutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOutValue.Location = new System.Drawing.Point(577, 110);
            this.txtOutValue.Name = "txtOutValue";
            this.txtOutValue.Size = new System.Drawing.Size(203, 34);
            this.txtOutValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Record the result if RAW-DATA was moved to OUT-DATA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "01 RAW-DATA PIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(470, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "VALUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(786, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(14, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "01 OUT-DATA PIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(470, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "VALUE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(786, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = ".";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmit.Location = new System.Drawing.Point(577, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(203, 43);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNewQuestion.Location = new System.Drawing.Point(17, 160);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(429, 42);
            this.btnNewQuestion.TabIndex = 12;
            this.btnNewQuestion.Text = "Generate New Question";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 227);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutValue);
            this.Controls.Add(this.txtRawValue);
            this.Controls.Add(this.txtOutPic);
            this.Controls.Add(this.txtRawPic);
            this.Name = "MainForm";
            this.Text = "Cobol Data Type Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRawPic;
        private System.Windows.Forms.TextBox txtOutPic;
        private System.Windows.Forms.TextBox txtRawValue;
        private System.Windows.Forms.TextBox txtOutValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNewQuestion;
    }
}

