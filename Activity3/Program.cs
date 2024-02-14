namespace Activity3
{
    internal class Program
    {

        static void ShowSportsQuestions()
        {
            string[] questions;
            int topic = 1;
            questions = new string[]
            {
                "How long does a soccer game last?",
                "Which swimming style is faster?",
                "What sport is played annually in Paris at the Roland Garros tournament?",
                "How many members does a beach volleyball team have?",
                "In which country was football invented?"
            };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                ShowReadAnswers(topic, i);
            }
        }
        static void ShowArtQuestions()
        {
            string[] questions;
            int topic = 2;
            questions = new string[]
            {
                "Where is the Louvre museum located?",
                "Who painted \"La Gioconda\"?",
                "What is the name of the painter who cut off his ear?",
                "The painting called \"Guernica\" was made by...",
                "Who painted the Sistine Chapel in the Vatican?"
            };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                ShowReadAnswers(topic, i);
            }
        }
        static void ShowFilmQuestions()
        {
            string[] questions;
            int topic = 3;
            questions = new string[]
            {
                "What color is present in almost every shot of The Shining?",
                "How many Saw movies are?",
                "What year do Marty and Doc travel to in \"Back to the Future II\"?",
                "Who sang \"My Heart Will Go On\" in Titanic?",
                "Who was the first Spanish director to win an Oscar?"
            };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                ShowReadAnswers(topic, i);
            }
        }

        static void ShowReadAnswers(int topicNumber, int questionNum)
        {
            String input;
            if (topicNumber == 1)
            {
                //SPORTS
                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.Butterfly");
                        Console.WriteLine("B.Crawl");
                        Console.WriteLine("C.Backstroke");
                        Console.WriteLine("D.Breaststroke");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.Swimming");
                        Console.WriteLine("B.Tennis");
                        Console.WriteLine("C.Basketball");
                        Console.WriteLine("D.Badminton");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.4");
                        Console.WriteLine("B.5");
                        Console.WriteLine("C.2");
                        Console.WriteLine("D.3");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.England");
                        Console.WriteLine("B.Argentina");
                        Console.WriteLine("C.Spain");
                        Console.WriteLine("D.France");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

            }
            else if (topicNumber == 2)
            {
                //ART
                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("A.Buenos Aires");
                        Console.WriteLine("B.Lyon");
                        Console.WriteLine("C.London");
                        Console.WriteLine("D.Paris");
                        CheckAnswersShowResult("d", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.Dalí");
                        Console.WriteLine("B.Michelangelo");
                        Console.WriteLine("C.Leonardo Da Vinci");
                        Console.WriteLine("D.Frida Khalo");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.Tizziano");
                        Console.WriteLine("B.Vincent Van Gogh");
                        Console.WriteLine("C.Monet");
                        Console.WriteLine("D.Goya");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.Pablo Picasso");
                        Console.WriteLine("B.Artemisia Gentileschi");
                        Console.WriteLine("C.Velázquez");
                        Console.WriteLine("D.Caravaggio");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.Giotto");
                        Console.WriteLine("B.Michelangelo");
                        Console.WriteLine("C.Leonardo Da Vinci");
                        Console.WriteLine("D.Donatello");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
            else if (topicNumber == 3)
            {
                //FILMS
                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("A.blue");
                        Console.WriteLine("B.yellow");
                        Console.WriteLine("C.red");
                        Console.WriteLine("D.black");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.10");
                        Console.WriteLine("B.6");
                        Console.WriteLine("C.9");
                        Console.WriteLine("D.7");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.2010");
                        Console.WriteLine("B.2033");
                        Console.WriteLine("C.2015");
                        Console.WriteLine("D.2024");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.Mariah Carey");
                        Console.WriteLine("B.Kate Winslet");
                        Console.WriteLine("C.Whitney Houston");
                        Console.WriteLine("D.Celine Dion");
                        CheckAnswersShowResult("d", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.Javier Bardem");
                        Console.WriteLine("B.Paco León");
                        Console.WriteLine("C.José Luís Garci");
                        Console.WriteLine("D.Alejandro Amenabar");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

            }
            else if (topicNumber == 4)
            {
                //HISTORY

                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("d", input = Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

            }

            else if (topicNumber == 5)
            {
                //MATHS

                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("d", input = Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }

            else
            {
                //SCIENCE

                switch (questionNum)
                {
                    case 0:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.30 minutes");
                        Console.WriteLine("B.120 minutes");
                        Console.WriteLine("C.90 minutes");
                        Console.WriteLine("D.40 minutes");
                        CheckAnswersShowResult("d", input = Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
        }

        static void CheckAnswersShowResult(String correctAnswer, String input)
        {
            if (input.Trim().ToLower() == correctAnswer.ToLower().Trim())
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("INCORRECT");
            }
            Console.WriteLine();

        }

        
    }
}