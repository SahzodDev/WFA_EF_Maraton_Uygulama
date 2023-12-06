using Plak.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak.Domain.Entities
{
    public class Album:BaseEntity
    {
        public string AlbumName { get; set; }

        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public SalesState SalesState { get; set; }

    }
}
