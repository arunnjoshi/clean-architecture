using Clean.Domain.Entites.Common;

namespace Clean.Domain
{
    public class DemoEntity : BaseAuditableEntity
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
    }
}