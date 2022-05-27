namespace SoproAppFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MoviePerson")]
    public partial class MoviePerson
    {
        public Guid ID { get; set; }

        public Guid? MovieID { get; set; }

        public Guid? PersonID { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Person Person { get; set; }
    }
}
