using System.Collections.Generic;

namespace Exam_IZVP.Core
{
    public class Student : BaseModel
    {
        public string FullName { get; set; }
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();

        // Для відображення в DataGridView
        public string LanguagesString => string.Join(", ", ProgrammingLanguages);
    }
}