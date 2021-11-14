using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 게임;

namespace ssj_가위바위보
{
    public partial class ssj_가위바위보 : Form
    {
        public ssj_가위바위보()
        {
            InitializeComponent();
        }

        bool resView;
        //  내가승         컴승          비김수
        int userCount = 0, comCount = 0, drawCount = 0;
        int usrS = 0, usrR = 0, usrP = 0;  // 나의 가위바위보 수
        int comS = 0, comR = 0, comP = 0;  // 컴의 가위바위보 수

        private void btnBo_Click(object sender, EventArgs e)
        {
            int myNum = 3;
            pb2.ImageLocation = "Images/bo.jpg";

            Random num = new Random();
            int comSu = num.Next(1, 4);  // 랜덤으로 컴 수 하나 지정
            switch (comSu)
            {
                case 1:
                    pb1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    pb1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    pb1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            string result = 가위바위보.CheckResult(myNum, comSu);
            lbMeRes.Text = result;

            가위바위보.ComCnt(ref comS, ref comR, ref comP, comSu);
            가위바위보.myCnt(ref usrS, ref usrR, ref usrP, myNum);
            가위바위보.Count(ref userCount, ref comCount, ref drawCount, result);

            int total = userCount + comCount + drawCount;

            lb1.Text = userCount.ToString();  // 내가 이긴 횟수
            lb2.Text = comCount.ToString();   // 컴이 이긴 횟수
            lb3.Text = drawCount.ToString();  // 비긴 횟수
            lb4.Text = total.ToString();      // 총 게임 진행 횟수

            lbMe1.Text = usrS.ToString();  // 나의 가위 횟수
            lbMe2.Text = usrR.ToString();  // 나의 바위 횟수
            lbMe3.Text = usrP.ToString();  // 나의 보 횟수

            lbCom1.Text = comS.ToString();  // 컴의 가위 횟수
            lbCom2.Text = comR.ToString();  // 컴의 바위 횟수
            lbCom3.Text = comP.ToString();  // 컴의 보 횟수
        }

        private void btnBawei_Click(object sender, EventArgs e)
        {
            int myNum = 2;
            pb2.ImageLocation = "Images/bawei.jpg";

            Random num = new Random();
            int comSu = num.Next(1, 4);  // 랜덤으로 컴 수 하나 지정
            switch (comSu)
            {
                case 1:
                    pb1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    pb1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    pb1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            string result = 가위바위보.CheckResult(myNum, comSu);
            lbMeRes.Text = result;

            가위바위보.ComCnt(ref comS, ref comR, ref comP, comSu);
            가위바위보.myCnt(ref usrS, ref usrR, ref usrP, myNum);
            가위바위보.Count(ref userCount, ref comCount, ref drawCount, result);

            int total = userCount + comCount + drawCount;

            lb1.Text = userCount.ToString();  // 내가 이긴 횟수
            lb2.Text = comCount.ToString();   // 컴이 이긴 횟수
            lb3.Text = drawCount.ToString();  // 비긴 횟수
            lb4.Text = total.ToString();      // 총 게임 진행 횟수

            lbMe1.Text = usrS.ToString();  // 나의 가위 횟수
            lbMe2.Text = usrR.ToString();  // 나의 바위 횟수
            lbMe3.Text = usrP.ToString();  // 나의 보 횟수

            lbCom1.Text = comS.ToString();  // 컴의 가위 횟수
            lbCom2.Text = comR.ToString();  // 컴의 바위 횟수
            lbCom3.Text = comP.ToString();  // 컴의 보 횟수
        }

        private void btnGawei_Click(object sender, EventArgs e)
        {
            int myNum = 1;
            pb2.ImageLocation = "Images/gawei.jpg";

            Random num = new Random();
            int comSu = num.Next(1, 4);  // 랜덤으로 컴 수 하나 지정
            switch (comSu)
            {
                case 1:
                    pb1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    pb1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    pb1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            string result = 가위바위보.CheckResult(myNum, comSu);
            lbMeRes.Text = result;

            가위바위보.ComCnt(ref comS, ref comR, ref comP, comSu);
            가위바위보.myCnt(ref usrS, ref usrR, ref usrP, myNum);
            가위바위보.Count(ref userCount, ref comCount, ref drawCount, result);

            int total = userCount + comCount + drawCount;

            lb1.Text = userCount.ToString();  // 내가 이긴 횟수
            lb2.Text = comCount.ToString();   // 컴이 이긴 횟수
            lb3.Text = drawCount.ToString();  // 비긴 횟수
            lb4.Text = total.ToString();      // 총 게임 진행 횟수

            lbMe1.Text = usrS.ToString();  // 나의 가위 횟수
            lbMe2.Text = usrR.ToString();  // 나의 바위 횟수
            lbMe3.Text = usrP.ToString();  // 나의 보 횟수

            lbCom1.Text = comS.ToString();  // 컴의 가위 횟수
            lbCom2.Text = comR.ToString();  // 컴의 바위 횟수
            lbCom3.Text = comP.ToString();  // 컴의 보 횟수
        }

        private void timerViewResult_Tick(object sender, EventArgs e)
        {
            int size = 20;
            if (!resView)
            {
                if(Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    resView = true;
                    btnViewRes.Text = "결과접기<<";
                    timerViewResult.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    resView = false;
                    btnViewRes.Text = "결과보기>>";
                    timerViewResult.Stop();
                }
                else
                {
                    Width -= size;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int myNum = 2;
            pb2.ImageLocation = "Images/bawei.jpg";

            Random num = new Random();
            int comSu = num.Next(1, 4);  // 랜덤으로 컴 수 하나 지정
            switch (comSu)
            {
                case 1:
                    pb1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    pb1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    pb1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            string result = 가위바위보.CheckResult(myNum, comSu);
            lbMeRes.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int myNum = 3;
            pb2.ImageLocation = "Images/bo.jpg";

            Random num = new Random();
            int comSu = num.Next(1, 4);  // 랜덤으로 컴 수 하나 지정
            switch (comSu)
            {
                case 1:
                    pb1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    pb1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    pb1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            string result = 가위바위보.CheckResult(myNum, comSu);
            lbMeRes.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timerViewResult.Start();
        }
    }
}
