﻿namespace App.EventHandler.Impl.Order
{
    using Event.Order;
    using App.EventHandler.Order;
    using System;
    using Common.Logging;
    using Common.DI;

    public class OrderEventHandler : IOrderEventHandler
    {
        private ILogger logger;
        public OrderEventHandler()
        {
            this.logger = IoC.Container.Resolve<ILogger>();
        }

        public void Execute(OnOrderCreated ev)
        {
            this.logger.Info("OnOrderCreated:{0}", ev.OrderId);
        }

        public void Execute(OnOrderLineItemAdded ev)
        {
            this.logger.Info("OnOrderLineItemAdded:{0}", ev.Price);
        }

        public void Execute(OnCustomerDetailChanged ev)
        {
            this.logger.Info("OnCustomerDetailChanged:{0}", ev.CustomerName);
        }
    }
}
