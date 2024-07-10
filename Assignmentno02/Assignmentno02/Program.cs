using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteDuplicates(); //Calling function for Question 01
            LargestandSecondLargest();//Calling function for Question 02
            ZerosAtTheEnd();//Calling function for Question 03
            FirstNonRepeatingCharacter();//Calling function for Question 04
            MergeArrays();//Calling function for Question 05
            MissingNumber(); //Calling function for Question 06
            CheckArmstrong();//Calling function for Question 07
            LongestCommonPrefix();//Calling function for Question 08
            FibonacciSequence();//Calling function for Question 09
            PositiveAndNegativeValues();//Calling function for Question 10
        }
        //QUESTION 01
        //========================================================================================================================================================
        //========================================================================================================================================================

        static void DeleteDuplicates() //function for Question 01
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)//one by one taking input elements of array from user
            {
                Console.WriteLine($"\nEnter the value for element {i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nElements in array are: {");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(" " + array[i]);//displaying the array input by user
            }
            Console.Write(" }\n");
            //creating an empty list for storing the elements of array during the iterations in the loop
            List<int> removed_duplicates = new List<int>();
            for (int i = 0; i < array.Length; i++)//takes one by one the elements of array 
            {
                bool duplicate = false;//assuming the bool initialization to be false
                for (int j = 0; j < removed_duplicates.Count; j++)//element from first for loop is checked here with all the elements in list
                {
                    if (array[i] == removed_duplicates[j])//if the element matches any element in list
                    {
                        duplicate = true;
                        break;
                    }

                }
                if (!duplicate)//if not duplicate
                {
                    removed_duplicates.Add(array[i]);
                }
            }
            Console.Write("Array after removing duplicate elements: {");
            foreach (int val in removed_duplicates)
            {
                Console.Write(" " + val);
            }
            Console.Write(" }\n");
        }
        //QUESTION 02
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void LargestandSecondLargest()//function for Question 02
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)//one by one taking input elements of array from user
            {
                Console.WriteLine($"\nEnter the value for element {i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nElements in array are: {");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(" " + array[i]);//displaying the array input by user
            }
            Console.Write(" }\n");



            //initializing the two variables and assuming their values from the input array

            int Largest = array[0];
            int SecondLargest = array[1];

            //checking if above initialization is correct within these two elements of array only

            if (Largest < SecondLargest)
            {
                //creating a temporary variable for assigning the correct values within these two 
                int temp = SecondLargest;
                SecondLargest = Largest;
                Largest = temp;
            }
            //starting the loop from index 2 and checking the remaining elements based on these two
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] > Largest)//if any element in array is greater than the variable Largesr
                {
                    Largest = array[i];//that element will be considered as largest
                }
                else if (array[i] > SecondLargest)//now we have assigned the largest number 
                {                                 //if any element in array is greater than the variable SecondLargest 
                    SecondLargest = array[i];//that element will be considered as largest
                }
            }
            Console.WriteLine($"{Largest} is the Largest Number.");
            Console.WriteLine($"{SecondLargest} is the Second Largest Number.");
        }

        //QUESTION 03
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void ZerosAtTheEnd()//function for Question 03
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)//one by one taking input elements of array from user
            {
                Console.WriteLine($"\nEnter the value for element {i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nElements in array are: {");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(" " + array[i]);//displaying the array input by user
            }
            Console.Write(" }\n");


            int ArrayCheckIndex = 0;//initializing a variable with 0 for accessing indexis
            for (int i = 0; i < array.Length; i++)//iterates through the array
            {
                if (array[i] != 0)//if an element in array is not equal to zero
                {
                    array[ArrayCheckIndex] = array[i];//it will be placed at 0th index,1st index and so on in the array
                    ArrayCheckIndex++;//index increments with every iteration
                }
            }
            //Till here, all the non-zero elements are sorted in the first indexes starting from 0th
            //Now putting the zeros at the end of the array if there are any zeros in array

            while (ArrayCheckIndex < array.Length)//loop runs until it approaches the array length
            {
                array[ArrayCheckIndex] = 0;//assigning the remaining indexes 0
                ArrayCheckIndex++;//incrementing the check index till the length of array
            }
            //displaying the resultant array
            Console.Write("\nArray after placing zeros at the end: {");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.Write(" }\n");
        }

        //QUESTION 04
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void FirstNonRepeatingCharacter()//function for Question 04
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();//reading string input and saving it in string variable
            Console.WriteLine($"\nInput string is: {input}");
            char firstNonRepeating = FirstNonRepeating(input);//calling the function FirstNonRepeating that returns character value and giving input argument of string


            if (firstNonRepeating == '0')//from the end of calling function
            {
                Console.WriteLine("No Non Repeating character in the string.");
            }
            else
            {
                Console.WriteLine($"First Non Repeating character is: {firstNonRepeating}");
            }
        }

        static char FirstNonRepeating(string str)//function to evaluate non repeating character input argument is string type and returns char type
        {
            // creating an array Count, of size 256 as of ASCII characters
            int[] Count = new int[256];


            for (int i = 0; i < str.Length; i++)//iterates through each character of the input string
            {//here in first iteration lets say for word swiss, i=0 accesses the character 's'. Its Ascii value is 115
                Count[str[i]]++; //it becomes Count[115]++; . here it increments the Count[115], if 's' again comes in the iteration Count[115] is again incremented
            }


            for (int i = 0; i < str.Length; i++)//now finding the first non repeating character i.e. its count is 1
            {
                if (Count[str[i]] == 1)//condition becomes true when it accesses the first character with count 1 at any ith iteration
                {
                    return str[i]; //returning that single character
                }
            }
            //after the iteration is completed if there is no non repeating character return a 0
            return '0';
        }

        //QUESTION 05
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void MergeArrays() //function for Question 05
        {
            Console.Write("Enter the size of first array: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[size1];
            for (int i = 0; i < array1.Length; i++)//one by one taking input elements of array from user
            {
                Console.WriteLine($"\nEnter the value for element {i + 1} for first array:");
                array1[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter the size of second array: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[size2];
            for (int i = 0; i < array2.Length; i++)//one by one taking input elements of array from user
            {
                Console.WriteLine($"\nEnter the value for element {i + 1} for second array:");
                array2[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nElements in first array are: {");
            for (int i = 0; i < array1.Length; i++)
            {

                Console.Write(" " + array1[i]);//displaying the array input by user
            }
            Console.Write(" }\n");
            Console.Write("\nElements in second array are: {");
            for (int i = 0; i < array2.Length; i++)
            {

                Console.Write(" " + array2[i]);//displaying the array input by user
            }
            Console.Write(" }\n");
            //merging arrays in a single sorted array<
            int[] MergedArray = new int[size1 + size2];//creating a new array equal to size of sum of both input arrays
            int Index1 = 0;//for iteration through array1
            int Index2 = 0;//for iteration through array2
            int IndexMerged = 0;//for iteration through MergedArray
            while (Index1 < size1 && Index2 < size2)//for comparing elements from both arrays and writing the smallest element one by one in iterations
            {
                if (array1[Index1] <= array2[Index2])//comparing corresponding elements and write the smaller element in the merged array
                {
                    MergedArray[IndexMerged++] = array1[Index1++];//iterates through each element and after writing the smaller element increments the both indexes
                }
                else
                {
                    MergedArray[IndexMerged++] = array2[Index2++];
                }

            }
            while (Index1 < size1)//onwards this loop runs until there are complete elements in the merged array i.e. sum of size of both the input arrays
            {
                MergedArray[IndexMerged++] = array1[Index1++];
            }
            while (Index2 < size2)
            {
                MergedArray[IndexMerged++] = array2[Index2++];
            }
            Console.Write("\nMerged sorted array is: {");
            for (int i = 0; i < MergedArray.Length; i++)//loop for displaying the output of merged array
            {
                Console.Write(" " + MergedArray[i]);
            }
            Console.WriteLine(" }");
        }

        //QUESTION 06
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void MissingNumber()//function for Question 06
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)//one by one taking input elements of array from user
            {
                Console.WriteLine($"\nEnter the value for element {i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nElements in array are: {");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(" " + array[i]);//displaying the array input by user
            }
            Console.Write(" }\n");
            //using logic in which calculating the sum of first n natural numbers, n is the size of array
            int SumOfNaturalNumbers = size * (size + 1) / 2;
            //calculating sum of array elements
            int SumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                SumArray += array[i];
            }
            //so that one missing number will be the difference between sum of natural numbers and the sum of array elements
            int MissingNumber = SumOfNaturalNumbers - SumArray;
            //displaying the output
            Console.WriteLine($"\n{MissingNumber} is the missing number in array.");
        }

        //QUESTION 07
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void CheckArmstrong()//function for Question 07
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe entered number is: {number}");//displaying the input
            int SumOfCubes = 0;//Initilizing the variabke by 0 to store values during iterations
            int temp = number;//to store input in temporary variable for processing and to avoid input loss
            while (temp > 0)
            {
                int LastDigit = temp % 10;//extracts last digit
                SumOfCubes += LastDigit * LastDigit * LastDigit;//calculate the cube and the sum during iterations
                temp = temp / 10;//removes the last digit
            }
            if (SumOfCubes == number)//displaying the output
            {
                Console.WriteLine($"{number} is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong Number.");
            }


        }

        //QUESTION 08
        //========================================================================================================================================================
        //========================================================================================================================================================
        static void LongestCommonPrefix()//function for Question 08
        {
            Console.Write("Enter the number of strings: ");
            int num = int.Parse(Console.ReadLine());

            string[] input = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter string {i + 1}:");
                input[i] = Console.ReadLine();
            }

            // Display the input strings
            Console.WriteLine("\nInput strings are:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(input[i]);
            }
            if (num == 0 || num == 1)//if there is no string or only one string input
            {
                Console.WriteLine($"\nThere is {num} string, So no comparrison.");
                return;
            }
            string prefix = input[0];

            for (int i = 1; i < num; i++)
            {
                prefix = CommonPrefix(prefix, input[i]);
                if (prefix == "")
                {
                    break;//if there is nothing in the place of first string
                }

            }
            Console.WriteLine($"\nThe longest common prefix is: {prefix}");
        }
            static string CommonPrefix(string str1, string str2)
            {
                int i;
                int MinimumLength = str1.Length < str2.Length ? str1.Length : str2.Length;//If-else statement, if length of str1(prefix=first string in array) is less than str2(remaining strings), so the minimum length is prefix length 
                for ( i = 0; i < MinimumLength; i++)
                {
                    if (str1[i] != str2[i])//loop keeps track of the position upto which the strings are same i.e. 'i'
                    {
                        break;
                    }
                    
                }
                return str1.Substring(0, i);//separates the string from character 0 to i
            }


        //QUESTION 09
        //========================================================================================================================================================
        //========================================================================================================================================================
  
        static void FibonacciSequence()//function for Question 09
        {
            Console.Write("Enter the number of terms:(a positive integer) "); //input for the fibonacci sequence
            int input = int.Parse(Console.ReadLine());
            
            int[] fibonacciSequence = new int[input];//array of size of input to store the sequence
       
            if (input >= 1)//initializing first two terms of sequence (generalized rule)
                fibonacciSequence[0] = 0;
            if (input >= 2)
                fibonacciSequence[1] = 1;

            
            for (int i = 2; i < input; i++)//calculating the Fibonacci sequence up to input(n) terms. loop starting with index 2 because the index 0 and 1 are already initialized
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];//adding the previous two consecutive terms
            }

            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < input; i++)//for loop to display the output sequence
            {
                Console.Write(fibonacciSequence[i] + " ");
            }
            Console.WriteLine();
        }
        //QUESTION 10
        //========================================================================================================================================================
        //========================================================================================================================================================


        static void PositiveAndNegativeValues()//function for Question 10
        {
            Console.Write("Enter N:(Positive integers separated by a space) ");
            int N = int.Parse(Console.ReadLine());
            int[] values = new int[N];
            Console.Write($"Enter {N} values: ");
            string input = Console.ReadLine();
            string[] val = input.Split(' ');//array val to store the input numbers as string

            for (int i = 0; i < N; i++)
            {
                values[i] = int.Parse(val[i]);//converting the string array to int array
            }

            int positiveCount = 0;
            int negativeCount = 0;
            int total = 0;

            for (int i = 0; i < N; i++)//calculating +ve and -ve counts and total
            {
                if (values[i] > 0)
                {
                    positiveCount++;
                }
                else if (values[i] < 0)
                {
                    negativeCount++;
                }
                total += values[i];
            }
            double average = (double)total / N;//calculating average
        
            Console.WriteLine($"The number of positive numbers: {positiveCount}");
            Console.WriteLine($"The number of negative numbers: {negativeCount}");
            Console.WriteLine($"Total is: {total}");
            Console.WriteLine($"Average is: {average}");
        }
    }
}