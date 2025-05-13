﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace asl_project
{
    enum growState
    {
        BABY, CHILD, ADULT
    }

    public partial class MainWindow : Form
    {
        private int stat_hungry;
        private int stat_tired;
        private int stat_stress;
        private double stat_grow;
        private System.Windows.Forms.Button statusButton;
        private string characterName = "다마고치";

        private growState grow_state; //현재 성장 상태를 저장하는 변수 (유아기: BABY, 청년기: CHILD, 성년기: ADULT)
        public List<Label> Foodlabels;


        public MainWindow()
        {
            InitializeComponent();
            init_stat(false);


            Foodlabels = new List<Label> { withNoodlelbl, withRicelbl };
            FoodItem rice = new FoodItem(RicePBX, characterPBX, eatingRicech,  DecreaseHunger,
                    new List<PictureBox> { NoodlePBX }, Foodlabels);
            FoodItem noodle = new FoodItem(NoodlePBX, characterPBX, eatingNoodlech, DecreaseHunger,
                    new List<PictureBox> { RicePBX }, Foodlabels );

        }


        private void DecreaseHunger()
        {
            stat_hungry -= 10;
            MessageBox.Show("배고픔이 10 감소하였습니다.");

        }
        private void init_stat(bool restart)
        {
            if (!restart) //임시로 초기화해둠, 추후 이전에 플레이하던 값 가져오는 작업 필요
            {
                stat_hungry = 80;
                stat_tired = 80;
                stat_stress = 80;
                stat_grow = 0;
                grow_state = growState.ADULT;
            }
            else
            {
                stat_hungry = 0;
                stat_tired = 0;
                stat_stress = 0;
                stat_grow = 0;
                grow_state = growState.BABY;
            }

            lbH.Text = stat_hungry.ToString();
            lbTR.Text = stat_tired.ToString();
            lbST.Text = stat_stress.ToString();
            lbGrow.Text = stat_grow.ToString() + "%";
            lbGrowState.Text = get_state_string(grow_state);

            pgbH.Value = stat_hungry;
            pgbTR.Value = stat_tired;
            pgbST.Value = stat_stress;
            pgbGrow.Value = (int)stat_grow;

            if (!restart && (stat_hungry + stat_tired + stat_stress > 250)) die();

            tmrH.Start();
            tmrTR.Start();
            tmrST.Start();
            tmrGrow.Start();
        }

        //현재 성장 상태를 뜻하는 grow_state를 인자로 받아, 현재 성장 상태를 문자열로 반환
        private string get_state_string(growState grow_state)
        {
            if (grow_state == growState.BABY) return "유아";
            if (grow_state == growState.CHILD) return "청년";
            if (grow_state == growState.ADULT) return "성년";

            return "";
        }

        //change만큼 스탯 값 변경하는 메서드 (change에 양수, 음수 모두 가능)
        //set_hungry: 배고픔, set_tired: 피로도, set_stress: 스트레스 변경, 용도에 맞게 사용
        public void set_hungry(int change)
        {
            tmrH.Stop();
            stat_hungry += change;
            if (stat_hungry > 100) stat_hungry = 100;
            if (stat_hungry < 0) stat_hungry = 0;

            lbH.Text = stat_hungry.ToString();
            pgbH.Value = stat_hungry;
            tmrH.Start();
        }

        public void set_tired(int change)
        {
            tmrTR.Stop();
            stat_tired += change;
            if (stat_tired > 100) stat_tired = 100;
            if (stat_tired < 0) stat_tired = 0;

            lbTR.Text = stat_tired.ToString();
            pgbTR.Value = stat_tired;
            tmrTR.Start();
        }

        public void set_stress(int change)
        {
            tmrST.Stop();
            stat_stress += change;
            if (stat_stress > 100) stat_stress = 100;
            if (stat_stress < 0) stat_stress = 0;

            lbST.Text = stat_stress.ToString();
            pgbST.Value = stat_stress;
            tmrST.Start();
        }


        private void tmrH_Tick(object sender, EventArgs e)
        {
            if (stat_hungry == 100) return;
            stat_hungry++;
            lbH.Text = stat_hungry.ToString();
            pgbH.Value = stat_hungry;
        }

        private void tmrTR_Tick(object sender, EventArgs e)
        {
            if (stat_tired == 100) return;
            stat_tired++;
            lbTR.Text = stat_tired.ToString();
            pgbTR.Value = stat_tired;
        }

        private void tmrST_Tick(object sender, EventArgs e)
        {
            if (stat_stress == 100) return;
            stat_stress++;
            lbST.Text = stat_stress.ToString();
            pgbST.Value = stat_stress;
        }

        private void tmrGrow_Tick(object sender, EventArgs e)
        {
            if (stat_grow >= 100)
            {
                if (grow_state == growState.BABY)
                {
                    grow_state = growState.CHILD;
                    stat_grow = 0;
                }
                else if (grow_state == growState.CHILD)
                {
                    grow_state = growState.ADULT;
                    stat_grow = 0;
                    tmrH.Interval = 2400; //유아기에서 벗어낫으므로 배고픔 느리게 증가
                }
                else
                {
                    tmrGrow.Stop();
                    return;
                }

                lbGrowState.Text = get_state_string(grow_state);
            }
            else
            {
                stat_grow += 0.03;
            }

            lbGrow.Text = ((int)stat_grow).ToString() + "%";
            pgbGrow.Value = (int)stat_grow;


            //사망 시스템
            if ((stat_hungry + stat_tired + stat_stress) > 250) die();
        }

        private void die()
        {
            tmrH.Stop();
            tmrST.Stop();
            tmrST.Stop();
            tmrGrow.Stop();

            if (MessageBox.Show("사망했습니다...\n다시 시작하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }

            init_stat(true); //새로 시작
        }

        private void click_eatingPBX(object sender, EventArgs e)
        {
            if (stat_hungry > 30)
            {
                RicePBX.Visible = true;
                NoodlePBX.Visible = true;
                withNoodlelbl.Visible = true;
                withRicelbl.Visible = true;
            }
            else
            {
                MessageBox.Show("아직 배가 고프지 않습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string level = get_state_string(grow_state);
            TimeSpan playTime = TimeSpan.FromSeconds(Environment.TickCount / 1000);
            int growPercent = (int)stat_grow;

            Form popup = new Form();
            popup.Text = "캐릭터 정보";
            popup.Size = new Size(320, 300);
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.MaximizeBox = false;
            popup.MinimizeBox = false;

            // Label: 이름
            Label lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new Point(20, 20);
            lblName.AutoSize = true;

            // TextBox: 이름 입력
            TextBox txtName = new TextBox();
            txtName.Text = characterName;
            txtName.Location = new Point(80, 18);
            txtName.Width = 200;

            // Label: 레벨
            Label lblLevel = new Label();
            lblLevel.Text = $"Level: {level}";
            lblLevel.Location = new Point(20, 50);
            lblLevel.AutoSize = true;

            // Label: 플레이타임
            Label lblTime = new Label();
            lblTime.Text = $"PlayTime: {playTime.Hours}시간 {playTime.Minutes}분";
            lblTime.Location = new Point(20, 80);
            lblTime.AutoSize = true;

            // ProgressBar: 성장도
            ProgressBar prgGrow = new ProgressBar();
            prgGrow.Location = new Point(20, 110);
            prgGrow.Size = new Size(260, 25);
            prgGrow.Minimum = 0;
            prgGrow.Maximum = 100;
            prgGrow.Value = growPercent;

            // Label: 성장도
            Label lblGrowPercent = new Label();
            lblGrowPercent.Text = $"성장도: {growPercent}%";
            lblGrowPercent.Location = new Point(20, 140);
            lblGrowPercent.AutoSize = true;

            // 저장 버튼
            Button btnSave = new Button();
            btnSave.Text = "저장";
            btnSave.Location = new Point(60, 200);
            btnSave.Click += (s, args) =>
            {
                characterName = txtName.Text.Trim();
                MessageBox.Show("이름이 저장되었습니다!", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // 닫기 버튼
            Button btnClose = new Button();
            btnClose.Text = "닫기";
            btnClose.Location = new Point(160, 200);
            btnClose.Click += (s, args) =>
            {
                popup.Close();
            };

            // 컨트롤 추가
            popup.Controls.Add(lblName);
            popup.Controls.Add(txtName);
            popup.Controls.Add(lblLevel);
            popup.Controls.Add(lblTime);
            popup.Controls.Add(prgGrow);
            popup.Controls.Add(lblGrowPercent);
            popup.Controls.Add(btnSave);
            popup.Controls.Add(btnClose);

            popup.ShowDialog();
        }
    }
}

