using Randomizer;

var dbFactory = new ITechByContextFactory();
var dbContext = dbFactory.CreateDbContext(new string[0]);
UserGenerator.FillUsersInDataBase(dbContext);