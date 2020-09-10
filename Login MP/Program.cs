using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_MP
{
    public delegate void InputHandler(State state, String args);
    public delegate void StateObs(State state);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CredentialsMP model = new CredentialsMP();
            ControllerMP controller = new ControllerMP(model);
            LoginMp view = new LoginMp(controller.handleEvents);
            controller.registerObs(view.DisplayState);
            Application.Run();
        }
    }
}
