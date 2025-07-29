using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Repo
{
    public class FeedbackRepo : IFeedbackRepo
    {
        public Task<IEnumerable<Feedback>> GetAllFeedbacksAsync()
        {
            throw new NotImplementedException();
        }
    }
}
