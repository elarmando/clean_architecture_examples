using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Interactor
{
    public enum ServerStatus
    {
        Running,
        NotRunning
    }
    public class Server
    {
        public ServerStatus Status { get; set; }
        public string Name { get; set; }
        public Server()
        {
            Status = ServerStatus.NotRunning;
            Name = "Server 1.0";
        }

        public void Start()
        {
            Status = ServerStatus.Running;
        }

        public void Stop()
        {
            Status = ServerStatus.NotRunning;
        }
    }
}
