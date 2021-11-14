
namespace ssj_가위바위보
{
    partial class ssj_가위바위보
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ssj_가위바위보));
            this.btnGawei = new System.Windows.Forms.Button();
            this.btnBawei = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.lbCom = new System.Windows.Forms.Label();
            this.lbMe = new System.Windows.Forms.Label();
            this.lbMeRes = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.timerViewResult = new System.Windows.Forms.Timer(this.components);
            this.btnViewRes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMeScore = new System.Windows.Forms.Label();
            this.lbComScore = new System.Windows.Forms.Label();
            this.lbDrawScore = new System.Windows.Forms.Label();
            this.lbTotalCnt = new System.Windows.Forms.Label();
            this.lbComR = new System.Windows.Forms.Label();
            this.lbComS = new System.Windows.Forms.Label();
            this.lbMeS = new System.Windows.Forms.Label();
            this.lbMeR = new System.Windows.Forms.Label();
            this.lbMeP = new System.Windows.Forms.Label();
            this.lbComP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbMe3 = new System.Windows.Forms.Label();
            this.lbMe1 = new System.Windows.Forms.Label();
            this.lbMe2 = new System.Windows.Forms.Label();
            this.lbCom1 = new System.Windows.Forms.Label();
            this.lbCom2 = new System.Windows.Forms.Label();
            this.lbCom3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGawei
            // 
            this.btnGawei.Font = new System.Drawing.Font("굴림", 15F);
            this.btnGawei.ForeColor = System.Drawing.Color.Red;
            this.btnGawei.Image = ((System.Drawing.Image)(resources.GetObject("btnGawei.Image")));
            this.btnGawei.Location = new System.Drawing.Point(12, 254);
            this.btnGawei.Name = "btnGawei";
            this.btnGawei.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGawei.Size = new System.Drawing.Size(95, 85);
            this.btnGawei.TabIndex = 0;
            this.btnGawei.Text = "가위";
            this.btnGawei.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGawei.UseVisualStyleBackColor = true;
            this.btnGawei.Click += new System.EventHandler(this.btnGawei_Click);
            // 
            // btnBawei
            // 
            this.btnBawei.Font = new System.Drawing.Font("굴림", 15F);
            this.btnBawei.ForeColor = System.Drawing.Color.Red;
            this.btnBawei.Image = ((System.Drawing.Image)(resources.GetObject("btnBawei.Image")));
            this.btnBawei.Location = new System.Drawing.Point(128, 254);
            this.btnBawei.Name = "btnBawei";
            this.btnBawei.Size = new System.Drawing.Size(95, 85);
            this.btnBawei.TabIndex = 1;
            this.btnBawei.Text = "바위";
            this.btnBawei.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBawei.UseVisualStyleBackColor = true;
            this.btnBawei.Click += new System.EventHandler(this.btnBawei_Click);
            // 
            // btnBo
            // 
            this.btnBo.Font = new System.Drawing.Font("굴림", 15F);
            this.btnBo.ForeColor = System.Drawing.Color.Red;
            this.btnBo.Image = ((System.Drawing.Image)(resources.GetObject("btnBo.Image")));
            this.btnBo.Location = new System.Drawing.Point(245, 254);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(95, 85);
            this.btnBo.TabIndex = 2;
            this.btnBo.Text = "보";
            this.btnBo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Font = new System.Drawing.Font("굴림", 12F);
            this.lbCom.Location = new System.Drawing.Point(34, 50);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(29, 20);
            this.lbCom.TabIndex = 3;
            this.lbCom.Text = "컴";
            // 
            // lbMe
            // 
            this.lbMe.AutoSize = true;
            this.lbMe.Font = new System.Drawing.Font("굴림", 12F);
            this.lbMe.Location = new System.Drawing.Point(34, 157);
            this.lbMe.Name = "lbMe";
            this.lbMe.Size = new System.Drawing.Size(29, 20);
            this.lbMe.TabIndex = 4;
            this.lbMe.Text = "나";
            // 
            // lbMeRes
            // 
            this.lbMeRes.AutoSize = true;
            this.lbMeRes.Font = new System.Drawing.Font("굴림", 15F);
            this.lbMeRes.ForeColor = System.Drawing.Color.Blue;
            this.lbMeRes.Location = new System.Drawing.Point(240, 152);
            this.lbMeRes.Name = "lbMeRes";
            this.lbMeRes.Size = new System.Drawing.Size(62, 25);
            this.lbMeRes.TabIndex = 5;
            this.lbMeRes.Text = "결과";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(91, 34);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(91, 141);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 50);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            // 
            // timerViewResult
            // 
            this.timerViewResult.Tick += new System.EventHandler(this.timerViewResult_Tick);
            // 
            // btnViewRes
            // 
            this.btnViewRes.Location = new System.Drawing.Point(229, 47);
            this.btnViewRes.Name = "btnViewRes";
            this.btnViewRes.Size = new System.Drawing.Size(101, 23);
            this.btnViewRes.TabIndex = 8;
            this.btnViewRes.Text = "결과보기>>";
            this.btnViewRes.UseVisualStyleBackColor = true;
            this.btnViewRes.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCom3);
            this.groupBox1.Controls.Add(this.lbCom2);
            this.groupBox1.Controls.Add(this.lbCom1);
            this.groupBox1.Controls.Add(this.lbMe2);
            this.groupBox1.Controls.Add(this.lbMe1);
            this.groupBox1.Controls.Add(this.lbMe3);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lb4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbComP);
            this.groupBox1.Controls.Add(this.lbMeP);
            this.groupBox1.Controls.Add(this.lbMeR);
            this.groupBox1.Controls.Add(this.lbMeS);
            this.groupBox1.Controls.Add(this.lbComS);
            this.groupBox1.Controls.Add(this.lbComR);
            this.groupBox1.Controls.Add(this.lbTotalCnt);
            this.groupBox1.Controls.Add(this.lbDrawScore);
            this.groupBox1.Controls.Add(this.lbComScore);
            this.groupBox1.Controls.Add(this.lbMeScore);
            this.groupBox1.Location = new System.Drawing.Point(360, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 327);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "게임결과";
            // 
            // lbMeScore
            // 
            this.lbMeScore.AutoSize = true;
            this.lbMeScore.Location = new System.Drawing.Point(16, 39);
            this.lbMeScore.Name = "lbMeScore";
            this.lbMeScore.Size = new System.Drawing.Size(107, 15);
            this.lbMeScore.TabIndex = 0;
            this.lbMeScore.Text = "내가 이긴 횟수";
            // 
            // lbComScore
            // 
            this.lbComScore.AutoSize = true;
            this.lbComScore.Location = new System.Drawing.Point(16, 73);
            this.lbComScore.Name = "lbComScore";
            this.lbComScore.Size = new System.Drawing.Size(107, 15);
            this.lbComScore.TabIndex = 1;
            this.lbComScore.Text = "컴이 이긴 횟수";
            // 
            // lbDrawScore
            // 
            this.lbDrawScore.AutoSize = true;
            this.lbDrawScore.Location = new System.Drawing.Point(16, 107);
            this.lbDrawScore.Name = "lbDrawScore";
            this.lbDrawScore.Size = new System.Drawing.Size(107, 15);
            this.lbDrawScore.TabIndex = 2;
            this.lbDrawScore.Text = "서로 비긴 횟수";
            // 
            // lbTotalCnt
            // 
            this.lbTotalCnt.AutoSize = true;
            this.lbTotalCnt.Location = new System.Drawing.Point(16, 140);
            this.lbTotalCnt.Name = "lbTotalCnt";
            this.lbTotalCnt.Size = new System.Drawing.Size(92, 15);
            this.lbTotalCnt.TabIndex = 3;
            this.lbTotalCnt.Text = "총 게임 횟수";
            // 
            // lbComR
            // 
            this.lbComR.AutoSize = true;
            this.lbComR.Location = new System.Drawing.Point(151, 265);
            this.lbComR.Name = "lbComR";
            this.lbComR.Size = new System.Drawing.Size(57, 15);
            this.lbComR.TabIndex = 4;
            this.lbComR.Text = "바위 수";
            // 
            // lbComS
            // 
            this.lbComS.AutoSize = true;
            this.lbComS.Location = new System.Drawing.Point(151, 226);
            this.lbComS.Name = "lbComS";
            this.lbComS.Size = new System.Drawing.Size(57, 15);
            this.lbComS.TabIndex = 5;
            this.lbComS.Text = "가위 수";
            // 
            // lbMeS
            // 
            this.lbMeS.AutoSize = true;
            this.lbMeS.Location = new System.Drawing.Point(25, 226);
            this.lbMeS.Name = "lbMeS";
            this.lbMeS.Size = new System.Drawing.Size(57, 15);
            this.lbMeS.TabIndex = 6;
            this.lbMeS.Text = "가위 수";
            // 
            // lbMeR
            // 
            this.lbMeR.AutoSize = true;
            this.lbMeR.Location = new System.Drawing.Point(25, 265);
            this.lbMeR.Name = "lbMeR";
            this.lbMeR.Size = new System.Drawing.Size(57, 15);
            this.lbMeR.TabIndex = 7;
            this.lbMeR.Text = "바위 수";
            // 
            // lbMeP
            // 
            this.lbMeP.AutoSize = true;
            this.lbMeP.Location = new System.Drawing.Point(25, 299);
            this.lbMeP.Name = "lbMeP";
            this.lbMeP.Size = new System.Drawing.Size(42, 15);
            this.lbMeP.TabIndex = 8;
            this.lbMeP.Text = "보 수";
            // 
            // lbComP
            // 
            this.lbComP.AutoSize = true;
            this.lbComP.Location = new System.Drawing.Point(151, 299);
            this.lbComP.Name = "lbComP";
            this.lbComP.Size = new System.Drawing.Size(42, 15);
            this.lbComP.TabIndex = 9;
            this.lbComP.Text = "보 수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "나의";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "컴의";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "------------------------------";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(129, 140);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(0, 15);
            this.lb4.TabIndex = 12;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(129, 73);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 15);
            this.lb2.TabIndex = 13;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(129, 107);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(0, 15);
            this.lb3.TabIndex = 14;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(129, 39);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 15);
            this.lb1.TabIndex = 15;
            // 
            // lbMe3
            // 
            this.lbMe3.AutoSize = true;
            this.lbMe3.Location = new System.Drawing.Point(92, 299);
            this.lbMe3.Name = "lbMe3";
            this.lbMe3.Size = new System.Drawing.Size(0, 15);
            this.lbMe3.TabIndex = 16;
            // 
            // lbMe1
            // 
            this.lbMe1.AutoSize = true;
            this.lbMe1.Location = new System.Drawing.Point(92, 226);
            this.lbMe1.Name = "lbMe1";
            this.lbMe1.Size = new System.Drawing.Size(0, 15);
            this.lbMe1.TabIndex = 17;
            // 
            // lbMe2
            // 
            this.lbMe2.AutoSize = true;
            this.lbMe2.Location = new System.Drawing.Point(92, 265);
            this.lbMe2.Name = "lbMe2";
            this.lbMe2.Size = new System.Drawing.Size(0, 15);
            this.lbMe2.TabIndex = 18;
            // 
            // lbCom1
            // 
            this.lbCom1.AutoSize = true;
            this.lbCom1.Location = new System.Drawing.Point(214, 226);
            this.lbCom1.Name = "lbCom1";
            this.lbCom1.Size = new System.Drawing.Size(0, 15);
            this.lbCom1.TabIndex = 19;
            // 
            // lbCom2
            // 
            this.lbCom2.AutoSize = true;
            this.lbCom2.Location = new System.Drawing.Point(214, 265);
            this.lbCom2.Name = "lbCom2";
            this.lbCom2.Size = new System.Drawing.Size(0, 15);
            this.lbCom2.TabIndex = 20;
            // 
            // lbCom3
            // 
            this.lbCom3.AutoSize = true;
            this.lbCom3.Location = new System.Drawing.Point(214, 299);
            this.lbCom3.Name = "lbCom3";
            this.lbCom3.Size = new System.Drawing.Size(0, 15);
            this.lbCom3.TabIndex = 21;
            // 
            // ssj_가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewRes);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbMeRes);
            this.Controls.Add(this.lbMe);
            this.Controls.Add(this.lbCom);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnBawei);
            this.Controls.Add(this.btnGawei);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "ssj_가위바위보";
            this.Text = "ssj_가위바위보";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGawei;
        private System.Windows.Forms.Button btnBawei;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Label lbMe;
        private System.Windows.Forms.Label lbMeRes;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Timer timerViewResult;
        private System.Windows.Forms.Button btnViewRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbComP;
        private System.Windows.Forms.Label lbMeP;
        private System.Windows.Forms.Label lbMeR;
        private System.Windows.Forms.Label lbMeS;
        private System.Windows.Forms.Label lbComS;
        private System.Windows.Forms.Label lbComR;
        private System.Windows.Forms.Label lbTotalCnt;
        private System.Windows.Forms.Label lbDrawScore;
        private System.Windows.Forms.Label lbComScore;
        private System.Windows.Forms.Label lbMeScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lbCom3;
        private System.Windows.Forms.Label lbCom2;
        private System.Windows.Forms.Label lbCom1;
        private System.Windows.Forms.Label lbMe2;
        private System.Windows.Forms.Label lbMe1;
        private System.Windows.Forms.Label lbMe3;
    }
}

