namespace Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static public string[] ShowHistoryQuestions()
        {
            string[] questions;
            int topic = 1;
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
            static public string[] ShowMathQuestions()
            {
                string[] questions;
                int topic = 1;
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
            static public string[] ShowScienceQuestions()
            {
                string[] questions;
                int topic = 1;
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
        }
        
    }
}