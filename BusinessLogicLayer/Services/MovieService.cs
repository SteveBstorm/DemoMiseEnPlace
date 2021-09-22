using BusinessLogicLayer.Interface;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Tools;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepo;

        public MovieService(IMovieRepository MovieRepo)
        {
            _movieRepo = MovieRepo;
        }
        public void Delete(int Id)
        {
            if (_movieRepo.GetById(Id).ToBLL().IsFavorite)
            {
                throw new InvalidOperationException();
            }
            _movieRepo.Delete(Id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movieRepo.GetAll().Select(x => x.ToBLL());
        }

        public Movie GetById(int Id)
        {
            Movie currentMovie = _movieRepo.GetById(Id).ToBLL();
            currentMovie.Casting = _movieRepo.GetCastingByMovieId(Id).Select(x => x.ToBLL());

            return currentMovie;

        }
    }
}
