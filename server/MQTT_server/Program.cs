// See https://aka.ms/new-console-template for more information
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

Console.WriteLine("Hello, World!");

MqttClient client = new MqttClient("goose.rmq2.cloudamqp.com");

string clientId = Guid.NewGuid().ToString();
client.Connect(clientId, "lwpfmkvp:lwpfmkvp", "ONy0uB8sESyinHD2hRrJ-5Q9hqnUp-4M");

string strValue = Convert.ToString("Wojciech Wołoszka");

client.Publish("student/Krzysztof Bogucki", Encoding.UTF8.GetBytes(strValue), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
