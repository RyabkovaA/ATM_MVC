namespace ATMForms6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ATMModel model = new ATMModel();
            ATMView view = new ATMView();
            ATMController controller = new ATMController(model, view);
            view.UpdateView(model.State, model.Balance, model.IsConnected);
            Application.Run(view);
        }
    }
}