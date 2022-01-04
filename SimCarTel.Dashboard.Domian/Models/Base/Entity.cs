using SimCarTel.Dashboard.Domian.Interface.Models.Base;

namespace SimCarTel.Dashboard.Domian.Models.Base
{
    public abstract class Entity<Tkey> : IEntity
    {
        public Tkey ID { get; set; }
    }

    public abstract class Entity : Entity<int>
    {
    }
}
