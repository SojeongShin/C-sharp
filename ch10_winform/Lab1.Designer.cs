
namespace ControlTest_final
{
    partial class Lab1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbOutName = new System.Windows.Forms.Label();
            this.lbOutAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtOutName = new System.Windows.Forms.TextBox();
            this.txtOutAge = new System.Windows.Forms.TextBox();
            this.lbPopName = new System.Windows.Forms.Label();
            this.lbPopAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(119, 221);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "전송하기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(39, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 15);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "이름";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(39, 162);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(31, 15);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "나이";
            // 
            // lbOutName
            // 
            this.lbOutName.AutoSize = true;
            this.lbOutName.Location = new System.Drawing.Point(39, 298);
            this.lbOutName.Name = "lbOutName";
            this.lbOutName.Size = new System.Drawing.Size(71, 15);
            this.lbOutName.TabIndex = 3;
            this.lbOutName.Text = "입력한 이름";
            // 
            // lbOutAge
            // 
            this.lbOutAge.AutoSize = true;
            this.lbOutAge.Location = new System.Drawing.Point(39, 377);
            this.lbOutAge.Name = "lbOutAge";
            this.lbOutAge.Size = new System.Drawing.Size(71, 15);
            this.lbOutAge.TabIndex = 4;
            this.lbOutAge.Text = "입력한 나이";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(149, 159);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 23);
            this.txtAge.TabIndex = 6;
            // 
            // txtOutName
            // 
            this.txtOutName.Location = new System.Drawing.Point(149, 295);
            this.txtOutName.Name = "txtOutName";
            this.txtOutName.Size = new System.Drawing.Size(100, 23);
            this.txtOutName.TabIndex = 7;
            // 
            // txtOutAge
            // 
            this.txtOutAge.Location = new System.Drawing.Point(149, 374);
            this.txtOutAge.Name = "txtOutAge";
            this.txtOutAge.Size = new System.Drawing.Size(100, 23);
            this.txtOutAge.TabIndex = 8;
            // 
            // lbPopName
            // 
            this.lbPopName.AutoSize = true;
            this.lbPopName.Location = new System.Drawing.Point(303, 199);
            this.lbPopName.Name = "lbPopName";
            this.lbPopName.Size = new System.Drawing.Size(0, 15);
            this.lbPopName.TabIndex = 9;
            // 
            // lbPopAge
            // 
            this.lbPopAge.AutoSize = true;
            this.lbPopAge.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPopAge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPopAge.Location = new System.Drawing.Point(303, 253);
            this.lbPopAge.Name = "lbPopAge";
            this.lbPopAge.Size = new System.Drawing.Size(0, 28);
            this.lbPopAge.TabIndex = 10;
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lbPopAge);
            this.Controls.Add(this.lbPopName);
            this.Controls.Add(this.txtOutAge);
            this.Controls.Add(this.txtOutName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbOutAge);
            this.Controls.Add(this.lbOutName);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnSend);
            this.Name = "Lab1";
            this.Text = "Lab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbOutName;
        private System.Windows.Forms.Label lbOutAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtOutName;
        private System.Windows.Forms.TextBox txtOutAge;
        private System.Windows.Forms.Label lbPopName;
        private System.Windows.Forms.Label lbPopAge;
        
    }
}