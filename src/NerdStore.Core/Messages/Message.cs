using System;

namespace NerdStore.Core.Messages
{
    public abstract class Message
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        public Message()
        {
            MessageType = GetType().Name;
        }

        public Message(string messageType, Guid aggregateId)
        {
            MessageType = messageType;
            AggregateId = aggregateId;
        }
    }
}
