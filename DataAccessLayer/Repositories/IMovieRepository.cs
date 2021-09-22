using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories
{
    public interface IMovieRepository : IBaseRepository<Movie, int>
    {
        IEnumerable<Actor> GetCastingByMovieId(int MovieId);
    }
}
