using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ProcessAndDownloadFilePOC
{
    public class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        [return: ServiceBus("myqueue", Connection = "ServiceBusConnection")]
        public string Run(
            [QueueTrigger("message", Connection = "processanddownloadfile_STORAGE")]string myQueueItem, ILogger log
        )
        {
            var deserializedmessage = JsonConvert.DeserializeObject<Message>(myQueueItem);
            log.LogInformation($"C# Queue trigger function processed");
            log.LogInformation($"Guid: {deserializedmessage.Id}");
            return myQueueItem;
        }
    }
}
