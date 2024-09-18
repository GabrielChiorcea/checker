
using Fluxor;

namespace Checker.state
{
    public class ProfileCardFeature : Feature<ProfileCardState>
    {
        public override string GetName() => "ProfileCard";

        protected override ProfileCardState GetInitialState() =>
            new ProfileCardState(string.Empty, string.Empty, string.Empty, string.Empty, new byte[0]);
    }
}