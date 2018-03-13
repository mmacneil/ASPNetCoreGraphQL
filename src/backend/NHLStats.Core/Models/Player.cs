

using System;

namespace NHLStats.Core.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Height { get; set; }
        public int WeightLbs { get; set; }
    }
}

