using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.ActorOperations.Commands.UpdateActor
{
    public class UpdateActorCommand
    {
        public int ActorId { get; set; }
        public UpdateActorModel Model { get; set; }
        private readonly IMovieStoreDbContext _context;

        public UpdateActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var actor = _context.Actor.SingleOrDefault(x => x.ActorId == ActorId);
            if (actor is null)
                throw new InvalidOperationException("Oyuncu Bulunamadı?"); 
            if(_context.Actor.Any(x=>x.Name.ToLower()==Model.Name.ToLower() && x.ActorId != ActorId))
                throw new InvalidOperationException("Aynı isimli bir oyuncu zaten mevcut");
            actor.Name = string.IsNullOrEmpty(Model.Name.Trim())? actor.Name : Model.Name;
            actor.Surname = string.IsNullOrEmpty(Model.Surname.Trim())? actor.Surname : Model.Surname;
            actor.ActingMovie = Model.ActingMovie;
            _context.SaveChanges();
        }

    } 
    public class UpdateActorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ActingMovie { get; set; }

    }
}
