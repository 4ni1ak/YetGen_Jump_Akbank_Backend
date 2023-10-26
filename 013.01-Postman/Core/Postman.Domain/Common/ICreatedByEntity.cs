namespace Postman.Domain.Common
{
	public interface ICreatedByEntity
	{
		DateTime CreatedOn { get; set; }
		string CreatedByUserId { get; set; }
	}
}