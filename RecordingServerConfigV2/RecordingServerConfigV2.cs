using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordingServerConfigV2
{
    /// <summary>
    /// MTS Tool to modify RS settings version > 13.2
    /// </summary>
    public partial class RecordingServerConfigV2 : Form
    {
        private Parser parser;
        private RecorderProperties rsProps;
        private TestsHelper testHelper;
        public RecordingServerConfigV2()
        {
            InitializeComponent();


            // Initialize XML Parser 
            parser = new Parser();

            // Initialize TestHelper

            testHelper = new TestsHelper();

            // loadConfiguration 
            loadConfig();


        }

        /// <summary>
        /// Show the values readed from the XML in the GUI
        /// </summary>
        /// <param name="rsProps"></param>
        private void showValues(RecorderProperties rsProps)
        {

            // Info
            labelOpenFile.Text = rsProps.file;
            labelVersion.Text = rsProps.version;

            //RS
            textBox_id.Text = rsProps.id;
            textBox_displayname.Text = rsProps.displayName;
            textBoxAuthorizationserveraddress.Text = rsProps.authorizationServerAddress;
            textBoxRecordingServerWebApiAddress.Text = rsProps.rsWebApiAddress;
            textBoxRecordingServerWebApiPort.Text = rsProps.rsWebApiPort;
            textBoxRecordingServerWebServerAddress.Text = rsProps.rsWebServerAddress;
            textBoxRecordingServerWebServerPort.Text = rsProps.rsWebServerPort;

            //MS
            textBoxMsServerWebApiAddress.Text = rsProps.msWebApiAddress;
            textBoxMsServerWebApiPort.Text = rsProps.msWebApiPort;

            //PIPELINE 
            textBoxMaxFramesInQueue.Text = rsProps.maxFramesInQueue;
            textBoxMaxBytesinQueue.Text = rsProps.maxBytesInQueue;
            textBoxMaxActiveTimeForPipeline2.Text = rsProps.maxActiveTimeForPipeline2;


            //Archiving Threads
            textBoxDeleteThreadPoolSize.Text = rsProps.deleteThreadPoolSize;
            textBoxLowPriorityArchiveThreads.Text = rsProps.lowPriorityArchiveThread;
            textBoxHighPriorityArchiveThreads.Text = rsProps.highPriorityArchiveThread;

            //Disk Utilization 
            textBoxMediaFileReadBuffer.Text = rsProps.mediaFileReadBuffer;
            textBoxMediaFileWriteBuffer.Text = rsProps.mediaFileWriteBuffer;
            textBoxChunkFileReadBuffer.Text = rsProps.chunkFileReadBuffer;
            textBoxChunkFileWriteBuffer.Text = rsProps.chunkFileWriteBuffer;


            //Disk Usage Monitor
            textBoxForceArchiveLimit.Text = rsProps.forceArchiveLimit;
            textBoxForceDeleteLimit.Text = rsProps.forceDeleteLimit;


        }

        /// <summary>
        /// Fetch the values from GUI
        /// </summary>
        /// <param name="rsProps"></param>
        private void fetchValues(RecorderProperties rsProps)
        {
            //RS 
            rsProps.id = textBox_id.Text;
            rsProps.displayName = textBox_displayname.Text;
            rsProps.rsWebApiAddress = textBoxRecordingServerWebApiAddress.Text;
            rsProps.rsWebApiPort = textBoxRecordingServerWebApiPort.Text;
            rsProps.rsWebServerAddress = textBoxRecordingServerWebServerAddress.Text;
            rsProps.rsWebServerPort = textBoxRecordingServerWebServerPort.Text;

            // MS
            rsProps.msWebApiAddress = textBoxMsServerWebApiAddress.Text;
            rsProps.msWebApiPort = textBoxMsServerWebApiPort.Text;
            rsProps.authorizationServerAddress = textBoxAuthorizationserveraddress.Text;


            //PIPELINE 
            rsProps.maxFramesInQueue = textBoxMaxFramesInQueue.Text;
            rsProps.maxBytesInQueue = textBoxMaxBytesinQueue.Text;
            rsProps.maxActiveTimeForPipeline2 = textBoxMaxActiveTimeForPipeline2.Text;

            //Archiving Threads
            rsProps.deleteThreadPoolSize = textBoxDeleteThreadPoolSize.Text;
            rsProps.lowPriorityArchiveThread = textBoxLowPriorityArchiveThreads.Text;
            rsProps.highPriorityArchiveThread = textBoxHighPriorityArchiveThreads.Text;

            //Disk Utilization 
            rsProps.mediaFileReadBuffer = textBoxMediaFileReadBuffer.Text;
            rsProps.mediaFileWriteBuffer = textBoxMediaFileWriteBuffer.Text;
            rsProps.chunkFileReadBuffer = textBoxChunkFileReadBuffer.Text;
            rsProps.chunkFileWriteBuffer = textBoxChunkFileWriteBuffer.Text;


            //Disk Usage Monitor
            rsProps.forceArchiveLimit = textBoxForceArchiveLimit.Text;
            rsProps.forceDeleteLimit = textBoxForceDeleteLimit.Text;

        }



        /// <summary>
        /// Call the parser to save the values read from the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Warning: There will be no recordings or live video available until the Recording Server restrart is complete. Are you sure you want to continue?", "Restart required", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fetchValues(rsProps);
                parser.WriteValues(rsProps);
                RestartService();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }



        }

        private void buttonDefaulValues_Click(object sender, EventArgs e)
        {
            //RS
            textBoxRecordingServerWebApiPort.Text = "9001";
            textBoxRecordingServerWebServerPort.Text = "7563";

            //MS
            textBoxMsServerWebApiPort.Text = "9000";

            //PIPELINE 
            textBoxMaxFramesInQueue.Text = "50";
            textBoxMaxBytesinQueue.Text = "31457280";
            textBoxMaxActiveTimeForPipeline2.Text = "120000";

            //Archiving Threads
            textBoxDeleteThreadPoolSize.Text = "2";
            textBoxLowPriorityArchiveThreads.Text = "1";
            textBoxHighPriorityArchiveThreads.Text = "4";

            //Disk Utilization 
            textBoxMediaFileReadBuffer.Text = "4096";
            textBoxMediaFileWriteBuffer.Text = "4096";
            textBoxChunkFileReadBuffer.Text = "65536";
            textBoxChunkFileWriteBuffer.Text = "65536";

            //Disk Usage Monitor
            textBoxForceArchiveLimit.Text = "5120";
            textBoxForceDeleteLimit.Text = "1024";
        }

        private void textBoxMaxFramesInQueue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxMaxBytesinQueue.Text = (int.Parse(textBoxMaxFramesInQueue.Text) * 629145).ToString();
            }
            catch (Exception)
            {
                textBoxMaxBytesinQueue.Text = "0";
            }

        }

        private void buttonOptimusValues_Click(object sender, EventArgs e)
        {
            //PIPELINE 
            textBoxMaxFramesInQueue.Text = "200";
            textBoxMaxBytesinQueue.Text = "62914560";
            textBoxMaxActiveTimeForPipeline2.Text = "120000";

            //Archiving Threads
            textBoxDeleteThreadPoolSize.Text = "2";
            textBoxLowPriorityArchiveThreads.Text = "1";
            textBoxHighPriorityArchiveThreads.Text = "4";

            //Disk Utilization 
            textBoxMediaFileReadBuffer.Text = "4096";
            textBoxMediaFileWriteBuffer.Text = "4096";
            textBoxChunkFileReadBuffer.Text = "65536";
            textBoxChunkFileWriteBuffer.Text = "65536";

            //Disk Usage Monitor
            textBoxForceArchiveLimit.Text = "5120";
            textBoxForceDeleteLimit.Text = "1024";

        }

        private void buttonExtremeValues_Click(object sender, EventArgs e)
        {
            //PIPELINE 
            textBoxMaxFramesInQueue.Text = "550";
            textBoxMaxBytesinQueue.Text = "62914560";
            textBoxMaxActiveTimeForPipeline2.Text = "120000";

            //Archiving Threads
            textBoxDeleteThreadPoolSize.Text = "2";
            textBoxLowPriorityArchiveThreads.Text = "4";
            textBoxHighPriorityArchiveThreads.Text = "6";

            //Disk Utilization 
            textBoxMediaFileReadBuffer.Text = "4096";
            textBoxMediaFileWriteBuffer.Text = "4096";
            textBoxChunkFileReadBuffer.Text = "65536";
            textBoxChunkFileWriteBuffer.Text = "65536";

            //Disk Usage Monitor
            textBoxForceArchiveLimit.Text = "5120";
            textBoxForceDeleteLimit.Text = "1024";
        }

        private void buttonDiskUsageHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By default, the Recording Server will force an archive once an area has 5GB (or less) free space and will delete footage if an area has 1GB (or less) free space depending on the number of cameras and the size of the storage area you may want to increase these values.", "Disk Usage Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void buttonDiskUtilizationHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chunk Buffers should be set to 64K \n\nDisk formatting \nTo get the best disk performance it is strongly recommended that the disks are formatted with NTFS with the allocation unit size set to 64K.", "Disk Utilization Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonPipelineSettingsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To fix overflows issues, you can try to increase \"maxframesinqueue\" and \"maxkeyframesinqueue\" to 100, and see if this larger size of the buffer will be enough of a workaround for the media overflows.\n" +
                "The bigger values will allow the Recording Server to buffer more frames before saving them to the disk.This of course will come at a cost, and the Recording Server might use more memory while frames are being buffered.However, since the buffer is not constantly used this should be not much of an issue."+ 
                "\n\nMax Frames In Queue: Specifies the maximun number of frames in the queue, both key- and nonkey-frames (H264 and MPEG limit primarily).\n" +
                "Range: 20 - 200(recomended limits)\n" +
                "Default : 50\n\n" +
                "Max Bytes In Queue: Specifies the maximum size, in bytes, allowed in the queue.\n" +
                "Range   : 1048576 - 104857600 (1 MB - 100 MB, recomended limits)\n" +
                "Default : 30*1024*1024\n\n" +
                "Max Active Time Pipeline2: Specifies the maximum time pipeline part 2 is allowed to be active.\n" +
                "Range: 0(no check), 30000 - 3600000(30 sec - 60 min)\n" +
                "Default: 600000(10 min)\n"
           , "Pipeline Settings Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void buttonArchivingThreads_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When archiving to or from a network storage area, the rate of data transfer may not make use of all the available bandwidth.\n" +
                "Increase 'Low Priority Archive Threads' from 1 to 2. Higher values can be used but with diminishing returns.", "Archiving Thread Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }


        public static void RestartService()
        {
            ServiceController service = new ServiceController("Milestone XProtect Recording Server");
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(90000);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(90000 - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch
            {
                // ...
            }
        }


        private void buttonReloadConfig_Click(object sender, EventArgs e)
        {
            loadConfig();
        }


        private void loadConfig()
        {

            // Open file 
            // TODO: add option to select file
            parser.OpenFile();


            // instance properties Class 
            rsProps = new RecorderProperties();

            // Read Values from XML
            parser.ReadValues(rsProps);

            // Show Values in the GUI
            showValues(rsProps);
        }

        private void buttonTestManagementServer_Click(object sender, EventArgs e)
        {

            fetchValues(rsProps);


            MessageBox.Show(testHelper.CheckPort(rsProps.msWebApiAddress, rsProps.msWebApiPort));


            MessageBox.Show(testHelper.ReadIDPResponse(rsProps.authorizationServerAddress));
            



            
            /// Test name resolution if the case and port 
            /// Test IDP 


        }

        private void buttonTestRecordingServer_Click(object sender, EventArgs e)
        {
            fetchValues(rsProps);

            MessageBox.Show(testHelper.CheckEndPoint(rsProps.rsWebServerPort));

            MessageBox.Show(testHelper.CheckEndPoint(rsProps.rsWebApiPort));

     
        }

        private void fetchValues_Action(object sender, EventArgs e)
        {
            fetchValues(rsProps);
        }
    }
}
