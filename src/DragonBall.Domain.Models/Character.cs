using DragonBall.Domain.Models.Enums;
using System.Collections.Generic;

namespace DragonBall.Domain.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Race Race { get; set; }
        public IEnumerable<Sagas> AppearsIn { get; set; }
    }
}
