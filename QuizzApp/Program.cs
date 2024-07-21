namespace QuizzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {

                new Question(
                    "What is the Capital of Germany?: " , // Question Text
                new string [] {"Paris" , "Berlin" , "London" , "Madrid"}, // Answer Array
                1
                
                )

            };


            Quizz myQuizz = new Quizz(questions);
            myQuizz.DisplayQuestion(questions[0]);
            Console.ReadLine();


        }
    }
}
