
namespace ProcessKiller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Properties;
    using System.Xml;
    using System.Net;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;

   

    public class Server
    {
        public string Name { get; set; }

        public string IpAddress { get; set; }

        public string Port { get; set; }
    }



    //    <document>


    //-<ChannelList channel_name = "channel1" >


    //-< Local open="1" partitionid="1" new="0" local_name="华东电信一区">

    //<version addr = "https://dorado.sdo.com/dn/patchinfo/Public/" />

    //< update addr="http://lzg.autopatch.sdo.com/lzg/ReleaseBuild/Patch/"/>

    //<guidepage addr = "http://dn.sdo.com/project/launcher_2012/index.asp" />

    //< homepage addr="http://dn.sdo.com/"/>

    //<statetest addr = "http://115.238.22.57/default.htm" />

    //< login addr="116.211.2.151" port="14301"/>

    //<login addr = "116.211.2.153" port="14301"/>

    //</Local>

    public class DNServerInfo
    {
        // callback used to validate the certificate in an SSL conversation
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors policyErrors)
        {
            return true;
        }
        // <summary>
        /// 服务器ip定义路径
        /// </summary>
        private const String Resourcespath = "https://dorado.sdo.com/dn/sndalist/sndalist.xml";

        public static IList<Server> GetServerListFromResource()
        {
            return Resources.servers.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Select(line => line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)).Select(parts => new Server()
            {
                IpAddress = parts[0], Port = parts[1], Name = parts[2],
            }).ToList();
        }

        // <summary>
        /// 获取服务器大区
        /// </summary>
        /// <param ></param>
        /// <returns>服务器集合</returns>
        public static IList<Server> GetServerListFromResourcebyxml()
        {

            //为 SSL/TLS 安全通道建立信任关系。
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);
            
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);

            //服务器集合
            List<Server> servers = new List<Server>();

            XmlDocument doc = new XmlDocument();
            doc.Load(Resourcespath);
            XmlNode xn = doc.SelectSingleNode("document");

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;

            foreach (XmlNode local in xnl)
            {
                foreach (XmlNode item in local)
                {
                    Server Serverinfo = new Server();

                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement xe = (XmlElement)item;
                    //大区
                    Serverinfo.Name =xe.GetAttribute("local_name").ToString();
                    //ip
                    string addr = string.Empty;
                    //端口
                    string port = string.Empty;
                    // 得到Server节点的所有子节点
                    XmlNodeList xnipinfo = xe.ChildNodes;
                    //local节
                    foreach (XmlNode ipinfo in xnipinfo)
                    {
                        if (ipinfo.Name.Equals("login"))
                        {

                            XmlElement ip = (XmlElement)ipinfo;
                            addr += ip.GetAttribute("addr").ToString() + ";";
                            port += ip.GetAttribute("port").ToString() + ";";
                        }
                    }                  
                    Serverinfo.IpAddress = addr.Length>0?addr.Substring(0,addr.Length - 1):string.Empty; 
                    Serverinfo.Port = port.Length > 0 ? port.Substring(0, port.Length - 1):string.Empty;
                    servers.Add(Serverinfo);
                }
            }


            return servers ;


        }


        // <summary>
        /// 获取服务器大区(手动设置)
        /// </summary>
        /// <param ></param>
        /// <returns>服务器集合</returns>
        public static IList<Server> GetServerListbymanual()
        {
            List<Server> serverList = new List<Server>();
            if (KeySettings.Default.Ipsettingmode.Equals("manual"))
            {
                Server serverinfo = new Server();
                serverinfo.Name = KeySettings.Default.areaName;
                serverinfo.IpAddress = KeySettings.Default.Serveraddr;
                serverinfo.Port = KeySettings.Default.Serverport;
                serverList.Add(serverinfo);
                ;
            }

            return serverList;
        }
     

}
}
