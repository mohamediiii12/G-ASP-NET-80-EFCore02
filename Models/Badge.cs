using G_ASP_NET_80_EFCore02.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_80_EFCore02.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public int BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier    { get; set; }
    }
}
