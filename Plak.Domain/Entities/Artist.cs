using Plak.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.Domain.Entities
{
    public class Artist:BaseEntity
    {
        public string ArtistName { get; set; }
        public ArtistType ArtistType { get; set; }

        public ICollection<Album> Albums { get; set; }


    }
}
