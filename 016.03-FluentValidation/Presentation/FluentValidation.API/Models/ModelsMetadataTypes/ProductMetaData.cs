using System.ComponentModel.DataAnnotations;

namespace FluentValidation.API.Models.ModelsMetadataTypes
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Please Enter The FirstName ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter The LastName ")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter The Balance ")]
        [StringLength(100, ErrorMessage = "Please Enter Less Than 100 Character")]
        public string Balance { get; set; }
    }

}
