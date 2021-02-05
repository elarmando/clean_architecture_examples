using CleanArchi.Presenter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.View
{
    public class ServerMenuView : IServerMenuView
    {
        public void CleanMenu()
        {
            System.Console.Clear();
        }

        public void ShowMenu(string header, List<string> options)
        {
            System.Console.WriteLine(header);
            System.Console.WriteLine("");

            foreach(var option in options)
            {
                System.Console.WriteLine(option);
            }
        }

        public void ShowStatus(string statusString)
        {
            System.Console.WriteLine(statusString);
        }
    }
}
