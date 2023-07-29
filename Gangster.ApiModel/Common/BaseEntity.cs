namespace Gangster.ApiModel.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? UpdatedBy { get; set; }
    public bool IsActive { get; set; }
}
