using System;
using System.Collections.Generic;
using System.Linq;
using SharedNotes.Domain.Abstract;
using SharedNotes.Domain.Entities;

namespace SharedNotes.Domain.Concrete
{
    public class WorkSpaceRepository : IWorkSpaceRepository
    {
        private readonly WorkSpaceContext _dbContext = new WorkSpaceContext();

        private WorkSpace _selectedWorkSpace;

        public void AddWorkSpace(WorkSpace workspace)
        {
            _dbContext.WorkSpaces.Add(workspace);
            _dbContext.SaveChanges();
        }

        public void SetWorkSpace(WorkSpace workspace)
        {
            _selectedWorkSpace = workspace;
        }

        public WorkSpace GetWorkSpace()
        {
            return _selectedWorkSpace;
        }

        public WorkSpace GetWorkSpaceById(Guid id)
        {
            return _dbContext.WorkSpaces.FirstOrDefault(ws => ws.Id.Equals(id));
        }

        public void DeleteWorkSpace(WorkSpace workspace)
        {
            _dbContext.WorkSpaces.Remove(workspace);
            _dbContext.SaveChanges();
        }

        public List<WorkSpace> GetAllWorkSpaces()
        {
            return _dbContext.WorkSpaces.ToList();
        }
    }
}
