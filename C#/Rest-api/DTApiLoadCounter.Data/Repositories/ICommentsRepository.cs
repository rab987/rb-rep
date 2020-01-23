using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Data.Repositories
{
    public interface ICommentsRepository
    {
        IEnumerable<LoadCounterCommentDTO> GetDailyComments(int JobId);
    }
}
