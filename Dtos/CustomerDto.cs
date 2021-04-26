using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string BirthDate { get; set; }

        public bool isSubscribeToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}