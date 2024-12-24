using Fluxor;

namespace Checker.state
{
    public class ProfileCardFeature : Feature<ProfileCardState>
    {
        public override string GetName() => "ProfileCard";

        protected override ProfileCardState GetInitialState() =>
            new ProfileCardState(
                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, new byte[0], 
                string.Empty,  string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 
                string.Empty
                );
    }


    public class ModalFeature : Feature<ModalState>
    {
        public override string GetName() => "Modal";

        protected override ModalState GetInitialState() =>
            new ModalState(
                title: string.Empty,
                message: string.Empty,            
                showModal: false
            );
    }

}