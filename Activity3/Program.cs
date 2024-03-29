namespace Activity3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                ShowTopics();
                key = Console.ReadKey();
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
                        ShowFilmQuestions();
                        break;
                    case ConsoleKey.D4:
                        ShowHistoryQuestions();
                        break;
                    case ConsoleKey.D5:
                        ShowMathQuestions();
                        break;
                    case ConsoleKey.D6:
                        ShowScienceQuestions();
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

        static public void ShowHistoryQuestions()
        {
            string[] questions;
            int topic = 4;

            questions = new string[]
            {

                "In what year did World War I begin?",
                "Who was the first president of the United States?",
                "What was the name of the ship on which Christopher Columbus reached America in 1492?",
                "In what year did World War II end?",
                "Who was the Egyptian queen known for her alliance with Julius Caesar and Mark Antony?"
            };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                ShowReadAnswers(topic, i);
            }
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
        static public void ShowScienceQuestions()
        {
            string[] questions;
            int topic = 6;
            questions = new string[]
            {
                "What is the chemical symbol for water?",
                "What is the process by which plants make their own food called?",
                "Which planet is known as the \"Red Planet\"?",
                "What is the atomic number of carbon?",
                "What is the Earth's outermost layer called?"

            };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                ShowReadAnswers(topic, i);
            }
        }


        static public void ShowMathQuestions()
        {
            string[] questions;
            int topic = 5;
            questions = new string[]
            {

                "What is the value of π (pi) rounded to two decimal places?",
                "What is the square root of 144?",
                "What is the result of 7 × 8 ÷ 4?",
                "What is the value of 5² - 3²?",
                "What is the sum of the interior angles of a triangle?"

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
                        Console.WriteLine("A.1914");
                        Console.WriteLine("B.1814");
                        Console.WriteLine("C.1912");
                        Console.WriteLine("D.1915");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.Thomas Jefferson");
                        Console.WriteLine("B.Abraham Lincoln");
                        Console.WriteLine("C.George Washington");
                        Console.WriteLine("D.John Adams");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.Golden Hind");
                        Console.WriteLine("B.Mayflower");
                        Console.WriteLine("C.Santa María");
                        Console.WriteLine("D.HMS Endeavour");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.1934");
                        Console.WriteLine("B.1935");
                        Console.WriteLine("C.1944");
                        Console.WriteLine("D.1945");
                        CheckAnswersShowResult("d", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.Nefertiti");
                        Console.WriteLine("B.Hatshepsut");
                        Console.WriteLine("C.Cleopatra");
                        Console.WriteLine("D.Nefertari");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
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
                        Console.WriteLine("A.3.16");
                        Console.WriteLine("B.3.15");
                        Console.WriteLine("C.3.14");
                        Console.WriteLine("D.3.23");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.12");
                        Console.WriteLine("B.10");
                        Console.WriteLine("C.13");
                        Console.WriteLine("D.14");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    //continuar aqui
                    case 2:
                        Console.WriteLine("A.14");
                        Console.WriteLine("B.10");
                        Console.WriteLine("C.16");
                        Console.WriteLine("D.13");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.15");
                        Console.WriteLine("B.25");
                        Console.WriteLine("C.16");
                        Console.WriteLine("D.20");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.80 degrees");
                        Console.WriteLine("B.180 degrees");
                        Console.WriteLine("C.90 degrees");
                        Console.WriteLine("D.80 disagrees");
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
                        Console.WriteLine("A.O2");
                        Console.WriteLine("B.NaCI");
                        Console.WriteLine("C.H2O");
                        Console.WriteLine("D.CO2");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("A.Photosynthesis");
                        Console.WriteLine("B.Respiration");
                        Console.WriteLine("C.Transpiration");
                        Console.WriteLine("D.Germination");
                        CheckAnswersShowResult("a", input = Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("A.Venus");
                        Console.WriteLine("B.Mart");
                        Console.WriteLine("C.Jupiter");
                        Console.WriteLine("D.Saturn");
                        CheckAnswersShowResult("b", input = Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("A.5");
                        Console.WriteLine("B.12");
                        Console.WriteLine("C.6");
                        Console.WriteLine("D.8");
                        CheckAnswersShowResult("c", input = Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("A.Mantle");
                        Console.WriteLine("B.Core");
                        Console.WriteLine("C.Lithosphere");
                        Console.WriteLine("D.Crust");
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
