﻿using System;
using System.Collections.Generic;
using System.Text;
using Cap.Consistency.Abstractions;
using Cap.Consistency.Abstractions.ModelBinding;
using Cap.Consistency.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Cap.Consistency.Internal
{
    public class ConsumerInvokerFactory : IConsumerInvokerFactory
    {
        private readonly ILogger _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IModelBinder _modelBinder;

        public ConsumerInvokerFactory(
            ILoggerFactory loggerFactory,
            IModelBinder modelBinder,
            IServiceProvider serviceProvider) {

            _logger = loggerFactory.CreateLogger<ConsumerInvokerFactory>();
            _modelBinder = modelBinder;
            _serviceProvider = serviceProvider;
        }

        public IConsumerInvoker CreateInvoker(ConsumerContext consumerContext) {

            var context = new ConsumerInvokerContext(consumerContext);

            context.Result = new ConsumerInvoker(_logger, _serviceProvider, _modelBinder, consumerContext);

            return context.Result;
        }
    }
}
