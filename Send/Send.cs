using System;
using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Exceptions;

namespace RmqTutorial
{
    class Send
    {
        static void Main(string[] args)
        {

            //Eksempel på connection parametere i klient(perl):
            //    $mq->connect("mq-qa.infotorg.no", {
            //    user => "Q112928", 
            //    password => "MDPW112928", 
            //    vhost => "/masterdata-qa",
            //    port => 5671, 
            //    timeout => 30,
            //    ssl => 1,          
            //    ssl_verify_host => 1,         
            //    ssl_cacert => "$path/cacert.pem",         #Path til klientens cacert.pem
            //    ssl_init => 1
            //    } );
            // Kø-navn: K112928.masterdata-qa.ajourhold.NSB
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
                SslOption ssl = new SslOption() {
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
                    channel.QueueDeclare(queue, true, false, false, null);

                    string message = "Hello World!";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
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
