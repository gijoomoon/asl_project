using System;
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
        BABY = 0, CHILD, ADULT
    }

    public partial class MainWindow : Form
    {
        private int stat_hungry;
        private int stat_tired;
        private int stat_stress;
        private double stat_grow;
        private System.Windows.Forms.Button statusButton;
        private string characterName;
        private int foodCount = 0;

        private int adultCharacterIndex = 0; // 캐릭터 종류

        private growState grow_state; //현재 성장 상태를 저장하는 변수 (유아기: BABY, 청년기: CHILD, 성년기: ADULT)
        private bool sleeping;
        public List<Label> Foodlabels;


        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        public MainWindow()
        {
            InitializeComponent();
            init_stat(false);

            ddongPBX.Visible = false;
            Foodlabels = new List<Label> { withNoodlelbl, withRicelbl };
            FoodItem rice = new FoodItem(RicePBX, characterPBX, eatingRicech, DecreaseHunger,
                    new List<PictureBox> { NoodlePBX }, Foodlabels);
            FoodItem noodle = new FoodItem(NoodlePBX, characterPBX, eatingNoodlech, DecreaseHunger,
                    new List<PictureBox> { RicePBX }, Foodlabels);

            InitializeTrayIcon();
        }

        private void InitializeTrayIcon()
        {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Open", SysTrayOnOpen);
            trayMenu.MenuItems.Add("Exit", SysTrayOnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Icon = SystemIcons.Application;
            trayIcon.Visible = true;
            trayIcon.ContextMenu = trayMenu;

            trayIcon.DoubleClick += SysTrayOnOpen;
        }

        // Restore the window
        private void SysTrayOnOpen(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        // Exit the app
        private void SysTrayOnExit(object sender, EventArgs e)
        {
            trayIcon.Visible = false; // Hide tray icon

            SaveData();

            Application.Exit();
        }

        private void DecreaseHunger()
        {
            stat_hungry -= 10;
            if (stat_hungry < 0) stat_hungry = 0;

            foodCount++;
            if (foodCount % 3 == 0)
            {
                ddongPBX.Visible = true;
            }

            MessageBox.Show("배고픔이 10 감소하였습니다.");

        }

        private void init_stat(bool restart)
        {
            if (!restart)
            {
                stat_hungry = Properties.Settings.Default.exitHungry;
                stat_tired = Properties.Settings.Default.exitTired;
                stat_stress = Properties.Settings.Default.exitStress;
                stat_grow = Properties.Settings.Default.exitGrow;
                sleeping = Properties.Settings.Default.exitSleeping;
                grow_state = (growState)Properties.Settings.Default.GrowState;
                characterName = Properties.Settings.Default.Name;

                adultCharacterIndex = Properties.Settings.Default.AdultCharacterIndex;

                DateTime exitTime = Properties.Settings.Default.exitTime;
                if (exitTime != new DateTime(2000, 1, 1)) //저장해둔 내용이 있다면
                {
                    TimeSpan diff = DateTime.Now - exitTime;
                    double diffSec = diff.TotalSeconds;

                    if (sleeping) 
                    {
                        stat_tired -= (int)(diffSec / 240);
                        stat_hungry += (int)(diffSec / 540);
                        stat_stress += (int)(diffSec / 540);
                    } 
                    else 
                    {
                        stat_tired += (int)(diffSec / 240);
                        stat_hungry += (int)(diffSec / 360);
                        stat_stress += (int)(diffSec / 360);
                    } 
                    
                    stat_grow += (diffSec / 600);

                    if (stat_tired >= 100) stat_tired = 100;
                    if (stat_tired <= 0) stat_tired = 0;
                    if (stat_hungry >= 100) stat_hungry = 100;
                    if (stat_stress >= 100) stat_stress = 100;
                    if (stat_grow >= 100) stat_grow = 100;
                }
                else //처음 게임을 시작해서 초기값인 경우
                {
                    stat_hungry = 0;
                    stat_tired = 0;
                    stat_stress = 0;
                    stat_grow = 0;
                    sleeping = false;
                    grow_state = growState.BABY;
                }
            }
            else //캐릭터가 사망해서 다시 시작하는 경우
            {
                stat_hungry = 0;
                stat_tired = 0;
                stat_stress = 0;
                stat_grow = 0;
                sleeping = false;
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


            change_ch_image();

            if (!restart && (stat_hungry + stat_tired + stat_stress > 250)) die();

            if (sleeping)
            {
                tmrH.Stop();
                tmrST.Stop();
                tmrTR.Start();
                tmrGrow.Start();
            }
            else
            {
                tmrH.Start();
                tmrST.Start();
                tmrTR.Start();
                tmrGrow.Start();
            }
            
        }

        private void change_ch_image()
        {
            //상태창 버튼 이미지 변경
            if(grow_state == growState.BABY)
            {
                statusButton.Image = Properties.Resources.status0;
            }
            else
            {
                switch (adultCharacterIndex)
                {
                    case 0:
                        statusButton.Image = Properties.Resources.status1;
                        break;
                    case 1:
                        statusButton.Image = Properties.Resources.status2;
                        break;
                    case 2:
                        statusButton.Image = Properties.Resources.status3;
                        break;
                }
            }

            if (sleeping)
            {
                switch (grow_state)
                {
                    case growState.BABY:
                        characterPBX.Image = Properties.Resources.sleeping0;
                        break;

                    case growState.CHILD:
                        switch (adultCharacterIndex)
                        {
                            case 0:
                                characterPBX.Image = Properties.Resources.sleeping1;
                                break;
                            case 1:
                                characterPBX.Image = Properties.Resources.ch3_4;
                                break;
                            case 2:
                                characterPBX.Image = Properties.Resources.ch4_4;
                                break;
                        }
                        break;

                    case growState.ADULT:
                        switch (adultCharacterIndex)
                        {
                            case 0:
                                characterPBX.Image = Properties.Resources.sleeping2;
                                break;
                            case 1:
                                characterPBX.Image = Properties.Resources.sleepingch2;
                                break;
                            case 2:
                                characterPBX.Image = Properties.Resources.sleepingch3;
                                break;
                        }
                        break;

                    default:
                        characterPBX.Image = null;
                        break;
                }
            }
            else
            {
                switch (grow_state)
                {
                    case growState.BABY:
                        characterPBX.Image = Properties.Resources.ch0;
                        break;

                    case growState.CHILD:
                        switch (adultCharacterIndex)
                        {
                            case 0:
                                characterPBX.Image = Properties.Resources.ch1;
                                break;
                            case 1:
                                characterPBX.Image = Properties.Resources.ch3_1;
                                break;
                            case 2:
                                characterPBX.Image = Properties.Resources.ch4_1;
                                break;
                        }
                        break;

                    case growState.ADULT:
                        switch (adultCharacterIndex)
                        {
                            case 0:
                                characterPBX.Image = Properties.Resources.ch2_1;
                                break;
                            case 1:
                                characterPBX.Image = Properties.Resources.ch2_2;
                                break;
                            case 2:
                                characterPBX.Image = Properties.Resources.ch2_3;
                                break;
                        }
                        break;

                    default:
                        characterPBX.Image = null;
                        break;
                }
            }
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
            if (stat_hungry >= 100 || stat_hungry < 0) return;
            stat_hungry++;
            lbH.Text = stat_hungry.ToString();
            pgbH.Value = stat_hungry;
            
            if (stat_hungry > 70 && stat_hungry % 10 == 0)
            {
                trayIcon.ShowBalloonTip(1000, "케어가 필요해요", "허기를 관리해주세요", ToolTipIcon.Warning);
            }
        }

        private void tmrTR_Tick(object sender, EventArgs e)
        {
            if (stat_tired > 100 || stat_tired < 0) return;
            if (!sleeping)
            {
                if (stat_tired < 100) stat_tired++;
            }
            else
            {
                if (stat_tired > 0) stat_tired--;
            }
            lbTR.Text = stat_tired.ToString();
            pgbTR.Value = stat_tired;

            if (stat_tired > 70 && stat_tired % 10 == 0)
            {
                trayIcon.ShowBalloonTip(1000, "케어가 필요해요", "피로를 관리해주세요", ToolTipIcon.Warning);
            }
        }

        private void tmrST_Tick(object sender, EventArgs e)
        {
            if (stat_stress >= 100 || stat_stress < 0) return;
            stat_stress++;
            lbST.Text = stat_stress.ToString();
            pgbST.Value = stat_stress;

            if (stat_stress > 70 && stat_stress % 10 == 0)
            {
                trayIcon.ShowBalloonTip(1000, "케어가 필요해요", "스트레스를 관리해주세요", ToolTipIcon.Warning);
            }
        }

        private void tmrGrow_Tick(object sender, EventArgs e)
        {
            if (grow_state == growState.BABY) tmrH.Interval = 2400; //유아기이므로 배고픔 빠르게 증가
            else tmrH.Interval = 4800;

            if (stat_grow >= 100)
            {
                //자는 도중에 진화되면 잠에서 깨도록 설정 (성년기에선 진화가 더이상 되지 않으므로 제외)
                if (sleeping && grow_state != growState.ADULT) 
                { 
                    sleeping = false;
                    tmrH.Start();
                    tmrST.Start();
                }

                if (grow_state == growState.BABY)
                {
                    grow_state = growState.CHILD;
                    Random rand = new Random();
                    adultCharacterIndex = rand.Next(3); //유아기에서 벗어나면 랜덤한 캐릭터 선택
                    switch (adultCharacterIndex)
                    {
                        case 0:
                            characterPBX.Image = Properties.Resources.ch1;
                            statusButton.Image = Properties.Resources.status1;
                            break;
                        case 1:
                            characterPBX.Image = Properties.Resources.ch3_1;
                            statusButton.Image = Properties.Resources.status2;
                            break;
                        case 2:
                            characterPBX.Image = Properties.Resources.ch4_1;
                            statusButton.Image = Properties.Resources.status3;
                            break;
                    }
                    
                    stat_grow = 0;
                }
                else if (grow_state == growState.CHILD)
                {
                    grow_state = growState.ADULT;
                    switch (adultCharacterIndex)
                    {
                        case 0:
                            characterPBX.Image = Properties.Resources.ch2_1;
                            break;
                        case 1:
                            characterPBX.Image = Properties.Resources.ch2_2;
                            break;
                        case 2:
                            characterPBX.Image = Properties.Resources.ch2_3;
                            break;
                    }

                    stat_grow = 0;

                }
                else
                {
                    //이미 성년기면 아무것도 하지 않음
                }

                lbGrowState.Text = get_state_string(grow_state);
            }
            else
            {
                stat_grow += 0.03;
                //stat_grow += 1; //테스트 용도
            }

            lbGrow.Text = ((int)stat_grow).ToString() + "%";
            pgbGrow.Value = (int)stat_grow;


            //사망 시스템
            if ((stat_hungry + stat_tired + stat_stress) >= 250) die();
            //if ((stat_hungry + stat_tired + stat_stress) >= 10) die(); //테스트 용도
        }

        private void die()
        {
            tmrH.Stop();
            tmrST.Stop();
            tmrTR.Stop();
            tmrGrow.Stop();

            if (MessageBox.Show("사망했습니다...\n다시 시작하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }

            init_stat(true); //새로 시작
        }

        private void click_eatingPBX(object sender, EventArgs e)
        {
            if (sleeping)
            {
                MessageBox.Show("자는 중입니다.");
                return;
            }

            if (stat_hungry > 20)
            {
                switch (grow_state)
                {
                    case growState.BABY:
                        eatingNoodlech.Image = Properties.Resources.eating0;
                        eatingRicech.Image = Properties.Resources.eating0;
                        break;

                    case growState.CHILD:
                        switch (adultCharacterIndex)
                        {
                            case 0:
                                eatingNoodlech.Image = Properties.Resources.eating1;
                                eatingRicech.Image = Properties.Resources.eating1;
                                break;
                            case 1:
                                eatingNoodlech.Image = Properties.Resources.ch3_2;
                                eatingRicech.Image = Properties.Resources.ch3_3;
                                break;
                            case 2:
                                eatingNoodlech.Image = Properties.Resources.ch4_2;
                                eatingRicech.Image = Properties.Resources.ch4_3;
                                break;
                        }
                        break;

                    case growState.ADULT:
                        switch (adultCharacterIndex)
                        {
                            case 0:
                                eatingNoodlech.Image = Properties.Resources.eatingNoodlech;
                                eatingRicech.Image = Properties.Resources.eatingRicech;
                                break;
                            case 1:
                                eatingNoodlech.Image = Properties.Resources.eatingNoodlech2;
                                eatingRicech.Image = Properties.Resources.eatingRicech2;
                                break;
                            case 2:
                                eatingNoodlech.Image = Properties.Resources.eatingNoodlech3;
                                eatingRicech.Image = Properties.Resources.eatingRicech3;
                                break;
                        }
                        break;


                    default:
                        characterPBX.Image = null;
                        break;
                }

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

        private void gamePBX_Click(object sender, EventArgs e)
        {
            if (sleeping)
            {
                MessageBox.Show("자는 중입니다.");
                return;
            }

            MinigameWindow.MapSize difficulty = (grow_state == growState.ADULT) ? MinigameWindow.MapSize.Hard : MinigameWindow.MapSize.Default;
            MinigameWindow mg = new MinigameWindow(difficulty);

            // 모든 스탯 변화 일시 중지
            tmrGrow.Stop();
            tmrH.Stop();
            tmrST.Stop();
            tmrTR.Stop();

            // 모달 창
            if (mg.ShowDialog() == DialogResult.OK)
                if (mg.MinigameResult == true)
                    set_stress(-100);

            // 모든 스탯 변화 재개
            tmrGrow.Start();
            tmrH.Start();
            tmrST.Start();
            tmrTR.Start();
        }

        private void SleepingPBX_Click(object sender, EventArgs e)
        {
            if (!sleeping) {
                sleeping = true;
                tmrH.Stop();
                tmrST.Stop();
            } 
            else 
            {
                sleeping = false;
                tmrH.Start();
                tmrST.Start();
            } 

            change_ch_image();
        }

        private void clearPBX_Click(object sender, EventArgs e)
        {
            if (ddongPBX.Visible)
            {
                ddongPBX.Visible = false;
                set_stress(-10);
                MessageBox.Show("청소 완료! 스트레스가 10 감소했습니다.");
            }
            else
            {
                MessageBox.Show("청소할 것이 없습니다.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;         // Cancel the close
                this.Hide();             // Hide the form
                trayIcon.ShowBalloonTip(1000, "Still Running", "The app is minimized to tray.", ToolTipIcon.Info);
            }
            else
            {
                base.OnFormClosing(e);  // Let it close for other reasons (e.g. Application.Exit)
            }
        }

        private void SaveData()
        {
            Properties.Settings.Default.exitTime = DateTime.Now;
            Properties.Settings.Default.exitHungry = stat_hungry;
            Properties.Settings.Default.exitTired = stat_tired;
            Properties.Settings.Default.exitStress = stat_stress;
            Properties.Settings.Default.exitGrow = stat_grow;
            Properties.Settings.Default.Name = characterName;
            Properties.Settings.Default.GrowState = (int)grow_state;
            Properties.Settings.Default.exitSleeping = sleeping;
            Properties.Settings.Default.AdultCharacterIndex = adultCharacterIndex;

            Properties.Settings.Default.Save();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;         // Cancel the close
                this.Hide();             // Hide the form
                trayIcon.ShowBalloonTip(1000, "백그라운드에서 실행 중", "시스템 트레이로 최소화 되었습니다.", ToolTipIcon.Info);
            }
            else
            {
                SaveData();
            }
        }

    }
}

