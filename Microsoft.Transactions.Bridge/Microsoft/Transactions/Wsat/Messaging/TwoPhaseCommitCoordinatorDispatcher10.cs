﻿namespace Microsoft.Transactions.Wsat.Messaging
{
    using Microsoft.Transactions.Wsat.Protocol;
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single, ConcurrencyMode=ConcurrencyMode.Multiple)]
    internal class TwoPhaseCommitCoordinatorDispatcher10 : IWSTwoPhaseCommitCoordinator10, IWSTwoPhaseCommitCoordinator
    {
        private TwoPhaseCommitCoordinatorDispatcher twoPhaseCommitCoordinatorDispatcher;

        public TwoPhaseCommitCoordinatorDispatcher10(CoordinationService service, ITwoPhaseCommitCoordinator dispatch)
        {
            ProtocolVersionHelper.AssertProtocolVersion10(service.ProtocolVersion, typeof(TwoPhaseCommitCoordinatorDispatcher10), "constr");
            this.twoPhaseCommitCoordinatorDispatcher = new TwoPhaseCommitCoordinatorDispatcher(service, dispatch);
        }

        public void Aborted(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.Aborted(message);
        }

        public void Committed(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.Committed(message);
        }

        public void Prepared(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.Prepared(message);
        }

        public void ReadOnly(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.ReadOnly(message);
        }

        public void Replay(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.Replay(message);
        }

        public void WsaFault(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.WsaFault(message);
        }

        public void WsatFault(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.WsatFault(message);
        }

        public void WscoorFault(Message message)
        {
            this.twoPhaseCommitCoordinatorDispatcher.WscoorFault(message);
        }

        public System.Type ContractType
        {
            get
            {
                return typeof(IWSTwoPhaseCommitCoordinator10);
            }
        }
    }
}

