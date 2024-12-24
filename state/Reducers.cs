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

    public static class ErrorReducer
    {
        [ReducerMethod]
        public static ErrorState ReduceGetErrorState(ErrorState state, ErrorAction action) => new ErrorState(true);
    }

    public static class ModalReducer
    {
        [ReducerMethod]
        public static ModalState ReducerModal(ModalState state, GetModalState action) => new ModalState(action.State.Title, action.State.Message, action.State.ShowModal);

    }

 public static class ProfileCardReducer
    {
        [ReducerMethod]
        public static ProfileCardState ReduceProfileCard(ProfileCardState state, GetProfileCardState action)
        {
            return new ProfileCardState(
                action.State.HomeAddress,
                action.State.Country,
                action.State.County,
                action.State.Occupation,
                action.State.FullName,
                action.State.Email,            
                action.State.Image,
                action.State.LinkedIn,
                action.State.FaceBook,
                action.State.GitHub,
                action.State.Instagram,
                action.State.Twitter,
                action.State.Youtube,
                action.State.Description
            );
        }
    }

// public static class SocialMediaReducer
// {
//     [ReducerMethod]
//     public static SocialMediaState ReduceSocialMedia(SocialMediaState state, GetSocialMediaState action)
//     {
//         // Return a new instance of the state with the data received from the action
//         return new SocialMediaState(
//             action.State.LinkedIn,
//             action.State.FaceBook,
//             action.State.GitHub,
//             action.State.Instagram,
//             action.State.Twitter,
//             action.State.Youtube
//         );
//     }

// }

}