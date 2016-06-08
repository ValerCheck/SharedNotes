using System.Data.Entity;

namespace SharedNotes.Domain
{
    public class WorkSpaceContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<WorkSpace> WorkSpaces { get; set; }
    }
}
