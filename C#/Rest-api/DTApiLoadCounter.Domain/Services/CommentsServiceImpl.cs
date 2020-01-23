using System;
using System.Collections.Generic;
using System.Text;
using DTApiLoadCounter.Data.Repositories;
using DTApiLoadCounter.DTO;

namespace DTApiLoadCounter.Domain.Services
{
    public class CommentsServiceImpl : ICommentsService
    {
        private ICommentsRepository CommentsRepository;
        public CommentsServiceImpl(ICommentsRepository commentsRepository)
        {
            this.CommentsRepository = commentsRepository;
        }

        public IEnumerable<LoadCounterCommentDTO> GetDailyJobComments(int JobId)
        {
            IEnumerable<LoadCounterCommentDTO> result = this.CommentsRepository.GetDailyComments(JobId);
            return result;
        }
    }
}
