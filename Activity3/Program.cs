namespace Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key ;
            do
            {
                ShowTopics();
                key=Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        ShowSportsQuestions();
                        break;
                    case ConsoleKey.D2:
                        ShowArtQuestions();
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;

                    default:
                        Console.WriteLine("Exit program");
                        break;
                }

            } while (key.Key != ConsoleKey.D0);
        }

        static void ShowTopics()
        {
            //darle tiempo de margen al clear
            Console.Clear();
            Console.WriteLine("1. SPORTS");
            Console.WriteLine("2. ART");
            Console.WriteLine("3. FILMS");
            Console.WriteLine("4. HISTORY");
            Console.WriteLine("5. MATHS");
            Console.WriteLine("6. SCIENCE");
        }

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

            for(int i = 0; i < questions.Length; i++)
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
                //ACABAR PREGUNTAS ART
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

        static void ShowReadAnswers(int topicNumber, int questionNum)
        {
            String input;
            if (topicNumber == 1)
            {
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
            else if(topicNumber == 2)
            {

            }
            else if (topicNumber == 3)
            {

            }
            else if (topicNumber == 4)
            {

            }
            else if (topicNumber == 5)
            {

            }
            else
            {

            }
        }

        static void CheckAnswersShowResult(String correctAnswer, String input)
        {
            if (input.Trim().ToLower()==correctAnswer.ToLower().Trim())
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