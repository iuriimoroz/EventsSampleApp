using System;
using System.Collections.Generic;
using System.Text;

namespace EventsSampleApp
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending a message... \"{0}\" encoded successfully!",
                              args.Video.Title);
        }
    }
}
