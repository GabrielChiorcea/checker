using Checker.state;
using Fluxor;


namespace Checker.features.Authentication
{

public class AuthenticationFeature : Feature<AuthenticationState>
{
    public override string GetName() => "Authentication";

    protected override AuthenticationState GetInitialState() => new AuthenticationState(false);
}
}