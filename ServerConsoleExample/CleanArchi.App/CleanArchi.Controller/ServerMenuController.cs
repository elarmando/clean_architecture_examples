using CleanArchi.Interactor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Controller
{
    public class ServerMenuController
    {
        private ConsoleKeyInfo InputInfo { get; set; }
        private ServerMenuInteractor Menu { get; set; }

        public ServerMenuController(ServerMenuInteractor menu)
        {
            Menu = menu;
        }

        public void HandleInput()
        {
            InputInfo = Console.ReadKey();


            if (InputInfo.KeyChar == '1')
            {
                Menu.CleanMenu();
                Menu.ShowMenu();
                Menu.ShowStatus();
            }
            else if (InputInfo.KeyChar == '2')
            {
                Menu.StartServer();
                Menu.CleanMenu();
                Menu.ShowMenu();
                Menu.ShowStatus();
            }
            else if(InputInfo.KeyChar == '3')
            {
                Menu.StopServer();
                Menu.CleanMenu();
                Menu.ShowMenu();
                Menu.ShowStatus();
            }
            else if(InputInfo.KeyChar == '4')
            {
                Menu.CleanMenu();
                Menu.ShowMenu();
            }

        }

        public bool LastInputIsExit()
        {
            if (InputInfo == null)
                return false;

            return InputInfo.Key == ConsoleKey.Escape;
        }
    }
}
