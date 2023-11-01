namespace Assignment3
{
    class DuplicateElements
    {
        int[] numbers = { 1, 2, 3, 4, 5, 2 };
        string[] name = { "dd", "dd", "ee" };
        List<int> uniqueelements = new List<int>();
        List<int> duplicateelement = new List<int>();
        List<string> uniqueelements_string = new List<string>();
        List<string> duplicateelements_string = new List<string>();
        public void GetDuplicateElementInArrayForInteger()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && !duplicateelement.Contains(numbers[i]))
                    {
                        duplicateelement.Add(numbers[i]);
                    }
                     else if (numbers[i] != numbers[j] && !duplicateelement.Contains(numbers[i]))
                    {
                        uniqueelements.Add(numbers[i]);
                    }
                }
            }
        }


        public void DisplayDuplicateElementInArrayForInteger()
        {
            Console.WriteLine(uniqueelements.Count);
            Console.WriteLine(duplicateelement.Count);
            Console.WriteLine("Duplicate Elements: " + string.Join(", ", duplicateelement));
            
        }
        public void GetDuplicateElementInArrayForString()
        {
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (name[i] == name[j] && !duplicateelements_string.Contains(name[i]))
                    {
                        duplicateelements_string.Add(name[i]);
                    }
                    else if (numbers[i] != numbers[j] && !uniqueelements_string.Contains(name[i]))
                    {
                        uniqueelements_string.Add(name[i]);
                    }
                }
            }
        }


        public void DisplayDuplicateElementInArrayForString()
        {
            Console.WriteLine(uniqueelements_string.Count);
            Console.WriteLine(duplicateelements_string.Count);
            Console.WriteLine("Duplicate Elements: " + string.Join(", ", duplicateelements_string));

        }
        static void Main(string[] args)
        {
            DuplicateElements dup = new DuplicateElements();
            dup.GetDuplicateElementInArrayForInteger();
            dup.DisplayDuplicateElementInArrayForInteger();
            dup.GetDuplicateElementInArrayForString();
            dup.DisplayDuplicateElementInArrayForString();



        }
    }
    }

