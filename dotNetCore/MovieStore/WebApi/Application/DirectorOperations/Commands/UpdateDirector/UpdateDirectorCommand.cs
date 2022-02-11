using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.DirectorOperations.Commands.UpdateDirector
{
    public class UpdateDirectorCommand
    {
        public int DirectorId { get; set; }
        public UpdateDirectorModel Model { get; set; }
        private readonly IMovieStoreDbContext _context;

        public UpdateDirectorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var director = _context.Director.SingleOrDefault(x => x.DirectorId == DirectorId);
            if (director is null)
                throw new InvalidOperationException("Yönetmen Bulunamadı?"); 
            if(_context.Director.Any(x=>x.Name.ToLower()==Model.Name.ToLower() && x.DirectorId != DirectorId))
                throw new InvalidOperationException("Aynı isimli bir yönetmen zaten mevcut");
            director.Name = string.IsNullOrEmpty(Model.Name.Trim())? director.Name : Model.Name;
            director.Surname = string.IsNullOrEmpty(Model.Surname.Trim())? director.Surname : Model.Surname;
            director.directedMovie = Model.directedMovie;
            _context.SaveChanges();
        }

    } 
    public class UpdateDirectorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string directedMovie { get; set; }

    }
}
