namespace Postman2.Domain.Common
{
	public interface IModifiedByEntity
	{
		DateTimeOffset? ModifiedOn { get; set; }
	}
}