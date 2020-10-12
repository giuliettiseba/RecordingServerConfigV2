using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordingServerConfigV2
{
    public partial class RS_Tester : Form
    {
        TestsHelper testHelper;
        RecorderProperties rsProps;

        internal RS_Tester(TestsHelper testHelper, RecorderProperties rsProps)
        {
            this.testHelper = testHelper;
            this.rsProps = rsProps;
            InitializeComponent();
        }
        internal void StartTests()
        {
            /// Test WebServerPort 
            string webServerPort = testHelper.CheckPort(rsProps.rsWebServerAddress, rsProps.rsWebServerPort);
            int row = dataGridViewResults.Rows.Add("Web Server: ", webServerPort);
            if (webServerPort.Contains("Endpoint found at IP:")) dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Green;
            else dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins


            /// Test WebApiPort 
            string webApiPort = testHelper.CheckPort(rsProps.rsWebApiAddress, rsProps.rsWebApiPort);
            row = dataGridViewResults.Rows.Add("Web API Server: ", webApiPort);
            if (webApiPort.Contains("Endpoint found at IP:")) dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Green;
            else dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins

        }

        private void buttonRetryTest_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in dataGridViewResults.Rows)
                {
                    try
                    {
                        dataGridViewResults.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridViewResults.Rows.Count > 0);

            StartTests();
        }
    }
}
