using Clean.Domain.Entitles.Common;

namespace Clean.Domain.Entitles
{
	public class DemoEntity : BaseAuditableEntity
	{
		public string Name { get; set; }
		public DateTime DOB { get; set; }
	}
}