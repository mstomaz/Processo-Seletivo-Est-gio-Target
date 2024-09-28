using System.Runtime.Serialization;

namespace ProcTarget_Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char chosenLetter = 'a';

            Console.Write("Digite uma frase qualquer: ");
            string chosenPhrase = Console.ReadLine().Trim();

            int chosenLetterCount = VerifyLetterExistenceInString(chosenPhrase, chosenLetter);
            if (chosenLetterCount > 0)
                Console.WriteLine($"A letra '{chosenLetter}' está presente na frase {chosenLetterCount} vezes.");
            else
                Console.WriteLine($"A letra '{chosenLetter}' não está presente na frase.");
        }

        static int VerifyLetterExistenceInString(string phrase, char chosenLetter)
        {
            char upperChosenLetter = char.Parse(chosenLetter.ToString().ToUpper());
            int letterAmount = 0;
            foreach (char letter in phrase.ToUpper())
            {
                if (letter == upperChosenLetter)
                    letterAmount++;
            }
            return letterAmount;
        }
    }
}
