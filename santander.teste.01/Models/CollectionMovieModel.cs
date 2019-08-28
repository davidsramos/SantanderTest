using System;
using System.Collections.Generic;
using System.Text;

namespace santander.teste._01.Models
{
    public class CollectionMovieModel
    {
        public List<MovieModel> Search { get; set; }
        public int TotalResults { get; set; }
        public bool Response { get; set; }        
    }
}
