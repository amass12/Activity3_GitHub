namespace Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static public void HistoryTrivia()
        {
            Console.WriteLine("The 'Topic' is HISTORY");

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
        }
        
    }
}