using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Configuration;

namespace Servico
{
    public partial class Service1 : ServiceBase
    {
      private  Timer timer1;
      private readonly int _interval = Convert.ToInt32(ConfigurationManager.AppSettings["timer"].ToString());
       
            public Service1()
        {
            
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           // timer1 = new Timer(new TimerCallback(timer1_Tick), null, 15000, 3600000);    
        }

        protected override void OnStop()
        {
            StreamWriter vWriter = new StreamWriter(@"c:\testeServico.txt", true);

            vWriter.WriteLine("Servico Parado: " + DateTime.Now.ToString());
            vWriter.Flush();
            vWriter.Close();
        }

        private void timer1_Tick(object sender)
        {
            StreamWriter vWriter = new StreamWriter(@"c:\testeServico.txt", true);
            vWriter.WriteLine("Servico Rodando: " + DateTime.Now.ToString());
            vWriter.WriteLine("Nome da maquina: " + Environment.MachineName);
            vWriter.WriteLine("Nome do usuário: " + Environment.UserName);
            vWriter.Flush();
            vWriter.Close();
        }
    }
}
