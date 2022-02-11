using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.ActorOperations.Commands.DeleteActor
{
    public class DeleteActorCommand
    {
        public int ActorId { get; set; }
        private readonly IMovieStoreDbContext _context;

        public DeleteActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var actor = _context.Actor.SingleOrDefault(x => x.ActorId == ActorId);
            if (actor is null)
                throw new InvalidOperationException("Oyuncu Bulunamadı?"); 
            _context.Actor.Remove(actor);
            _context.SaveChanges();
        }

    } 
}
