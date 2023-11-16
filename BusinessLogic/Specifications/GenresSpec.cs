using Ardalis.Specification;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public static class GenresSpec
    {
        public class OrderByName : Specification<Genre>
        {
            public OrderByName()
            {
                Query
                    .OrderBy(x => x.Name)
                    .Include(x => x.Movies)
                    .ThenInclude(x => x.Movie);
            }
        }

        public class ById : Specification<Genre>
        {
            public ById(int id)
            {
                Query
                     .Where(x => x.Id == id)
                    .Include(x => x.Movies)
                    .ThenInclude(x => x.Movie)
                  ;
            }
        }

    }
}
