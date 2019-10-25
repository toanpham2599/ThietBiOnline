using Data.Infrastructure;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IFeedBackRepository : IRepository<Feedback>
    {

    }
    public class FeedBackRepository : RepositoryBase<Feedback>,IFeedBackRepository
    {
        public FeedBackRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
