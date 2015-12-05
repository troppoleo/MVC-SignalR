using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}
        //http://www.asp.net/signalr/overview/getting-started/tutorial-getting-started-with-signalr-and-mvc
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }


        public void sendTest(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.inviaAlClient(name, message);
        }

    }
}