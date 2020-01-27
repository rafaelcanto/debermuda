

using System;

namespace DeBermudaApi.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public bool VoteValue { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}