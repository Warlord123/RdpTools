using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace RdpCreator
{
    class RegisterLocalUser
    {
        //http://support.microsoft.com/kb/306273
        //http://www.gotdotnet.ru/blogs/sergeyhomyuk/10326/
        public static String CreateLocalUser(string login, string fullName, string password, TServer Server)
        {
            DirectoryEntry root = new DirectoryEntry(string.Format("WinNT://{0},computer", Server.IP));
            using (DirectoryEntry user = root.Children.Add(login, "user"))
            {
                try
                {
                    user.Properties["FullName"].Value = fullName;
                    user.Properties["Description"].Value = DateTime.Now.ToString();
                    user.Invoke("SetPassword", new object[] { password });
                    user.CommitChanges();

                    string UserPath = user.Path.ToString().Replace(Server.IP, Server.Name);


                    DirectoryEntry grp = root.Children.Find("Спутник ОТЦ3 Челябинск", "group");
                    if (grp != null) { grp.Invoke("Add", new object[] { UserPath }); }

                    /* */

                    return String.Format( "Пользователь {0} создан на сервере {1}.",login,Server);



                }
                catch (COMException e)
                {
                    //if (e.ErrorCode == -2147022672)
                    return e.Message;

                }
            }
        }


        //2. Создание группы:
        public static void CreateLocalGroup(string name, string description)
        {
            var root = new DirectoryEntry(string.Format("WinNT://{0},computer", Environment.MachineName));
            using (var group = root.Children.Add(name, "group"))
            {
                group.Invoke("Put", new object[] { "description", description });
                group.CommitChanges();
            }
        }

        //3. Добавление пользователя в группу:
        public static void AddLocalUserToLocalGroup(string userName, string groupName)
        {
            string groupPath = string.Format("WinNT://{0}/{1},group", Environment.MachineName, groupName);
            string userPath = string.Format("WinNT://{0}/{1},user", Environment.MachineName, userName);
            var root = new DirectoryEntry(groupPath);
            root.Invoke("Add", new object[] { userPath });
            root.CommitChanges();
        }

        //4. Проверка, существует ли группа с заданным именем:
        public static bool IsLocalGroupExists(string name)
        {
            var root = new DirectoryEntry(string.Format("WinNT://{0},computer", Environment.MachineName));
            try
            {
                root.Children.Find(name, "group");
                return true;
            }
            catch (COMException e)
            {
                if (e.ErrorCode == -2147022676)
                    return false;
                throw;
            }
        }

        //5. Проверка, является ли пользователь членом группы:
        public static bool IsUserInLocalGroup(string userName, string groupName)
        {
            var root = new DirectoryEntry(string.Format("WinNT://{0},computer", Environment.MachineName));
            root = root.Children.Find(userName, "user");
            var groups = root.Invoke("groups");
            foreach (var group in (IEnumerable<DirectoryEntry>)groups)
            {
                var groupEntry = new DirectoryEntry(group);
                if (string.Equals(groupEntry.Name, groupName, StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }
            return false;
        }

    }
}
