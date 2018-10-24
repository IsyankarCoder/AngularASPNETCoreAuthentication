using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonWebTokenWithAngularAspNetCore.Models.Entities
{
    public class JobSeeker:BaseEntity
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }

        public AppUser Identity { get; set; }

        public string Location { get; set; }

        public string Test { get; set; }

        public string Ahmet { get; set; }

        public string Memet { get; set; }

        public string Makarna { get; set; }

    }
}
