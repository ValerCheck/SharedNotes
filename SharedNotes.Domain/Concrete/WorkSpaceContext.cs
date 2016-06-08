using System.Data.Entity;
using SharedNotes.Domain.Entities;

namespace SharedNotes.Domain.Concrete
{
    public class WorkSpaceContext : DbContext
    {
        public WorkSpaceContext() : base(nameOrConnectionString: "SharedNotes") {}

        public DbSet<Note> Notes { get; set; }
        public DbSet<WorkSpace> WorkSpaces { get; set; }
    }
}
