using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checker.Models;

namespace Checker.state
{


public class ErrorAction { }
public class LoginAction { }

public class LogoutAction { }





public class GetErrorState{
    public string ErrorMessage { get; }

    public GetErrorState(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}

public class GetProfileCardState
{
    public ProfileCardState State { get; }

    public GetProfileCardState(ProfileCardState state)
    {
        State = state;
    }
}

 

    public class GetModalState
    {
        public ModalState State { get; }

        public GetModalState(ModalState state)
        {
            State = state;
        }
    }


}