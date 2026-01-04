using System;

namespace Exam_IZVP.Core
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public override string ToString() => $"{Id}: {Name}";
    }
}
