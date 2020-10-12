using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingServerConfigV2
{
    internal class RecorderProperties
    {

        public String file { get; set; }

        public String version { get; set; }

        // Recorfing Server 
        public String id { get; set; }
        public String displayName { get; set; }
        public String rsWebApiAddress { get; set; }
        public String rsWebApiPort { get; set; }
        public String rsWebServerAddress { get; set; }
        public String rsWebServerPort { get; set; }

        // Management Server
        public String msWebApiAddress { get; set; }
        public String msWebApiPort { get; set; }
        public String authorizationServerAddress { get; set; }

        // Pipeline Settings 

        public String maxFramesInQueue { get; set; }
        public String maxBytesInQueue { get; set; }
        public String maxActiveTimeForPipeline2 { get; set; }

        // Archiving Threads

        public String deleteThreadPoolSize { get; set; }
        public String lowPriorityArchiveThread { get; set; }
        public String highPriorityArchiveThread { get; set; }


        // Media 
        public String mediaFileReadBuffer { get; set; }
        public String mediaFileWriteBuffer { get; set; }
        public String chunkFileReadBuffer { get; set; }
        public String chunkFileWriteBuffer { get; set; }




        //Disk Usage Monitor
        public String forceDeleteLimit { get; set; }

        public String forceArchiveLimit { get; set; }
    

    }
}
