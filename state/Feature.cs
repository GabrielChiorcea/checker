
using Fluxor;

namespace Checker.state
{
    public class ProfileCardFeature : Feature<ProfileCardState>
    {
        public override string GetName() => "ProfileCard";

        protected override ProfileCardState GetInitialState() =>
            new ProfileCardState(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, new byte[0]);
    }

    public class SocialMediaFeature : Feature<SocialMediaState>
    {
        public override string GetName() => "SocialMedia";

        protected override SocialMediaState GetInitialState() =>
            new SocialMediaState(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    }
}