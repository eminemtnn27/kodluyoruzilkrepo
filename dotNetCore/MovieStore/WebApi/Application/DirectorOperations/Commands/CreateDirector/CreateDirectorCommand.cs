using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.DirectorOperations.Commands.CreateDirector
{
    public class CreateDirectorCommand
    {
        public CreateDirectorModel Model { get; set; }
        private readonly IMovieStoreDbContext _context;

        public CreateDirectorCommand(IMovieStoreDbContext context, AutoMapper.IMapper _mapper)
        {
            _context = context;
        }
        public void Handle()
        {
            var director = _context.Director.SingleOrDefault(x => x.Name == Model.Name);
            if (director is null)
                throw new InvalidOperationException("Yönetmen Zaten Mevcut.");
            director = new Director();
            director.Name = Model.Name;
            _context.Director.Add(director);
            _context.SaveChanges();
        }

    }
    public class CreateDirectorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string directedMovie { get; set; }
         
    }
}
