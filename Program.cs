namespace Mod10;

class Program {

    static List<int> number = new List<int>();
    static int checkSum = 0;

    static void Main(string[] args) {

        System.Console.WriteLine("This is an implementation of the Modulus 10 algorithm.\n");
        System.Console.Write("Please enter the number you want to validate: ");
        string n = System.Console.ReadLine();

        for(int i = 0; i < n.Length; i++) number.Add(n[i] - '0');
        
        System.Console.WriteLine(number.Count);
        for (int i = number.Count - 2; i >= 0; i -= 2)  {
            number[i] *= 2;

            if (number[i].ToString().Length == 2) {
                int tmp = 0;

                foreach (char j in number[i].ToString()) tmp += j - '0';

                number[i] = tmp;
            }
        }

        foreach (int val in number) checkSum += val;

        if ((checkSum % 10) == 0) System.Console.WriteLine("\nThe number satisfies Modulus 10 algorithm.\n");
        else System.Console.WriteLine("\nThis number doesn't satisfy Modulus 10 algorithm.\n");
    }
}
