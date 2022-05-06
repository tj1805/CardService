using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardServide.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Card> Cards { get; set; }
    }
}
