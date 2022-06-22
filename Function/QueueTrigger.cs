using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ProcessAndDownloadFilePOC
{
    public class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public void Run(
            [QueueTrigger("message", Connection = "processanddownloadfile_STORAGE")]string myQueueItem, ILogger log
        )
        {
            log.LogInformation($"C# Queue trigger function processed");
        }
    }
}
