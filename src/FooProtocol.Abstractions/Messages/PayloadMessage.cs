using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooProtocol.Abstractions.Messages
{
    public record PayloadMessage(int Source, int Destination, string Payload) : MessageBase(MessageType.Payload);
}