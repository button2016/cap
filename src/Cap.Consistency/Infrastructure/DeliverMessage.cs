﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cap.Consistency.Infrastructure
{
    public class DeliverMessage
    {
        /// <summary>
        /// Kafka 对应 Topic name
        /// <para>
        /// RabbitMQ 对应 RoutingKey
        /// </para>
        /// </summary>
        public string MessageKey { get; set; }


        public byte[] Body { get; set; }

        public string Value { get; set; }
    }


    public class KafkaDeliverMessage : DeliverMessage
    {

        public int Partition { get; set; }

        public long Offset { get; set; }

        public string MessageId { get; set; }
    }
}
