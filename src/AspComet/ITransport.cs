﻿using System;
using System.Collections.Generic;
using System.Web;

namespace AspComet
{
    public interface ITransport
    {
        void SendMessages(HttpResponseBase response, IEnumerable<Message> messages);
    }
}
