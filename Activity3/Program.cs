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

        
    }
}