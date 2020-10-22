using System;
using System.Collections.Generic;
using System.Text;

namespace EventsSampleApp
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail Service: Sending an email... \"{0}\" encoded successfully!",
                args.Video.Title);
        }
    }
}
