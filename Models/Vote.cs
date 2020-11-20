using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoterService.Models
{
    public class Vote
    {
        public int VoteID { get; set; }
        public int VoterID { get; set; }
        public int ContenderID { get; set; }
    }
}