﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RdpCreator.Properties;

namespace RdpCreator
{
    /*    SELECT A1.ID ,A1.Name,A2.Name as Type
    FROM  Attributes A1 join  Attributes A2 on A1.Type=A2.ID  
    where A1.Type>1*/


    public partial class MainForm : Form
    {
        static String  RdpDir = Path.GetTempPath();
        public MainForm()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            MySQLData.LoadData();
            lbServerAtributes.Items.AddRange(Data.Attributes.ToArray());
            cbNot.Items.AddRange(Data.Attributes.ToArray());

            foreach (TServer S in Data.Servers)
            {
                lbServers.Items.Add(S, true);
            }

            if (Settings.Default.DefaultRdpDir != "")
                RdpDir = Settings.Default.DefaultRdpDir;
                
        }

        private void UpdateServerList()
        {
            HashSet<int> HasAttribute = new HashSet<int>(from TServerAtribute I in lbServerAtributes.CheckedItems
                                                select I.ID);

            HashSet<int> NotHasAttribute = new HashSet<int>(from TServerAtribute I in cbNot.CheckedItems
                                                         select I.ID);


            IEnumerable<TServer> res1 = from TServer S in Data.Servers
                                        where HasAttribute.IsSubsetOf(S.Attributes)  &&  NotHasAttribute.Intersect(S.Attributes).Count()==0
                                        select S;
            lbServers.Items.Clear();

            foreach (TServer S in res1)
            {
                lbServers.Items.Add(S, cbSelect.Checked);
            }



            UpdateServersCount();
            
            /*
            tbDebug.Items.Clear();

            foreach (int x in res)
            {

                tbDebug.Items.Add(x);

            }
             */
        }

        private void UpdateServersCount()
        { 
          StatusBar.Text = String.Format("Серверов:{0} Выбрано:{1}", lbServers.Items.Count, lbServers.CheckedItems.Count);
        }

        private void CreateRDP()
        {
            IEnumerable<TUserInfo> product =
             from String UserLogin in tbLogins.Lines
             from TServer S in lbServers.CheckedItems
             select new TUserInfo { Login = UserLogin, ServerIP = S.IP, ServerName = S.RdpName, Domain = (S.Domain ? "Mechel" : "") };

            
            StringCollection FileList = new StringCollection();
            foreach (TUserInfo U in product)
            {
                string RdpFile = RDPLink.CreateRDP(U, RdpDir);
                FileList.Add(RdpFile);
                tbDebug.Items.Add(RdpFile);
            }

            if (cbRdpCopyToClipboard.Checked) //Clipboard
            {
                Clipboard.SetFileDropList(FileList);
            }

            System.Diagnostics.Process.Start("IExplore.exe", RdpDir);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CreateRDP();

        }

        private void lbServerAtributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateServerList();

        }

        private void lbServerAtributes_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateServerList();
        }

        private void lbServerAtributes_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateServerList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          /*  tbDebug.Items.Clear();
            tbDebug.Items.Add(Transliteration.Front(tbLogins.Text));*/
        }

        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lbServers.Items.Count; i++)
            {
                lbServers.SetItemChecked(i, cbSelect.Checked);

            }
            UpdateServersCount();
        }

        private void lbServers_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateServersCount();
        }

        private void lbServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateServersCount();
        }

        private void lbServers_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateServersCount();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }



        private void cbFilters_CheckedChanged(object sender, EventArgs e)
        {
            scMainLeft.Panel1Collapsed = !cbFilters.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            if (lbServers.SelectedItem!=null)
            tbDebug.Items.Add(
            RegisterLocalUser.CreateLocalUser("TestUser", "Full Test User Name", "Qwerty1", (TServer)lbServers.SelectedItem)
            );
        private void bCreateList_Click(object sender, EventArgs e)
        {
            tbDebug.Items.Clear();

            tbDebug.Items.AddRange((from TServer S in lbServers.CheckedItems select S.IP).ToArray());
        }

        private void tsSaveToFile_Click(object sender, EventArgs e)
        {
                DialogResult R = saveFileDialog.ShowDialog();
                if (R == DialogResult.OK)
                {
                    String FileName = saveFileDialog.FileName;

                    FileStream F = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter SW = new StreamWriter(F, System.Text.Encoding.Default);
                    foreach (String S in tbDebug.Items)
                    {
                        SW.WriteLine(S);
                    }
                    SW.Flush();
                    F.Close();
                }
        }

        private void tsCopytoClipboard_Click(object sender, EventArgs e)
        {
              String[] S = new String[tbDebug.Items.Count];
              tbDebug.Items.CopyTo(S, 0);
              Clipboard.SetText(String.Join("\n",S));
        }
    }
}
