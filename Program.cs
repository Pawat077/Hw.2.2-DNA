class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void Main()
    {
        char choice = 'Y';
        while (choice == 'Y')
        {
            Console.Write("Enter half of the DNA strand: ");
            string halfDNA = Console.ReadLine();

            if (IsValidSequence(halfDNA))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNA);
                Console.Write("Do you want to replicate it? (Y/N): ");
                char replicateChoice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (replicateChoice == 'Y')
                {
                    string replicatedDNA = ReplicateSequence(halfDNA);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedDNA);
                }
                else if (replicateChoice != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        }
    }
}
