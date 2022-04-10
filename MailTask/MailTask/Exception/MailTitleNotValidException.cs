using System;
using System.Collections.Generic;
using System.Text;

namespace MailTAsk
{
    class MailTitleNotValidException:Exception
    {
        public MailTitleNotValidException(string message) : base(message)
        { }
    }
}
