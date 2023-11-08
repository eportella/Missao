﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Missaol.Application.Cliente
{
    public sealed class EncantarCommandRequestHandler : IRequestHandler<EncantarCommandRequest>
    {
        IMediator Mediator { get; }
        public EncantarCommandRequestHandler(IMediator mediator)
        {
            Mediator = mediator;
        }
        public async Task Handle(EncantarCommandRequest request, CancellationToken cancellationToken)
        {
            await Mediator.Publish(new EncantadoCommandNotification(), cancellationToken);
        }
    }
}
