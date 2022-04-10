using System;
using System.Collections.Generic;
using System.Text;

namespace MailTAsk
{
    class MailMessageNotValidException:Exception
    {
        public MailMessageNotValidException(string message):base(message)
        {}
    }
}
