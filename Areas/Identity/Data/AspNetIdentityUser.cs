using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetIdentity.Model;
using Microsoft.AspNetCore.Identity;

namespace AspNetIdentity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AspNetIdentityUser class
public class AspNetIdentityUser : IdentityUser
{
    public List<Note> Notes { get; set; } 
}

