   
using Checker.state;
using Fluxor;

   
   
     public class ErrorFeature : Feature<ErrorState>
    {
        public override string GetName() => "Error";

        protected override ErrorState GetInitialState() => new ErrorState(false);
    }
