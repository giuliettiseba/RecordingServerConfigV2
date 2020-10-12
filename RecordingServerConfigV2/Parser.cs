using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RecordingServerConfigV2
{
    class Parser
    {

        static string file = @"C:\ProgramData\Milestone\XProtect Recording Server\RecorderConfig.xml";
        private XmlDocument xDoc;

        public Parser()
        {


        }

        public void OpenFile()
        {
            xDoc = new XmlDocument();
            xDoc.Load(file);
        }

        public void ReadValues(RecorderProperties rsProps)
        {


            // Info

            rsProps.version = xDoc.SelectSingleNode("/recorderconfig/version").InnerText;
            rsProps.file = file;
            // RS
            rsProps.id = xDoc.SelectSingleNode("/recorderconfig/recorder/id").InnerText;
            rsProps.displayName = xDoc.SelectSingleNode("/recorderconfig/recorder/displayname").InnerText;

            rsProps.rsWebApiPort = xDoc.SelectSingleNode("/recorderconfig/webapi/port").InnerText;

            rsProps.rsWebApiAddress = xDoc.SelectSingleNode("/recorderconfig/webapi/publicUri").InnerText;
            // WORKARROUND TO NOT SHOW PORT IN GUI; FOR SOME REASON THE PORT IS ATTACHED TO THE ADDRESS IN THE XML
            rsProps.rsWebApiAddress = rsProps.rsWebApiAddress.Substring(0, rsProps.rsWebApiAddress.IndexOf(":"));

            rsProps.rsWebServerAddress = xDoc.SelectSingleNode("/recorderconfig/webserver/host").InnerText;
            rsProps.rsWebServerPort = xDoc.SelectSingleNode("/recorderconfig/webserver/port").InnerText;

            // MS
            rsProps.msWebApiAddress = xDoc.SelectSingleNode("/recorderconfig/server/address").InnerText;
            rsProps.msWebApiPort = xDoc.SelectSingleNode("/recorderconfig/server/webapiport").InnerText;
            rsProps.authorizationServerAddress = xDoc.SelectSingleNode("/recorderconfig/server/authorizationserveraddress").InnerText;

            // Pipeline Settings 
            rsProps.maxFramesInQueue = xDoc.SelectSingleNode("/recorderconfig/pipeline/maxframesinqueue").InnerText;
            rsProps.maxBytesInQueue = xDoc.SelectSingleNode("/recorderconfig/pipeline/maxbytesinqueue").InnerText;
            rsProps.maxActiveTimeForPipeline2 = xDoc.SelectSingleNode("/recorderconfig/pipeline/maxactivetimepipeline2").InnerText;

            //Archiving Threads
            rsProps.deleteThreadPoolSize = xDoc.SelectSingleNode("/recorderconfig/database/database_server/thread_pools/delete_thread_pool_size").InnerText;
            rsProps.lowPriorityArchiveThread = xDoc.SelectSingleNode("/recorderconfig/database/database_server/thread_pools/low_priority_archive_thread_pool_size").InnerText;
            rsProps.highPriorityArchiveThread = xDoc.SelectSingleNode("/recorderconfig/database/database_server/thread_pools/high_priority_archive_thread_pool_size").InnerText;

            //Disk Utilization 
            rsProps.mediaFileReadBuffer = xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/media_block_files/read_buffer_size").InnerText;
            rsProps.mediaFileWriteBuffer = xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/media_block_files/write_buffer_size").InnerText;
            rsProps.chunkFileReadBuffer = xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/chunk_files/read_buffer_size").InnerText;
            rsProps.chunkFileWriteBuffer = xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/chunk_files/write_buffer_size").InnerText;

            //Disk Usage Monitor
            rsProps.forceArchiveLimit = xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_usage_monitor/force_archive_limit_in_mb").InnerText;
            rsProps.forceDeleteLimit= xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_usage_monitor/force_delete_limit_in_mb").InnerText;


        }


        public void WriteValues(RecorderProperties rsProps)
        {
            int i = 0;
            while (File.Exists(@"C:\ProgramData\Milestone\XProtect Recording Server\RecorderConfig (" + i + ").xml"))
            {  
                i++;
            }

            xDoc.Save(@"C:\ProgramData\Milestone\XProtect Recording Server\RecorderConfig (" + i + ").xml");

            // RS
            xDoc.SelectSingleNode("/recorderconfig/recorder/id").InnerText = rsProps.id;
            xDoc.SelectSingleNode("/recorderconfig/recorder/displayname").InnerText = rsProps.displayName;
            xDoc.SelectSingleNode("/recorderconfig/webapi/port").InnerText = rsProps.rsWebApiPort;
            xDoc.SelectSingleNode("/recorderconfig/webapi/publicUri").InnerText = rsProps.rsWebApiAddress + ":" + rsProps.rsWebApiPort;


            xDoc.SelectSingleNode("/recorderconfig/webserver/host").InnerText = rsProps.rsWebServerAddress; 
            xDoc.SelectSingleNode("/recorderconfig/webserver/port").InnerText = rsProps.rsWebServerPort;

            // MS
            xDoc.SelectSingleNode("/recorderconfig/server/address").InnerText = rsProps.msWebApiAddress;
            xDoc.SelectSingleNode("/recorderconfig/server/webapiport").InnerText = rsProps.msWebApiPort;
            xDoc.SelectSingleNode("/recorderconfig/server/authorizationserveraddress").InnerText = rsProps.authorizationServerAddress;


            // Pipeline Settings 
            xDoc.SelectSingleNode("/recorderconfig/pipeline/maxframesinqueue").InnerText = rsProps.maxFramesInQueue;
            xDoc.SelectSingleNode("/recorderconfig/pipeline/maxbytesinqueue").InnerText = rsProps.maxBytesInQueue;
            xDoc.SelectSingleNode("/recorderconfig/pipeline/maxactivetimepipeline2").InnerText = rsProps.maxActiveTimeForPipeline2;

            //Archiving Threads
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/thread_pools/delete_thread_pool_size").InnerText = rsProps.deleteThreadPoolSize;
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/thread_pools/low_priority_archive_thread_pool_size").InnerText = rsProps.lowPriorityArchiveThread;
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/thread_pools/high_priority_archive_thread_pool_size").InnerText = rsProps.highPriorityArchiveThread;

            //Disk Utilization 
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/media_block_files/read_buffer_size").InnerText = rsProps.mediaFileReadBuffer;
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/media_block_files/write_buffer_size").InnerText = rsProps.mediaFileWriteBuffer;
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/chunk_files/read_buffer_size").InnerText = rsProps.chunkFileReadBuffer;
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_utilization/chunk_files/write_buffer_size").InnerText = rsProps.chunkFileWriteBuffer;


            //Disk Usage Monitor
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_usage_monitor/force_archive_limit_in_mb").InnerText = rsProps.forceArchiveLimit;
            xDoc.SelectSingleNode("/recorderconfig/database/database_server/disk_usage_monitor/force_delete_limit_in_mb").InnerText = rsProps.forceDeleteLimit;


            try
            {
                xDoc.Save(@"C:\ProgramData\Milestone\XProtect Recording Server\RecorderConfig.xml");
            }

            catch {

                MessageBox.Show("ERROR SAVING");
            }
        }

    }
}
