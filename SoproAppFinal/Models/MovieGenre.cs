namespace SoproAppFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieGenre")]
    public partial class MovieGenre
    {
        public Guid ID { get; set; }

        public Guid? MovieID { get; set; }

        public Guid? GenreID { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
