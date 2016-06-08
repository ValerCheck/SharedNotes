using System;
using System.Collections.Generic;

namespace SharedNotes.Domain
{
    public interface IWorkSpaceRepository
    {
        void AddWorkSpace(WorkSpace workspace);
        void DeleteWorkSpace(WorkSpace workspace);
        WorkSpace GetWorkSpaceById(Guid id);
        List<WorkSpace> GetAllWorkSpaces();
    }
}
