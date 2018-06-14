using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    class Helpers
    {
        public static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();

            Question question1 = new Question();
            question1.QuestionText = "1. Kas parašė Lietuvos himną?";
            question1.Value = 100;
            question1.CorrectAnswer = "c";
            List<Answer> answers1 = new List<Answer>();
            Answer answer1a = new Answer();
            answer1a.AnswerText = "a) Justinas Marcinkevičius";
            Answer answer1b = new Answer();
            answer1b.AnswerText = "b) Vincas Krėvė";
            Answer answer1c = new Answer();
            answer1c.AnswerText = "c) Vincas Kudirka";
            Answer answer1d = new Answer();
            answer1d.AnswerText = "d) Jonas Jablonskis";
            answers1.Add(answer1a);
            answers1.Add(answer1b);
            answers1.Add(answer1c);
            answers1.Add(answer1d);
            question1.Answers = answers1;

            Question question2 = new Question();
            question2.QuestionText = "Giliausias ežeras pasaulyje?";
            question2.Value = 1000;
            question2.CorrectAnswer = "a";
            List<Answer> answers2 = new List<Answer>();
            Answer answer2a = new Answer();
            answer2a.AnswerText = "a) Baikalas";
            Answer answer2b = new Answer();
            answer2b.AnswerText = "b) Tauragnas";
            Answer answer2c = new Answer();
            answer2c.AnswerText = "c) Kaspijos jūra";
            Answer answer2d = new Answer();
            answer2d.AnswerText = "d) Tanganika";
            answers2.Add(answer2a);
            answers2.Add(answer2b);
            answers2.Add(answer2c);
            answers2.Add(answer2d);
            question2.Answers = answers2;

            Question question3 = new Question();
            question3.QuestionText = "Kas pavaizduota Lietuvos istorinėje vėliavoje?";
            question3.Value = 10000;
            question3.CorrectAnswer = "d";
            List<Answer> answers3 = new List<Answer>();
            Answer answer3a = new Answer();
            answer3a.AnswerText = "a) Spalvos: geltona, žalia, raudona";
            Answer answer3b = new Answer();
            answer3b.AnswerText = "b) Prezidentai";
            Answer answer3c = new Answer();
            answer3c.AnswerText = "c) Nėra tokios";
            Answer answer3d = new Answer();
            answer3d.AnswerText = "d) Lietuvos herbas";
            answers3.Add(answer3a);
            answers3.Add(answer3b);
            answers3.Add(answer3c);
            answers3.Add(answer3d);
            question3.Answers = answers3;

            Question question4 = new Question();
            question4.QuestionText = "Pirmasis vaistas pateiktas kaip tabletė?";
            question4.Value = 100000;
            question4.CorrectAnswer = "a";
            List<Answer> answers4 = new List<Answer>();
            Answer answer4a = new Answer();
            answer4a.AnswerText = "a) Aspirinas";
            Answer answer4b = new Answer();
            answer4b.AnswerText = "b) Paracetamolis";
            Answer answer4c = new Answer();
            answer4c.AnswerText = "c) Ibuprofenas";
            Answer answer4d = new Answer();
            answer4d.AnswerText = "d) Citramonas";
            answers4.Add(answer4a);
            answers4.Add(answer4b);
            answers4.Add(answer4c);
            answers4.Add(answer4d);
            question4.Answers = answers4;

            Question question5 = new Question();
            question5.QuestionText = "Kurio judėjimo atstovas buvo Salvadoras Dali?";
            question5.Value = 1000000;
            question5.CorrectAnswer = "a";
            List<Answer> answers5 = new List<Answer>();
            Answer answer5a = new Answer();
            answer5a.AnswerText = "a) Siurrealizmo";
            Answer answer5b = new Answer();
            answer5b.AnswerText = "b) Dadaizmo";
            Answer answer5c = new Answer();
            answer5c.AnswerText = "c) Klasicizmo";
            Answer answer5d = new Answer();
            answer5d.AnswerText = "d) Komunizmo";
            answers5.Add(answer5a);
            answers5.Add(answer5b);
            answers5.Add(answer5c);
            answers5.Add(answer5d);
            question5.Answers = answers5;

            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);

            return questions;
        }
    }
}
