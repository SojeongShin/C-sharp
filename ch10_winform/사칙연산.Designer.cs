
namespace ControlTest_final
{
    partial class 사칙연산
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(38, 41);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(15, 15);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(38, 99);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(14, 15);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(37, 157);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(51, 15);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Result is";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(10, 208);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(103, 208);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultply
            // 
            this.btnMultply.Location = new System.Drawing.Point(201, 208);
            this.btnMultply.Name = "btnMultply";
            this.btnMultply.Size = new System.Drawing.Size(75, 23);
            this.btnMultply.TabIndex = 5;
            this.btnMultply.Text = "*";
            this.btnMultply.UseVisualStyleBackColor = true;
            this.btnMultply.Click += new System.EventHandler(this.btnMultply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(297, 208);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(147, 33);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(52, 23);
            this.txtA.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(147, 91);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(52, 23);
            this.txtB.TabIndex = 8;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(147, 154);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(52, 23);
            this.txtRes.TabIndex = 9;
            // 
            // 사칙연산
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Name = "사칙연산";
            this.Text = "사칙연산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtRes;
    }
}