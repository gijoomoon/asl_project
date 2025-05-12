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
        BABY, CHILD, ADULT
    }

    public partial class MainWindow: Form
    {
        int stat_hungry;
        int stat_tired;
        int stat_stress;
        int stat_grow;
        growState grow_state;

        public MainWindow()
        {
            InitializeComponent();
            init_stat();
        }

        void init_stat()
        {
            //임시로 0, 유아기로 초기화해둠, 추후 이전에 플레이하던 값 가져오는 작업 필요
            stat_hungry = 0; 
            stat_tired = 0;
            stat_stress = 0;
            stat_grow = 0;
            grow_state = growState.BABY;

            lbH.Text = stat_hungry.ToString();
            lbTR.Text = stat_tired.ToString();
            lbST.Text = stat_stress.ToString();
            lbGrow.Text = stat_grow.ToString() + "%";

            pgbH.Value = stat_hungry;
            pgbTR.Value = stat_tired;
            pgbST.Value = stat_stress;
            pgbGrow.Value = stat_grow;
            

            tmrH.Start();
            tmrTR.Start();
            tmrST.Start();
            tmrGrow.Start();
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
            if (stat_grow == 100) { 
                if(grow_state == growState.BABY)
                {
                    grow_state = growState.CHILD;
                    stat_grow = 0;
                }
                else if(grow_state == growState.CHILD)
                {
                    grow_state = growState.ADULT;
                    stat_grow = 0;
                }
                else
                {
                    tmrGrow.Stop();
                    return;
                }
            }
            else
            {
                stat_grow++;
            }

            lbGrow.Text = stat_grow.ToString() + "%";
            pgbGrow.Value = stat_grow;
        }


    }
}
