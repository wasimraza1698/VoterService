using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoterService.Models;

namespace VoterService.Repositories
{
    public interface IVoteRepository
    {
        public bool CastVote(Vote vote);
    }
}