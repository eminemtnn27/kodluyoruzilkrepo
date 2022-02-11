using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.DirectorOperations.Commands.DeleteDirector
{
    public class DeleteDirectorCommand
    {
        public int DirectorId { get; set; }
        private readonly IMovieStoreDbContext _context;

        public DeleteDirectorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var director = _context.Director.SingleOrDefault(x => x.DirectorId == DirectorId);
            if (director is null)
                throw new InvalidOperationException("Yönetmen Bulunamadı?"); 
            _context.Director.Remove(director);
            _context.SaveChanges();
        }

    } 
}
