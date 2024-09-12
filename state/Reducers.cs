using Fluxor;

namespace Checker.state
{

public static class AuthenticationReducer
{
        [ReducerMethod]
        public static AuthenticationState ReduceLoginAction(AuthenticationState state, LoginAction action) => new AuthenticationState(true);

        [ReducerMethod]
        public static AuthenticationState ReduceLogoutAction(AuthenticationState state, LogoutAction action) => new AuthenticationState(false);

        [ReducerMethod]
public static ProfileCardState ReduceProfileCard(ProfileCardState state, GetProfileCardState action)
{
    // Returnează o nouă instanță a stării cu datele primite din acțiune
    return new ProfileCardState
    {
        HomeAddress = action.State.HomeAddress,
        Country = action.State.Country,
        County = action.State.County,
        Occupation = action.State.Occupation,
        Image = action.State.Image
        // Adaugă și alte proprietăți dacă este necesar
    };
}
    
    }
}