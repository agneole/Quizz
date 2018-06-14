using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    class Question
    {
        public string QuestionText { get; set; }
        public int Value { get; set; }
        public string CorrectAnswer { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
