﻿using System.Collections.Generic;

namespace MovieStore.API.Entities
{
    public class Actor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}