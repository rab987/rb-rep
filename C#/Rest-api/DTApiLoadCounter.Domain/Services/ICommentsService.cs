using DTApiLoadCounter.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTApiLoadCounter.Domain.Services
{
    public interface ICommentsService
    {
        IEnumerable<LoadCounterCommentDTO> GetDailyJobComments(int JobId);
    }
}
