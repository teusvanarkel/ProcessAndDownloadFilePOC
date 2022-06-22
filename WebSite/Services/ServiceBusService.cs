using Azure.Messaging.ServiceBus;

namespace WebSite.Services
{
    public class ServiceBusService
    {
        private ServiceBusClient _serviceBusCLient;
        private string _serviceBusConnection = "Endpoint=sb://processanddownloadfilepocsb.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9QHLCy9c8aje3E5dpo0RtGetlG2voKfqbu4ueCm4xZM=";
        ServiceBusService()
        {
            _serviceBusCLient = new ServiceBusClient(_serviceBusConnection);
           var receiver = _serviceBusCLient.CreateReceiver("myqueue");
            receiver.
        }


    }
}