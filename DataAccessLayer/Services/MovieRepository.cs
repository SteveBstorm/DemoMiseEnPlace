using ADOToolbox;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class MovieRepository : IMovieRepository
    {
        private string _connectionString;

        public MovieRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");
        }

        

        public bool Delete(int Id)
        {
            Command cmd = new Command("DELETE FROM Movie WHERE Id = @Id");
            cmd.AddParameter("Id", Id);

            Connection cnx = new Connection(_connectionString);
            return cnx.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<Movie> GetAll()
        {
            Command cmd = new Command("Select * FROM Movie");
            Connection cnx = new Connection(_connectionString);
            return cnx.ExecuteReader(cmd, Mappers.MovieConverter);
        }

        public Movie GetById(int Id)
        {
            Command cmd = new Command("SELECT * FROM Movie WHERE Id = @Id");
            cmd.AddParameter("Id", Id);

            Connection cnx = new Connection(_connectionString);
            return cnx.ExecuteReader(cmd, Mappers.MovieConverter).FirstOrDefault();

        }

        public IEnumerable<Actor> GetCastingByMovieId(int MovieId)
        {
            Command cmd = new Command("Select * FROM Actors A " +
                "JOIN Casting C ON A.Id = C.ActorId WHERE C.MovieId = @Id");
            cmd.AddParameter("Id", MovieId);
            Connection cnx = new Connection(_connectionString);
            return cnx.ExecuteReader(cmd, Mappers.ActorConverter);
        }

        public int Insert(Movie model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Movie model)
        {
            throw new NotImplementedException();
        }
    }
}
