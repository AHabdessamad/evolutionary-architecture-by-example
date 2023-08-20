namespace EvolutionaryArchitecture.Fitnet.IntegrationTests.Shared.Events.EventBus.InMemory;

using EvolutionaryArchitecture.Fitnet.Common.Events;

internal sealed class TestEventConsumer: IIntegrationEventHandler<FakeEvent>
{
    public Task Handle(FakeEvent @event, CancellationToken cancellationToken)
    {
        @event.MarkAsConsumed();
        return Task.CompletedTask;
    }
}