using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace G_ASP_NET_80_EFCore02.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
    }
}
