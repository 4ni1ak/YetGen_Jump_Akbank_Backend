namespace Login.Domain.Entities;

public  class EntityBase<TKey> : IEntityBase<TKey>, ICreatedByEntity, IModifiedByEntity, IDeletedByEntity
{
    public TKey? Id { get; set; }

    public string? CreatedByUserId { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public string? ModifiedByUserId { get; set; }
    public DateTimeOffset? LastModifiedOn { get; set; }
    public bool IsDeleted { get; set; }
    public string? DeletedByUserId { get; set; }
    public DateTimeOffset? DeletedOn { get; set; }


}