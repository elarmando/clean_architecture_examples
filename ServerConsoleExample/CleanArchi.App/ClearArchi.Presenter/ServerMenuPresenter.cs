using CleanArchi.Interactor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Presenter
{
    public class ServerMenuPresenter : IServerMenuPresenter
    {
        public IServerMenuView View { get; private set; }
        public ServerMenuPresenter(IServerMenuView view)
        {
            View = view;
        }

        public void ShowMenu(Server server)
        {
            var header = "Welcome to " + server.Name;
            var options = new List<string>() {
                "1.- Show Status",
                "2.- Clear"
                
            };

            View.ShowMenu(header, options);
        }

        public void CleanMenu()
        {
            View.CleanMenu();
        }

        public void ShowStatus(Server server)
        {
            var statusString = server.Status == ServerStatus.Running ? "Server is running" : "server is not running";
            View.ShowStatus(statusString);
        }
    }
}
