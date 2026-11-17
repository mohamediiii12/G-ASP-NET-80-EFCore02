using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_80_EFCore02.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string? Biography { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
    }
}
