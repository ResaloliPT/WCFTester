using System;
using Newtonsoft.Json;
using WCFTestFramework.Extensions;

namespace WCFTestFramework
{
    public class Program
    {
        public static string AppName { get; private set; } = "[WCF Tester .NetFramework]";

        public static void Main(string[] args)
        {
            StartApp();


            #region Client Instanciation & Other Setups

            //var client = Utils.GetLoggedClient<MyClient, IMyClient>(new MyClient())

            #endregion

            try
            {
                //Service Calls
                #region Service Calls

                //var result = client.MyClientMethod();

                #endregion
            }catch(Exception ex)
            {
                ConsoleEx.WriteLineWithColor("[Service Error]", ConsoleColor.Red);
                ConsoleEx.WriteLineWithColor(JsonConvert.SerializeObject(ex), ConsoleColor.Red);

            }

            Console.ReadKey();
        }

        private static void StartApp()
        {
            Console.Title = AppName;

            ConsoleEx.WriteLineWithColor(AppName, ConsoleColor.DarkBlue, ConsoleColor.Yellow);
        }
    }
}
