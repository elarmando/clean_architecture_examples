using CleanArchi.Controller;
using CleanArchi.Interactor;
using CleanArchi.Presenter;
using CleanArchi.View;
using System;

namespace CleanArchi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new ServerMenuView();
            var presenter = new ServerMenuPresenter(view);
            var interactor = new ServerMenuInteractor(presenter);
            var controller = new ServerMenuController(interactor);

            interactor.ShowMenu();

            while(!controller.LastInputIsExit())
            {
                controller.HandleInput();
            }
        }
    }
}
