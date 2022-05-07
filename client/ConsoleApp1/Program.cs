// See https://aka.ms/new-console-template for more information

using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Text;

//Console.WriteLine("Hello, World!");
MqttClient client = new MqttClient("goose.rmq2.cloudamqp.com");
client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
string clientId = Guid.NewGuid().ToString();
client.Connect(clientId, "lwpfmkvp:lwpfmkvp", "ONy0uB8sESyinHD2hRrJ-5Q9hqnUp-4M");
client.Subscribe(new string[] { "#" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
{
    //throw new NotImplementedException();
    Console.WriteLine(Encoding.UTF8.GetString(e.Message));
    
}