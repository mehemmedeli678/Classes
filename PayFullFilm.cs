using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class PayFullFilm
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Film Film { get; set; }
    }
}
