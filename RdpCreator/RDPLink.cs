using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using RdpCreator.Properties;

namespace RdpCreator
{


    public class TUserInfo
    {

        public String ServerIP;
        public String ServerName;
        public String Login;
        public String Domain;
        public String FIO;
        public String LNAdress;
        public String Department;
        public String Subject;
        public String Text;
        public String Footer;

        public TUserInfo()
        { }

        public TUserInfo(String aServerIP,
                   String aServerName,
                   String aLogin,
                   String aDomain,
                   String aFIO,
                   String aLNAdress,
                   String aDepartment,
                   String aSubject,
                   String aText,
                   String aFooter)
        {
            ServerIP = aServerIP;
            ServerName = aServerName;
            Login = aLogin;
            Domain = aDomain;
            FIO = aFIO;
            LNAdress = aLNAdress;
            Department = aDepartment;
            Subject = aSubject;
            Text = aText;
            Footer = aFooter;
        }

    }
    class RDPLink
    {

        public static String CreateRDP(TUserInfo U, String Dir)
        {
            String FileName;
            FileName = String.Format("{3}{0}_{1}{2}", U.ServerName, U.Login, ".rdp", Dir);
            String Templ = Settings.Default.RdpTemplate;
            FileStream F = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(F, System.Text.Encoding.Default);
            SW.Write(Templ, U.ServerIP, U.Login, U.Domain);
            SW.Flush();
            F.Close();
            return FileName;
        }
    }
}
