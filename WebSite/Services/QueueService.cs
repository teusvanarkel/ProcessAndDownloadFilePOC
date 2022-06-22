using Azure.Storage.Queues;
using Newtonsoft.Json;

namespace WebSite.Services
{
    public interface IQueueService
    {
        void PutMessageOnTheQueue(Message message);
    }

    public class QueueService : IQueueService
    {
        private string _queueName = "message";
        private string _connection = "DefaultEndpointsProtocol=https;AccountName=processanddownloadfile;AccountKey=M8NZLYHi29x2xf8YN6JijCPtRygsFtYTre+vPctY3GmDROhBky+R0zwGVJJLIs3PuPHgcK7dUl0m+AStY0cQyg==;EndpointSuffix=core.windows.net";
        private readonly QueueClient _queueClient;

        public QueueService()
        {
            _queueClient = new QueueClient(_connection, _queueName, new QueueClientOptions
            {
                MessageEncoding = QueueMessageEncoding.Base64
            });
            _queueClient.CreateIfNotExists();
        }

        public void PutMessageOnTheQueue(Message message)
        {
            var serializeMessage = JsonConvert.SerializeObject(message);
            _queueClient.SendMessage(serializeMessage);
        }
    }
}