
namespace WindowsFormsApp1
{
    partial class FrmHomeWork
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
            this.btnLottory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCovert2 = new System.Windows.Forms.Button();
            this.btnContainCc = new System.Windows.Forms.Button();
            this.btnMaxStringArr = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn9Plus9Table = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnMaxMethod = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnGuessOddEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLottory
            // 
            this.btnLottory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLottory.Location = new System.Drawing.Point(785, 121);
            this.btnLottory.Margin = new System.Windows.Forms.Padding(2);
            this.btnLottory.Name = "btnLottory";
            this.btnLottory.Size = new System.Drawing.Size(159, 30);
            this.btnLottory.TabIndex = 104;
            this.btnLottory.Text = "int[] 樂透 6個號碼不重複";
            this.btnLottory.UseVisualStyleBackColor = false;
            this.btnLottory.Click += new System.EventHandler(this.btnLottory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(123, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 27);
            this.label7.TabIndex = 101;
            this.label7.Text = "Result:";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button16.Location = new System.Drawing.Point(19, 192);
            this.button16.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(79, 27);
            this.button16.TabIndex = 100;
            this.button16.Text = "清空結果欄";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(123, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 27);
            this.label5.TabIndex = 99;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(69, 26);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(76, 22);
            this.txtNum.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 97;
            this.label6.Text = "Number:";
            // 
            // btnCovert2
            // 
            this.btnCovert2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCovert2.Location = new System.Drawing.Point(392, 61);
            this.btnCovert2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCovert2.Name = "btnCovert2";
            this.btnCovert2.Size = new System.Drawing.Size(136, 23);
            this.btnCovert2.TabIndex = 96;
            this.btnCovert2.Text = "100 的 二進位是多少 ?";
            this.btnCovert2.UseVisualStyleBackColor = false;
            this.btnCovert2.Click += new System.EventHandler(this.btnCovert2_Click);
            // 
            // btnContainCc
            // 
            this.btnContainCc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContainCc.Location = new System.Drawing.Point(532, 113);
            this.btnContainCc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnContainCc.Name = "btnContainCc";
            this.btnContainCc.Size = new System.Drawing.Size(236, 39);
            this.btnContainCc.TabIndex = 95;
            this.btnContainCc.Text = "string[] 名字有 “C” or “c” 字樣有幾個 ";
            this.btnContainCc.UseVisualStyleBackColor = false;
            this.btnContainCc.Click += new System.EventHandler(this.btnContainCc_Click);
            // 
            // btnMaxStringArr
            // 
            this.btnMaxStringArr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaxStringArr.Location = new System.Drawing.Point(546, 64);
            this.btnMaxStringArr.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMaxStringArr.Name = "btnMaxStringArr";
            this.btnMaxStringArr.Size = new System.Drawing.Size(209, 28);
            this.btnMaxStringArr.TabIndex = 94;
            this.btnMaxStringArr.Text = "string[] 最長名字 ?";
            this.btnMaxStringArr.UseVisualStyleBackColor = false;
            this.btnMaxStringArr.Click += new System.EventHandler(this.btnMaxStringArr_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(211, 189);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 34);
            this.lblResult.TabIndex = 93;
            this.lblResult.Text = "結果";
            // 
            // btn9Plus9Table
            // 
            this.btn9Plus9Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn9Plus9Table.Location = new System.Drawing.Point(392, 24);
            this.btn9Plus9Table.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn9Plus9Table.Name = "btn9Plus9Table";
            this.btn9Plus9Table.Size = new System.Drawing.Size(117, 23);
            this.btn9Plus9Table.TabIndex = 92;
            this.btn9Plus9Table.Text = "九九乘法表";
            this.btn9Plus9Table.UseVisualStyleBackColor = false;
            this.btn9Plus9Table.Click += new System.EventHandler(this.btn9Plus9Table_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDoWhile.Location = new System.Drawing.Point(312, 101);
            this.btnDoWhile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(56, 21);
            this.btnDoWhile.TabIndex = 91;
            this.btnDoWhile.Text = "do";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWhile.Location = new System.Drawing.Point(312, 64);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(56, 20);
            this.btnWhile.TabIndex = 90;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFor.Location = new System.Drawing.Point(312, 25);
            this.btnFor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(56, 24);
            this.btnFor.TabIndex = 89;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(167, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 88;
            this.label3.Text = "Step:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(178, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 87;
            this.label2.Text = "to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 86;
            this.label1.Text = "from:";
            // 
            // txtStep
            // 
            this.txtStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStep.Location = new System.Drawing.Point(211, 96);
            this.txtStep.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(76, 22);
            this.txtStep.TabIndex = 85;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTo.Location = new System.Drawing.Point(211, 58);
            this.txtTo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(76, 22);
            this.txtTo.TabIndex = 84;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFrom.Location = new System.Drawing.Point(211, 25);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(76, 22);
            this.txtFrom.TabIndex = 83;
            // 
            // btnOddEven
            // 
            this.btnOddEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOddEven.Location = new System.Drawing.Point(546, 21);
            this.btnOddEven.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(209, 28);
            this.btnOddEven.TabIndex = 78;
            this.btnOddEven.Text = "int[] 統計 奇數 有幾個 , 偶數有幾個";
            this.btnOddEven.UseVisualStyleBackColor = false;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaxMin.Location = new System.Drawing.Point(785, 61);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(159, 28);
            this.btnMaxMin.TabIndex = 77;
            this.btnMaxMin.Text = " MAX()   / Min ( int[] )";
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnMaxMethod
            // 
            this.btnMaxMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaxMethod.Location = new System.Drawing.Point(785, 14);
            this.btnMaxMethod.Name = "btnMaxMethod";
            this.btnMaxMethod.Size = new System.Drawing.Size(152, 28);
            this.btnMaxMethod.TabIndex = 76;
            this.btnMaxMethod.Text = "Max (params int[] )";
            this.btnMaxMethod.UseVisualStyleBackColor = false;
            this.btnMaxMethod.Click += new System.EventHandler(this.btnMaxMethod_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMax.Location = new System.Drawing.Point(29, 99);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(116, 23);
            this.btnMax.TabIndex = 74;
            this.btnMax.Text = "3 個數的最大值";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnGuessOddEven
            // 
            this.btnGuessOddEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuessOddEven.Location = new System.Drawing.Point(29, 73);
            this.btnGuessOddEven.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGuessOddEven.Name = "btnGuessOddEven";
            this.btnGuessOddEven.Size = new System.Drawing.Size(116, 21);
            this.btnGuessOddEven.TabIndex = 73;
            this.btnGuessOddEven.Text = "Odd or Even";
            this.btnGuessOddEven.UseVisualStyleBackColor = false;
            this.btnGuessOddEven.Click += new System.EventHandler(this.btnGuessOddEven_Click);
            // 
            // FrmHomeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 439);
            this.Controls.Add(this.btnLottory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCovert2);
            this.Controls.Add(this.btnContainCc);
            this.Controls.Add(this.btnMaxStringArr);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn9Plus9Table);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnOddEven);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnMaxMethod);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnGuessOddEven);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHomeWork";
            this.Text = "HomeWork0408";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLottory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCovert2;
        private System.Windows.Forms.Button btnContainCc;
        private System.Windows.Forms.Button btnMaxStringArr;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn9Plus9Table;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnMaxMethod;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnGuessOddEven;
    }
}