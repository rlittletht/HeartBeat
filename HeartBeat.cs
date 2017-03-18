using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartBeat.RwpSvc;

namespace HeartBeat
{
    public partial class t : Form
    {
        public t()
        {
            InitializeComponent();
        }

        void UpdateStats(RSR_CalItems rsr)
        {
            m_ebLastResponse.Text = rsr.Reason;

            if (rsr.Result)
                {
                m_ebStatus.Text = "ONLINE";
                m_ebStatus.BackColor = Color.Green;
                }
            else
                {
                m_ebStatus.Text = "OFFLINE";
                m_ebStatus.BackColor = Color.Red;
                }
        }
        private void StartHeartbeat(object sender, EventArgs e)
        {
            PracticeClient client = new PracticeClient();

            RSR_CalItems calItems = client.GetCalendarForTeam("InvalidTeam");

            UpdateStats(calItems);
        }
    }
}
