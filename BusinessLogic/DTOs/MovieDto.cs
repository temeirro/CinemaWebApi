﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class MovieDto
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; } 
        public TimeSpan Duration { get; set; }
         public IEnumerable<GenreDto>? Genres { get; set; }
    }
}
