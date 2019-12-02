using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using C-ChatDatabase.Framework;
using C-ChatDatabase.DataAccess;

using System.Net;
using System.Net.Sockets;

namespace C-ChatBox{
    class NetInfo{
        public string ipAddress;
        public void netData(string userName){
            string ip = getLocalIP();

            VChatData data = new VChatData();
            proNetInfo net = new proNetInfo();
                        
            net.IPAddress = ip;
            net.UName = userName;
            data.netInsert(net);
        }
        public string getLocalIP(){
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList){
                if (ip.AddressFamily == AddressFamily.InterNetwork){
                    ipAddress = ip.ToString();
                    return ipAddress;
                }
            }
            return "127.0.0.1";
        }

    }
}
