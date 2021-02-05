using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Interactor
{
    public interface IServerMenuPresenter
    {
        void ShowMenu(Server server);
        void CleanMenu();
        void ShowStatus(Server server);
    }
}
