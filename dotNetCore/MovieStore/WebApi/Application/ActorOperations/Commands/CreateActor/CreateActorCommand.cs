using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.ActorOperations.Commands.CreateActor
{
    public class CreateActorCommand
    {
        public CreateActorModel Model { get; set; }
        private readonly IMovieStoreDbContext _context;

        public CreateActorCommand(IMovieStoreDbContext context, AutoMapper.IMapper _mapper)
        {
            _context = context;
        }
        public void Handle()
        {
            var actor = _context.Actor.SingleOrDefault(x => x.Name == Model.Name);
            if (actor is null)
                throw new InvalidOperationException("Oyuncu Zaten Mevcut.");
            actor = new Actor();
            actor.Name = Model.Name;
            _context.Actor.Add(actor);
            _context.SaveChanges();
        }

    }
    public class CreateActorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
         
    }
}
