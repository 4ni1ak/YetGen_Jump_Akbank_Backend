using System.ComponentModel.DataAnnotations;
using FluentValidation.API.Models.ModelsMetadataTypes;



namespace FluentValidation.API.Models
{
    public class GetBankAccountDataResponseModel
    {
        public string FirstName { get; set; }


        public string LastName { get; set; }
   
        public string Balance { get; set; }
    }
}
