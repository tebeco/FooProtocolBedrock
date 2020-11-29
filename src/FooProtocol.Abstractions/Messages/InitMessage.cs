using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooProtocol.Abstractions.Messages
{
    public record InitMessage(int Source) : MessageBase(MessageType.Init);
}
