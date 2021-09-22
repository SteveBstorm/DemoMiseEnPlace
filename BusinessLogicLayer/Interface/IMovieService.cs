using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int Id);
        void Delete(int Id);
    }
}
