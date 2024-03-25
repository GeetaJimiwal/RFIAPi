namespace xCRM.Domain.Common;

public abstract class BaseAuditableEntity
{
    
    public Guid Key { get; set; }

    public DateTime Created { get; set; }

    public virtual int? CreatedBy { get; set; }

    public DateTime LastModified { get; set; }

    public int? LastModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
