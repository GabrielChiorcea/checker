using Fluxor;

namespace Checker.state
{

    public static class AuthenticationReducer
    {
        [ReducerMethod]
        public static AuthenticationState ReduceLoginAction(AuthenticationState state, LoginAction action) => new AuthenticationState(true);

        [ReducerMethod]
        public static AuthenticationState ReduceLogoutAction(AuthenticationState state, LogoutAction action) => new AuthenticationState(false);


    }

public static class ProfileCardReducer
{
    [ReducerMethod]
    public static ProfileCardState ReduceProfileCard(ProfileCardState state, GetProfileCardState action)
    {
        // Return a new instance of the state with the data received from the action
        return new ProfileCardState(
            action.State.HomeAddress,
            action.State.Country,
            action.State.County,
            action.State.Occupation,
            action.State.Image
        );
    }
}



}