using PreparationChangeTracker.Config;
using PreparationChangeTracker.Contexts;
using PreparationChangeTracker.Entities;
using PreparationChangeTracker.Enums;

JobHunterDbContext context = new();
#region Entity State Examples
//JobPost jobPost1 = new()
//{
//	Title = "Junior Developer",
//	Company = "FoolTech",
//	Description = "Bachelor's degree in Computer Science/Engineering or relevant areas, Minimum 3 years experience in Net Framework & C# programming language (Knowledge and experience in .NET Core is a big plus)",
//	WorkMode = WorkMode.InOffice,
//	CreatedOn = DateTime.UtcNow,
//};
//Console.Write(Configurations.GetString("ConnectionStrings:PostgreSQL"));

//var state1 = _context.Entry(jobPost1).State;

//_context.JobPosts.Add(jobPost1);

//var state2 = _context.Entry(jobPost1).State;

//_context.SaveChanges();

//var state3 = _context.Entry(jobPost1).State;

//jobPost1.WorkMode = WorkMode.Hybrid;

//var state4 = _context.Entry(jobPost1).State;

//_context.SaveChanges();


////var state5 = _context.Entry(jobPost1).State;

////_context.JobPosts.Remove(jobPost1);

////var state6 = _context.Entry(jobPost1).State;

////_context.SaveChanges();

////var state7 = _context.Entry(jobPost1).State;
#endregion

//JobPost jobPost1 = context.JobPosts.Where(x => x.Id == Guid.Parse("1763c57e-ceed-4edc-8d0b-aa41925ef3a5")).FirstOrDefault();
//var state = context.Entry(jobPost1).State;

#region Interception

JobPost jobPost2 = context.JobPosts.FirstOrDefault();
jobPost2.Description = "desc. changed";
//jobPost2.ModifiedOn = DateTime.UtcNow;//not clever
context.SaveChanges();


#endregion

#region IQueryable

var query1 = context.JobPosts.ToList().Where(x => x.WorkMode == WorkMode.InOffice).Select(x=>new {x.Title,x.CreatedOn}).OrderBy(x => x.CreatedOn);//dead memory

var query2 = context.JobPosts.Where(x => x.WorkMode == WorkMode.InOffice).Select(x => new { x.Title, x.CreatedOn }).OrderBy(x => x.CreatedOn).ToList();

#endregion


#region IEnumerable

//var result = query.ToList();

#endregion

















































