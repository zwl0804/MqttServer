using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Adapter;
using MQTTnet.Packets;
using MQTTnet.Server;

namespace MqttServer
{
    public partial class Form1 : Form
    {
        MQTTnet.Server.IMqttServer server;
        public Form1()
        {
            InitializeComponent();
            var ipList = new List<string>();
            var ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var item in ips)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    ipList.Add(item.ToString());
            }
            comb_ServerIP.DataSource = ipList;
            server = new MqttFactory().CreateMqttServer();
        }

        [Obsolete]
        private Task ConnectEventFunc(MqttConnectionValidatorContext context)
        {
            return Task.Run(() =>
            {
                if (!(context.Username == "admin"))
                {
                    context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                    return;
                }
                if (context.Password != "123456")
                {
                    context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                    return;
                }

            });
        }

        [Obsolete]
        private void ConnectEventAction(MqttConnectionValidatorContext context)
        {
            if (!(context.Username == "admin"))
            {
                context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                return;
            }
            if (context.Password != "123456")
            {
                context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                return;
            }
        }
        [Obsolete]
        private void btn_ServerStart_Click(object sender, EventArgs e)
        {
            IMqttServerOptions options = new MqttServerOptions()
            {
                ConnectionValidator = new MqttServerConnectionValidatorDelegate(ConnectEventAction),
            };
            server.StartAsync(options);
            if (server.IsStarted)
                MessageBox.Show("Server Connect Success");
            else
                MessageBox.Show("Server Connect Fail");
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
            server.PublishAsync(new MqttApplicationMessage()
            {
                Topic = "test",
                Retain = true,
                QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce,
                Payload = new byte[] { 1, 2 },
            });
        }

        private void btn_ServerStop_Click(object sender, EventArgs e)
        {
            server.StopAsync();
        }
    }
}
