namespace Postman2.Domain.Common
{
	public interface ICreatedByEntity
	{
		DateTimeOffset CreatedOn { get; set; }
	}
}