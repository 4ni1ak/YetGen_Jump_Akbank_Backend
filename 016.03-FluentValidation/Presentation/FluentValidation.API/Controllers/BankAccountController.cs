using FluentValidation.API.Services;
using FluentValidation.Domain.Entities;
using FluentValidation.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore;
using FluentValidation.API.Models;

namespace FluentValidation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAccountController : ControllerBase
    {
        public PerfectAppDbContext _perfectAppDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions _cacheEntryOptions;
        private const string PeopleCachekey = "peopleList";
        private readonly FakeDataService _fakeDataService;

        public BankAccountController(PerfectAppDbContext perfectAppDbContext, FakeDataService fakeDataService, IMemoryCache memoryCache)
        {
            _perfectAppDbContext=perfectAppDbContext;
            _fakeDataService = fakeDataService;
            _memoryCache = memoryCache;
        }


        [HttpPost("GenerateFakeData")]
        public async Task<IActionResult> GenerateFakeDataAsync(CancellationToken cancellationToken,int number)
        {
            await _fakeDataService.GenerateBankAccountDataAsync(cancellationToken,number);

            var bankAccounts = await _perfectAppDbContext
                .People.AsNoTracking()
                .ToListAsync(cancellationToken);

            _memoryCache.Set(PeopleCachekey, bankAccounts, _cacheEntryOptions);

            return Ok(await _fakeDataService.GenerateBankAccountDataAsync(cancellationToken,number));
        }

        [HttpGet("[action]/{bankAccountId:guid}")]
        public GetBankAccountDataResponseModel GetBankAccountData(Guid bankAccountId)
        {
            var bankAccount=_perfectAppDbContext.People.FirstOrDefault( x=>x.Id == bankAccountId) ;
            var response= new GetBankAccountDataResponseModel()
            {
                FirstName = bankAccount.FirstName,
                LastName = bankAccount.LastName,
                Balance = bankAccount.Balance,

            };    
            return response;

        }


        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {

            if (_memoryCache.TryGetValue(PeopleCachekey, out List<BankAccount> bankAccounts))
            {
                return Ok(bankAccounts);
            }

            bankAccounts = await _perfectAppDbContext.People.AsNoTracking().ToListAsync(cancellationToken);

            _memoryCache.Set(PeopleCachekey, bankAccounts, _cacheEntryOptions);

            return Ok(bankAccounts);
        }

    }
}
