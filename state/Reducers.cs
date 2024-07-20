using Fluxor;

namespace Checker.state
{

public static class AuthenticationReducer
{
    [ReducerMethod]
    public static AuthenticationState ReduceLoginAction(AuthenticationState state, LoginAction action)
    {
        return new AuthenticationState(true);
    }

    [ReducerMethod]
    public static AuthenticationState ReduceLogoutAction(AuthenticationState state, LogoutAction action)
    {
        return new AuthenticationState(false);
    }
}
}