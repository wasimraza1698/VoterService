using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoterService.Models;
using VoterService.Data;

namespace VoterService.Repositories
{
    public class VoteRepo : IVoteRepository
    {
        private readonly VoterDbContext _context;
        public VoteRepo(VoterDbContext context)
        {
            _context = context;
        }
        public bool CastVote(Vote vote)
        {
            _context.Votes.Add(vote);
            _context.SaveChanges();
            return true;
        }
    }
}