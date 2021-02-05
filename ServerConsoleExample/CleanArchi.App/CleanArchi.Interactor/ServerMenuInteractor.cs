using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Interactor
{
    public class ServerMenuInteractor
    {
        private Server Server { get; set; }
        private IServerMenuPresenter Menu { get; set; }
        public ServerMenuInteractor(IServerMenuPresenter menu)
        {
            Server = new Server();
            Menu = menu;
        }

        public void ShowMenu()
        {
            Menu.ShowMenu(Server);
        }

        public void CleanMenu()
        {
            Menu.CleanMenu();
        }

        public void ShowStatus()
        {
            Menu.ShowStatus(Server);
        }
    }
}
