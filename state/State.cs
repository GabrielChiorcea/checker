using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Checker.Models;
using Fluxor;


namespace Checker.state
{



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
        public byte[] Image { get; set; }

        public ProfileCardState(string homeAddress, string country, string county, string occupation, string fullname, byte[] image)
        {
            HomeAddress = homeAddress;
            Country = country;
            County = county;
            Occupation = occupation;
            Image = image;
            FullName = fullname;
        }

        // Parameterless constructor for cases where you want to set properties later
        public ProfileCardState() { }
    }


public class SocialMediaState
{
        public string LinkedIn { get; }
        public string FaceBook { get; }
        public string GitHub { get; }
        public string Instagram { get; }
        public string Twitter { get; }
        public string Youtube { get; }


    public SocialMediaState(string linkedIn, string faceBook, string gitHub, string instagram, string twitter, string youtube)
    {
        LinkedIn = linkedIn;
        FaceBook = faceBook;
        GitHub = gitHub;
        Instagram = instagram;
        Twitter = twitter;
        Youtube = youtube;
    }

}

}