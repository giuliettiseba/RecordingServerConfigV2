using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordingServerConfigV2
{
    public partial class MS_Tester : Form
    {
        private List<KeyValuePair<string, string>> resultList;
        private TestsHelper testHelper;
        private RecorderProperties rsProps;

        internal MS_Tester(TestsHelper testHelper, RecorderProperties rsProps)
        {
            this.testHelper = testHelper;
            this.rsProps = rsProps;
            InitializeComponent();

        }

        internal async Task StartTestsAsync()
        {

            dataGridViewResults.Rows.Add("Starting Tests", "Please wait...");


            // Test rdate 


            int row = 0;

            Boolean port80isGood = false;
            // Test port 80
            string msPort80 = await testHelper.CheckPortAsync(rsProps.msWebApiAddress, "80");
            row = dataGridViewResults.Rows.Add("IIS port 80: ", msPort80);
            if (msPort80.Contains("Endpoint found at IP:")) { dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Green;
                port80isGood = true;
            }
            else dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins


            // Test port 443
            string msPort443 = await testHelper.CheckPortAsync(rsProps.msWebApiAddress, "443");
            row = dataGridViewResults.Rows.Add("IIS port 443: ", msPort443);
            if (msPort443.Contains("Endpoint found at IP:")) dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Green;
            else dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins

            // Test port 9000
            string enpointTest = await testHelper.CheckPortAsync(rsProps.msWebApiAddress, rsProps.msWebApiPort);
            row = dataGridViewResults.Rows.Add("Web Server: ", enpointTest);
            if (enpointTest.Contains("Endpoint found at IP:")) dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Green;
            else dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins


            /// Check the time difference between the MS and the RS; if the diff is > 300 seg (5 min) change the row color to red. 
            
            if (port80isGood) {

                string[] serverDates = testHelper.GetDate(rsProps.msWebApiAddress);

                dataGridViewResults.Rows.Add("Management Server Date: ", serverDates[1]);
            dataGridViewResults.Rows.Add("Recording Server Date: ", serverDates[0]);

            DateTime msTime;
            DateTime rsTime;
            if (DateTime.TryParse(serverDates[0], out msTime) && DateTime.TryParse(serverDates[1], out rsTime))
            {
                TimeSpan timedif = msTime.Subtract(rsTime);
                row = dataGridViewResults.Rows.Add("Time Diference: ", timedif);
                if (Math.Abs(timedif.TotalSeconds) > 300) dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins
                else dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Green;

            }
            else
            {
                row = dataGridViewResults.Rows.Add("Time Diference: ", "Fail");
                dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red;

            }
            }

            /// GET IDP wellknow things 
            resultList = await testHelper.ReadIDPResponseAsync(rsProps.authorizationServerAddress);

            foreach (KeyValuePair<String,String> keyValuePair in resultList)
            {
                row = dataGridViewResults.Rows.Add(keyValuePair.Key, keyValuePair.Value);
            }

            if (resultList.Count == 1) dataGridViewResults.Rows[row].DefaultCellStyle.BackColor = Color.Red; // If time dif > 5 mins

        }

        private async void buttonRetryTest_ClickAsync(object sender, EventArgs e)
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

            await StartTestsAsync();
        }

    }
}
