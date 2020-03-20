
namespace WCFTestFramework
{
    public static class Utils
    {
        public static TClient GetLoggedClient<TClient, Interface>(TClient client) where TClient : System.ServiceModel.ClientBase<Interface> where Interface : class
        {
            var loggedClient = client;


            loggedClient.Endpoint.EndpointBehaviors.Add(new LoggingBehaviour());

            return loggedClient;
        }
    }
}
