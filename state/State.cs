using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Checker.Models;
using Fluxor;


namespace Checker.state
{


    public class ErrorState
    {
        public bool HasError { get; } = false;

        public ErrorState(bool haserror)
        {
            HasError = haserror;
        }
    }


    public class AuthenticationState
{
    public bool IsLoggedIn { get; } = false;

    public AuthenticationState(bool isLoggedIn)
    {
        IsLoggedIn = isLoggedIn;
    }
}


 public class ProfileCardState
    {
        public string HomeAddress { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Occupation { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public string LinkedIn { get; set; }
        public string FaceBook { get; set; }
        public string GitHub { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string Description { get; set; }

        public ProfileCardState(string homeAddress, string country, string county, string occupation, string fullname, string email, byte[] image, string linkedIn, string faceBook, string gitHub, string instagram, string twitter, string youtube, string description)
        {
            HomeAddress = homeAddress;
            Country = country;
            County = county;
            Occupation = occupation;
            Image = image;
            FullName = fullname;
            Email = email;
            LinkedIn = linkedIn;
            FaceBook = faceBook;
            GitHub = gitHub;
            Instagram = instagram;
            Twitter = twitter;
            Youtube = youtube;
            Description = description;
        }
        

        // Parameterless constructor for cases where you want to set properties later
        public ProfileCardState() { }
    }


    

}