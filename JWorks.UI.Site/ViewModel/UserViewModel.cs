using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWorks.UI.Site.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string NmName { get; set; }
        public string NmPassword { get; set; }
        public System.DateTime DtSystem { get; set; }
    }
}