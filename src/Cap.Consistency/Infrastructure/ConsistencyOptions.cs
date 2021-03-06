﻿using Cap.Consistency;

namespace Cap.Consistency.Infrastructure
{
    /// <summary>
    /// Represents all the options you can use to configure the system.
    /// </summary>
    public class ConsistencyOptions
    {
        public string BrokerUrlList { get; set; } = "localhost:9092";
    }
}