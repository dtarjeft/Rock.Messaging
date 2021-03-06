﻿namespace Rock.Messaging.NamedPipes
{
    /// <summary>
    /// Contains various settings required by <see cref="NamedPipeQueueConsumer"/>
    /// and <see cref="NamedPipeQueueProducer"/>.
    /// </summary>
    public interface INamedPipeConfig
    {
        /// <summary>
        /// Gets the name of the named pipe.
        /// </summary>
        string PipeName { get; }

        /// <summary>
        /// Gets whether messages should be compressed.
        /// </summary>
        bool Compressed { get; }
    }
}