﻿namespace Rock.Messaging.RabbitMQ
{
    public interface IRabbitSessionConfiguration
    {
        /// <summary>
        /// Colloquial name of the queue. Use this to fetch the queue within your application.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Where the message is going. Form: HostName:PortNum
        /// </summary>
        string ExchangeUrl { get; }

        /// <summary>
        /// The vHost for your application. 
        /// vHost (or "Virtual Host" if you hate abbreviations) is basically a namespace for your queues.
        /// Note that this is different from the HTTP sense of "virtual host."
        /// </summary>
        string vHost { get; }

        /// <summary>
        /// In "topic"-style Exchanges, this key allows the exchange to route inbound messages to the appropriate queues.
        /// </summary>
        /// <remarks>
        /// These keys can be matched via wild card. Further reading for the curious: https://www.rabbitmq.com/tutorials/tutorial-five-python.html
        /// </remarks>
        string RoutingKey { get; }

        /// <summary>
        /// User name for the queue.
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// Password for the queue.
        /// </summary>
        string Password { get; }
        
        /// <summary>
        /// Message Consumers listen to Queues.
        /// </summary>
        string QueueName { get; }

        /// <summary>
        /// Message Publishers write to Exchanges, which route messages to Queues via rules set by its ExchangeType.
        /// </summary>
        string Exchange { get; }

        /// <summary>
        /// What sort of Exchange to define- This can be "topic", "direct", "fanout", or "headers".
        /// </summary>
        /// <remarks>
        /// Further reading for the curious can be found here: https://www.rabbitmq.com/tutorials/tutorial-three-python.html
        /// </remarks>
        string ExchangeType { get; }

        /// <summary>
        /// Whether or not your application would like to control acknowledging the message. 
        /// If this is true, the message will ack after your application performs its action on message received.
        /// </summary>
        bool AutoAcknowledge { get; }

        /// <summary>
        /// The maximum number of requests that your Receiver will handle at a time.
        /// Optional.
        /// </summary>
        ushort MaxRequests { get; }
       
        //TODO: Add Validate()?
    }
}