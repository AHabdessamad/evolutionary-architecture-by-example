namespace EvolutionaryArchitecture.Fitnet.Common.Infrastructure.IntegrationTests.Events.EventBus.InMemory;

using EvolutionaryArchitecture.Fitnet.Common.Infrastructure.Events;

internal record FakeEvent(Guid Id, DateTimeOffset OccurredDateTime, bool Consumed) : IIntegrationEvent
{
    private FakeEvent() : this(Guid.NewGuid(), DateTimeOffset.UtcNow, false)
    {
    }

    internal bool Consumed { get; private set; } = Consumed;

    public void MarkAsConsumed() => Consumed = true;

    public static FakeEvent Create() => new();
}
