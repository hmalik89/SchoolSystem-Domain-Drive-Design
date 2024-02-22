
namespace Domain.Premitives
{
    public abstract class Entity
    {
        public Entity(Guid id) { 
        
            Id = id;
        
        }
        protected Entity()
        {
            
        }

        public Guid Id { get; set; }
    }
}
