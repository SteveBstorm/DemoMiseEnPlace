using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DataAccessLayer.Models;
using BLL = BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Tools
{
    public static class Mappers
    {
        public static BLL.Movie ToBLL(this DAL.Movie m)
        {
            return new BLL.Movie
            {
                Id = m.Id,
                IsFavorite = m.IsFavorite,
                Title = m.Title
            };
        }

        public static BLL.Actor ToBLL(this DAL.Actor a)
        {
            return new BLL.Actor
            {
                CompleteName = a.FirstName + " " + a.LastName
            };
        }
    }
}
