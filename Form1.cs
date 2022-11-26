using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domainconner
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Mess = new System.Collections.ArrayList();
        System.Collections.ArrayList ipms = new System.Collections.ArrayList();
        System.Collections.ArrayList domainips = new System.Collections.ArrayList();
        public bool Compa = false;

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
               
        }

            private void StartButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            ipms = new System.Collections.ArrayList();
            domainips = new System.Collections.ArrayList();
            Compa = false;
            Thread thread = new Thread(new ThreadStart(run));
            thread.Start();
        }

        public void run()
        {
            int number = 0;
            bool iswhile = true;
            while (iswhile)
            {
                try
                {
                    RealmComboBox.SelectedIndex = number;
                    //iswhile = true;
                }
                catch
                {
                    LogPrint("终止");

                    if (checkBox2.Checked)
                    {
                        System.Media.SystemSounds.Beep.Play();
                    }

                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox4.Enabled = true;
                    iswhile = false;
                }
                if (iswhile)
                {
                    LogPrint("当前检测'" + RealmComboBox.Text + "'所记录IP的通断情况");
                    Compa = false;
                    for (int i = 0; i < IPBox.Lines.Length; i++)
                    {
                        int ms = PingIp(IPBox.Lines[i]);
                        if (ms!=-1)
                        {
                            LogPrint("[成功,延迟 "+ms.ToString()+"ms]" + RealmComboBox.Text + " 中的 " + IPBox.Lines[i]);
                            Compa = true;
                            UsefulWrite(IPBox.Lines[i], RealmComboBox.Text, ms);
                            if (!checkBox1.Checked)
                            {
                                HostsWrite(IPBox.Lines[i], RealmComboBox.Text + "     #" + ms.ToString() + "ms");
                            }
                        }
                        else
                        {
                            LogPrint("[失败] " + RealmComboBox.Text + " 中的 " + IPBox.Lines[i]);
                        }
                    }
                    if (checkBox1.Checked&& Compa)
                    {
                        Comparison();
                    }
                    else if (checkBox1.Checked && !Compa)
                    {
                        LogPrint("无可用对象");
                    }
                }
                number++;

            }
        }

        public void UsefulWrite(string IP, string domain, int ms)
        {
            domainips.Add(IP);
            ipms.Add(ms);
        }

        public void Comparison()
        {
            LogPrint("比较 " + RealmComboBox.Text + " 中延迟最小的IP...");
            LogPrint("----------------------------------------------");
            for (int i = 0; i < ipms.Count; i++)
            {
                LogPrint(domainips[i].ToString() + " " + RealmComboBox.Text + "     #" + ipms[i].ToString());
            }
            LogPrint("----------------------------------------------");
            int Bestms = (int)ipms[0];
            int BestNumber = 0;
            string BestIP="";
            for (int i = 0; i < ipms.Count; i++)
            {
                if (Bestms > (int)ipms[i])
                {
                    Bestms = (int)ipms[i];
                    BestNumber = i;
                    BestIP = domainips[i].ToString();
                }
            }
            LogPrint(RealmComboBox.Text + " 中 "+ BestIP+" 最小延迟为 "+ Bestms.ToString()+"ms");
            LogPrint("----------------------------------------------");
            HostsWrite(BestIP, RealmComboBox.Text);

            ipms = new System.Collections.ArrayList();
            domainips = new System.Collections.ArrayList();
        }

        public void HostsWrite(string ip, string host)
        {
            string txt = ip + " " + host;
            HostsBox.Text = HostsBox.Text + txt + Environment.NewLine;
        }
        public void LogPrint(string Log)
        {
            LogBox.Text = LogBox.Text + Log + Environment.NewLine;
        }

        private static int PingIp(string strIP)
        {
            int bRet = -1;
            try
            {
                Ping pingSend = new Ping();
                PingReply reply = pingSend.Send(strIP, 30);
                if (reply.Status == IPStatus.Success)
                    bRet = Convert.ToInt32(reply.RoundtripTime);
            }
            catch (Exception)
            {
                bRet = -1;
            }
            return bRet;
        }

        private void readelbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除'" + RealmComboBox.Text + "'相关信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < Mess.Count; i++)
                {
                    string[] sArray = Mess[i].ToString().Split('*');
                    if (sArray[0] == RealmComboBox.Text)
                    { 
                        Mess.RemoveAt(i);
                        i = 999999;
                    }
                }


                IPBox.Text = String.Empty;
                RealmComboBox.Items.Remove(RealmComboBox.Text);
                RealmComboBox.Text = String.Empty;
                RealmComboBox.ResetText();
            }
        }
        private void reaaddbutton_Click(object sender, EventArgs e)
        {
            //Mess = new System.Collections.ArrayList();
            if (RealmBox.Text != String.Empty)
            {
                if (!RealmComboBox.Items.Contains(RealmBox.Text))
                {
                    string txt = RealmBox.Text + "*" + IPBox.Text;
                    RealmComboBox.Items.Add(RealmBox.Text);
                    RealmComboBox.Text = RealmBox.Text;
                    RealmBox.Text = String.Empty;
                    //IPBox.Text = String.Empty;
                    Mess.Add(txt);
                }
            }
            else {
                MessageBox.Show("值为空或已在列表中" + Environment.NewLine + "请选择该项在列出IP中修改", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RealmComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Mess.Count; i++)
            {
                string[] sArray = Mess[i].ToString().Split('*');
                if (sArray[0] == RealmComboBox.Text)
                {
                    i = 999999;
                    IPBox.Text = sArray[1];
                    RealmBox.Text = String.Empty;
                    //reaaddbutton.Text = "修改";
                }
            }
            if (RealmComboBox.Text == string.Empty)
            {
                readelbutton.Enabled = false;
            }
            else { 
                readelbutton.Enabled = true;
            }
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            LogBox.SelectionStart = this.LogBox.Text.Length;
            LogBox.ScrollToCaret();
        }

        private void HostsBox_TextChanged(object sender, EventArgs e)
        {
            HostsBox.SelectionStart = this.HostsBox.Text.Length;
            HostsBox.ScrollToCaret();
        }

        private void RealmBox_TextChanged(object sender, EventArgs e)
        {
            if (RealmBox.Text != String.Empty&&RealmComboBox.Text!=String.Empty) {
                reaaddbutton.Text = "添加";
            }
            if (RealmComboBox.Text == String.Empty && RealmComboBox.Text != String.Empty)
            {
                //reaaddbutton.Text = "修改";
            }
        }
    }
}