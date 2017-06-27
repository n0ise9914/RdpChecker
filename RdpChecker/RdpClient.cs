using AxMSTSCLib;
using MSTSCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RdpCracker
{
    class RdpClient : AxMsRdpClient8NotSafeForScripting
    {
        public int ItimeOutTotal , ItimeOutLog;
        public delegate void OnResponseDelegate(RdpClient sender,ResponseType type);
        public event OnResponseDelegate OnResponse;
        public delegate void OnReadyDelegate(RdpClient sender);
        public event OnReadyDelegate OnReady;
        private System.Timers.Timer timeOutTotal = new System.Timers.Timer();
        private System.Timers.Timer timeOutLog = new System.Timers.Timer();
        public RdpClient()
        {
       
            timeOutLog.Elapsed += (o, ex) => Respponse(ResponseType.LoginFailed);
        
            timeOutTotal.Elapsed += (o, ex) => Respponse(ResponseType.TimedOut);
      

            OnConnected += Rdp_OnConnected;
            OnLoginComplete += Rdp_OnLoginComplete;

            OnLogonError += Rdp_OnLogonError; 
            OnFatalError += Rdp_OnFatalError;
            OnDisconnected += Rdp_OnDisconnected;   
            
         
        }

        public object Password { get; internal set; }

        private void Respponse(ResponseType type)
        {
            timeOutTotal.Stop();
            timeOutLog.Stop();
            try
            {
                if( ResponseType.LoggedIn == type|
                    ResponseType.TimedOut == type |
                    ResponseType.LoginFailed==type |
                    ResponseType.Error == type)
                Disconnect();
            }
            catch (Exception)
            {
            }
            finally
            {
      
                OnResponse(this, type);
            }
        }


        public  void Connect(string ip,string user,string pass)
        {
            timeOutLog.Interval = ItimeOutLog;
            timeOutTotal.Interval = ItimeOutTotal;
            timeOutTotal.Start();
            Password = pass;
            Server = ip;
            UserName = user;
            IMsTscNonScriptable secured = (IMsTscNonScriptable)GetOcx();
            secured.ClearTextPassword = pass;
            Respponse(ResponseType.Connecting);
            Connect();
        }

        private void Rdp_OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
        {
            Respponse(ResponseType.Disconnected);
            OnReady(this);
        }  

        private void Rdp_OnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
        {
            Respponse(ResponseType.Error);
        }

        private void Rdp_OnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
        {
            Respponse(ResponseType.LoginFailed);
        }

        private void Rdp_OnLoginComplete(object sender, EventArgs e)
        {
            Respponse(ResponseType.LoggedIn);
        }

        private void Rdp_OnConnected(object sender, EventArgs e)
        {
            Respponse(ResponseType.Connected);
            timeOutLog.Start();
        }
    }
}
