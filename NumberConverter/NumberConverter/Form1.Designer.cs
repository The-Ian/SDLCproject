namespace NumberConverter
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
            this.resultOutput = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericTypeEntryCB = new System.Windows.Forms.ComboBox();
            this.numericTypeResultCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversion Result:";
            // 
            // resultOutput
            // 
            this.resultOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultOutput.Location = new System.Drawing.Point(135, 206);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(100, 23);
            this.resultOutput.TabIndex = 2;
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(135, 77);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(100, 20);
            this.numberTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericTypeEntryCB
            // 
            this.numericTypeEntryCB.FormattingEnabled = true;
            this.numericTypeEntryCB.Items.AddRange(new object[] {
            "Arabic",
            "Roman Numerals",
            "Binary",
            "Hexadecimal"});
            this.numericTypeEntryCB.Location = new System.Drawing.Point(135, 50);
            this.numericTypeEntryCB.Name = "numericTypeEntryCB";
            this.numericTypeEntryCB.Size = new System.Drawing.Size(121, 21);
            this.numericTypeEntryCB.TabIndex = 5;
            // 
            // numericTypeResultCB
            // 
            this.numericTypeResultCB.FormattingEnabled = true;
            this.numericTypeResultCB.Items.AddRange(new object[] {
            "Arabic",
            "Roman Numerals",
            "Binary",
            "Hexadecimal"});
            this.numericTypeResultCB.Location = new System.Drawing.Point(135, 182);
            this.numericTypeResultCB.Name = "numericTypeResultCB";
            this.numericTypeResultCB.Size = new System.Drawing.Size(121, 21);
            this.numericTypeResultCB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numeric Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numeric Type:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(175, 292);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(292, 327);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericTypeResultCB);
            this.Controls.Add(this.numericTypeEntryCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numeric Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultOutput;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox numericTypeEntryCB;
        private System.Windows.Forms.ComboBox numericTypeResultCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearBtn;
    }
}

