using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    class Game
    {
        public void PlayGame()
        {

            var questions = Helpers.GetQuestions();

            foreach (var question in questions)
            {
                Console.WriteLine($"Klausimo verte: {question.Value} euru.");
                Console.WriteLine(question.QuestionText);

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer.AnswerText);
                }

                Console.WriteLine("Jūsų atsakymo variantas:");
                string userAnswer = Console.ReadLine();

                if (userAnswer == question.CorrectAnswer)
                {
                    if (question.Value == 1000000)
                    {
                        Console.WriteLine("Sveikinu! Laimėjote MILIJONĄ!!!");
                    }
                    else
                    {
                        Console.WriteLine($"Atsakėte teisingai.Laimėjote {question.Value} eurų. Ar norite tęsti žaidimą? (taip/ne)");
                        string yesOrNo = Console.ReadLine();

                        if (yesOrNo == "ne")
                        {
                            Console.WriteLine($"Pasirinkote žaidimo nebetęsti. Laimėjote {question.Value} eurų. Ačiū, kad žaidėte!");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Jūsų atsakymas neteisingas");
                    Console.WriteLine("Žaidimas baigtas. Bandysite dar kartą?");
                    break;
                }
            }

        }

    }
}


