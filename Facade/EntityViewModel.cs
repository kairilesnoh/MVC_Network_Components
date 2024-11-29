using Nc.Domain;
using System.ComponentModel;

namespace Nc.Facade;
public abstract class EntityViewModel : IEntity {
    [DisplayName("Id")] public int Id { get; set; }
}
