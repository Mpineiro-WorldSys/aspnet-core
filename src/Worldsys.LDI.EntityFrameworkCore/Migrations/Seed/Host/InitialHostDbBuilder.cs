using Worldsys.LDI.EntityFrameworkCore;

namespace Worldsys.LDI.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly LDIDbContext _context;

        public InitialHostDbBuilder(LDIDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new InitialPeopleAndPhoneCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
