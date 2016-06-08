using System;
using System.Collections.Generic;
using SharedNotes.Domain.Entities;

namespace SharedNotes.Domain.Abstract
{
    public interface IWorkSpaceRepository
    {
        void AddWorkSpace(WorkSpace workspace);
        void DeleteWorkSpace(WorkSpace workspace);
        WorkSpace GetWorkSpaceById(Guid id);
        List<WorkSpace> GetAllWorkSpaces();
    }
}
