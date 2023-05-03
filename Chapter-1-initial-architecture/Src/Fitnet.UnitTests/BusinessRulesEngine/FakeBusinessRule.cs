using EvolutionaryArchitecture.Fitnet.Shared.BusinessRulesEngine;

namespace EvolutionaryArchitecture.Fitnet.UnitTests.BusinessRulesEngine;

internal sealed class FakeBusinessRule : IBusinessRule
{
    private readonly int _someNumber;
    
    internal FakeBusinessRule(int someNumber) => 
        _someNumber = someNumber;

    public bool IsMet() => _someNumber > 10;

    public string Error => "Fake business rule was not met";
}