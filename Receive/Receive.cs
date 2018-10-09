using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using System;
using System.Text;

namespace Receive
{
    class Receive
    {
        static void Main(string[] args)
        {
            string hostname = "mq-qa.infotorg.no";
            string username = "Q112928";
            string password = "MDPW112928";
            int port = 5671;
            string virtualhost = "/masterdata-qa";
            string queue = "K112928.masterdata-qa.ajourhold.NSB";
            //string cacertfile = @"P:\Git\howieoak\howieoak\RmqTutorial\cacert.pem";
            string cacertfile = @"P:\Git\howieoak\howieoak\RmqTutorial\infotorg.cer";

            try
            {
                SslOption ssl = new SslOption()
                {
                    Enabled = true,
                    ServerName = hostname,
                    CertPassphrase = password,
                    CertPath = cacertfile
                };


                var factory = new ConnectionFactory()
                {
                    HostName = hostname,
                    UserName = username,
                    Password = password,
                    Port = port,
                    VirtualHost = virtualhost,
                    //RequestedConnectionTimeout = 30,
                    Ssl = ssl

                };

                Console.WriteLine("Connecting...");
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: queue, durable: true, exclusive: false, autoDelete: false, arguments: null);

                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);
                    };
                    channel.BasicConsume(queue: queue, autoAck: true, consumer: consumer);

                }
            }
            catch (BrokerUnreachableException bex)
            {
                Exception ex = bex;
                while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("inner:");
                    ex = ex.InnerException;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();


        }
    }
}


