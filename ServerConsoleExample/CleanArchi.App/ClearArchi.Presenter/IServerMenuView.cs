using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Presenter
{
    public interface IServerMenuView
    {
        void ShowMenu(string header, List<string> options);
        void CleanMenu();
        void ShowStatus(string statusString);
    }
}
