using Bogus;
using FluentValidation.Domain.Entities;
using FluentValidation.Persistence.Contexts;
using System;

namespace FluentValidation.API.Services
{
    public class FakeDataService
    {
        private readonly PerfectAppDbContext _perfectAppDbContext;
        private readonly Random _random;

        public FakeDataService(PerfectAppDbContext perfectAppDbContext)
        {
            _perfectAppDbContext = perfectAppDbContext;

            _random = new Random();
        }


        public async Task<int> GenerateBankAccountDataAsync(CancellationToken cancellationToken,int genatateData)
        {
            var fakeBankAccountRules = new Faker<BankAccount>("tr")
                .RuleFor(s => s.Id, new Guid())
                .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s=>s.PhoneNumber, f=>f.Phone.PhoneNumber())
                .RuleFor(s => s.Balance, f => Convert.ToString(_random.Next(0, 9999)))

                .RuleFor(s => s.CreatedOn, f => DateTimeOffset.UtcNow)
                .RuleFor(s => s.CreatedByUserId, f => "4ni1");

            var bancAccounts = fakeBankAccountRules.Generate(genatateData);

            foreach (var bancAccount in bancAccounts)
                bancAccount.Id = Guid.NewGuid();


            await _perfectAppDbContext.People.AddRangeAsync(bancAccounts, cancellationToken);

            var recordCount = await _perfectAppDbContext.SaveChangesAsync(cancellationToken);

            return recordCount;
        }
    }
}
