using CuaHangBanThucAn.GUI;
using CuaHangBanThucAn.Controller;

namespace CuaHangBanThucAn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MyHttpServer server = new MyHttpServer(new string[] { "http://localhost:8080/" });
            await server.StartAsync();
            Application.Run(new LoginForm());
            

        }
    }
}