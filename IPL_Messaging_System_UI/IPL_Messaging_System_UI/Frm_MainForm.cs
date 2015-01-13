using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
using IPL_MSGUI.DriverUI;
using IPL_MSGUI.PlannerUI;
using IPL_MSGUI.GrowthVentureUI;
//
using FM.TransportPlanning.UI;
using FM.FMSystem.DAL;
// 
using System.Threading;

namespace IPL_MSGUI.StartUI
{
    public partial class Frm_MainForm : Form
    {
        public static String strDbCon =
            "Server=127.0.0.1\\sql2012;Database=FM80_SG_USS_UAT;Trusted_Connection=True;";

        public Frm_MainForm()
        {
            InitializeComponent();
            // start the main timer to display the current time
            timerMain.Start();

            // the database connection string is hard-coded here:
            FMGlobalSettings.TheInstance.SetConnectionString(strDbCon);
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbDriver.Checked)
            {
                Frm_MDT mdt = new Frm_MDT();
                mdt.ShowDialog();
            }
            if (rbPlanner.Checked)
            {
                bool createdNew = false;
                Mutex mutex = new Mutex(true, "TRPlanningUI", out createdNew);
                if ((!mutex.WaitOne(1000, false)) & createdNew == false)
                {
                    MessageBox.Show("Only one instance of this application can be started");
                    Application.Exit();
                }

                FrmTransportPlanningMain frmPlanUIMain =
                    new FrmTransportPlanningMain("ipl", mutex);
                frmPlanUIMain.ShowDialog();
            }
            if (rbGrowthVenture.Checked)
            {
                Frm_MsgMonitoring frmMsgMonitoring = new Frm_MsgMonitoring();
                frmMsgMonitoring.ShowDialog();
            }

            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
