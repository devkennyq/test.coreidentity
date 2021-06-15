﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace test.coreidentity.core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Guid ExternalKey { get; set; }
    }
}
