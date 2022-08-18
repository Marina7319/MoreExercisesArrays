using System;

namespace EncryptSortandPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNames = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] numbers = new int[numNames];
            int tmp = 0;
            for (int i = 0; i < numNames; i++)
            {
                string name = Console.ReadLine();
                string[] nameLenght = new string[name.Length];
                for (int currentName = 0; currentName < name.Length; currentName++)
                {
                    char letters = name[currentName];
                    int sumVowel = 0;
                    int sumConsonant = 0;
                    if (name[currentName] == 'a' || name[currentName] == 'e' || name[currentName] == 'o' || name[currentName] == 'i' || name[currentName] == 'u' || name[currentName] == 'A' || name[currentName] == 'E' || name[currentName] == 'O' || name[currentName] == 'I' || name[currentName] == 'U')
                    {
                        int letter = (int)(name[currentName]);
                        sumVowel = (name[currentName] * name.Length);
                    }
                    else
                    {
                        int letter = (int)(name[currentName]);
                        sumConsonant = (name[currentName] / name.Length);
                    }
                    sum += (int)(sumVowel + sumConsonant);
                }
                numbers[i] = sum;
                sum = 0;
            }
            for (int n = 0; n < numNames; n++)
            {
                for (int j = n + 1; j < numNames; j++)
                {
                    if (numbers[n] > numbers[j])
                    {
                        tmp = numbers[j];
                        numbers[j] = numbers[n];
                        numbers[n] = tmp;
                    }
                }
            }
            for (int l = 0; l < numNames; l++)
            {
                Console.WriteLine(numbers[l]);
            }
        }
    }
}
