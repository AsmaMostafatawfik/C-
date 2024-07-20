namespace Quiz_Game_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcom to you in the game.");
            Console.WriteLine("--------------------------");



            string[] question = new string[5]
            {
                "What is a neural network?",
                "What are the basic types of layers in a neural network?",
                "What is the purpose of activation functions in neural networks?",
                "How is the backpropagation algorithm used in training neural networks?",
                "What are some common loss functions used in neural networks?"

            };

            string[] anws = new string[5]
           {
                "Algorithm",
                "Layers",
                "Non-linearity",
                "Training",
                "Cross-Entropy"

           };
            int counter = 0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(question[i]);
              
                    string UserAns = Console.ReadLine();

                    if (UserAns.ToLower() == anws[i].ToLower())
                    {
                        counter++;
                    }
               
            }
            Console.WriteLine("--------------------------");
            if (counter==5)
            {
                Console.WriteLine($"Congratulations, you have successfully passed the test. .\r\nYour rate is {counter}/5 ");
            }
            else
            {
                Console.WriteLine($"Unfortunately, you could not pass the test.\r\nYour rate is {counter}/5 ");
            }
        }
    }
}
