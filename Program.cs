using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace tutoriale
{
    class Program
    {
        static void Main(string[] args)
        {
		// int[] arrayNum = {4, 2, 1, 3, 5};
		// int[] arrayNum2 = {4, 2, 1, 3, 5};
        int[] arrayNum3 = {1,2,3,4,5};
        // int[] arrayNum4 = {5, 4, 3, 2, 1};
        // string kalimat1 = "Hello World";
        // string kalimat2 = "World Hello";
        // string caesarWord = "I love JavaScript!";
        // int key = 100;
        // int indexNum = 3;
        // int numberFill = 3;
        // int numberIncludes = 6;
        // char penghubung = '-';

        // IsAnagram(kalimat1,kalimat2);
        // SortArray(arrayNum);
        // ReverseArray(arrayNum2);
        // Caesar.CaesarCipher(caesarWord, key);
        // fizzbuzz(30);
        // Console.WriteLine(IsPalindrome("Cigar? Toss it in a can. It is so tragic"));
        // Console.WriteLine(factorial(30));
        // Console.WriteLine(Capitalize("hello world "));
        // Console.WriteLine(Reverse("Hello World"));
        // Sorting.BubbleSort(arrayNum4);
        // Sorting.InsertionSort(arrayNum4);
        // Sorting.SelectionSort(arrayNum4);
        // Console.WriteLine(MaxChar("Hello World"));
        // SpliceArray(arrayNum, 3, 6);
        // IndexNumber(arrayNum3, 3);
        // LastIndex(arrayNum3);
        // Includes(arrayNum3, 5);
        // Fills(arrayNum3, 3);
        // SumNumber(arrayNum3);
        JoinString(arrayNum3, '-');
        }

        static void IsAnagram(string word1, string word2){
            if(word1.Length != word2.Length){
                Console.WriteLine(false);
            }
            var word1Array = word1.ToLower().ToCharArray();
            var word2Array = word2.ToLower().ToCharArray();

            Array.Sort(word1Array);
            Array.Sort(word2Array);

            word1 = new string(word1Array);
            word2 = new string(word2Array);

            Console.WriteLine(word1 == word2);
        }

        static void SortArray(int[] arrayNum){
            Array.Sort(arrayNum);
            Console.WriteLine("Hasil Sort: ");
            for(int i = 0; i < arrayNum.Length; i++){
                Console.WriteLine(arrayNum[i]);
            }
        }

        static void ReverseArray(int[] arrayNum){
            Array.Reverse(arrayNum);
            Console.WriteLine("Hasil Reverse: ");
            for(int i = 0; i < arrayNum.Length; i++){
                Console.WriteLine(arrayNum[i]);
            }
        }

        static void SpliceArray(int[] arrayNum, int index, int value){
            int[] array2 = new int[arrayNum.Length +1];
            for(int i = 0; i < array2.Length-1; i++){
                if(i == index){
                    array2[i] = value;
                    array2[i+1] = arrayNum[i];
                }
                else if(i < index){
                    array2[i] = arrayNum[i];
                }
                else if(i > index){
                    array2[i+1] = arrayNum[i];
                }
            }
            for(int i = 0; i < array2.Length; i++){
                Console.WriteLine(array2[i]);
            }
        }

        static void fizzbuzz(int num){
            for(int i = 1; i <= num; i++){
                if(i % 2 == 0){
                    if(i % 3 == 0){
                        Console.WriteLine(i+". "+"Fizz Buzz");
                    }
                    else{
                        Console.WriteLine(i+". "+"Fizz");
                    }
                }
                else if(i % 3 == 0){
                    Console.WriteLine(i+". "+"Buzz");
                }
            }
        }

        static char MaxChar(string s){
            s = s.Replace(" ","");
            s.ToLower();
            char[] s2 = s.ToCharArray();
            char answer = ' ';
            Array.Sort(s2);
            var count = 1;
            var intMax = 0;
            for(int i = 0; i < s2.Length-1; i++){
                if(s2[i] == s2[i+1]){count++;}
                else{
                    if(count > intMax){
                        intMax = count;
                        answer = s2[i];
                        count = 1;
                    }
                    else{
                        count = 1;
                    }
                }
            }
            return answer;
        }
        
        static bool IsPalindrome(string s){
            s = s.Replace(" ", "");
            s = s.Replace(".", "");
            s = s.Replace(",", "");        
            s = s.Replace(":", "");
            s = s.Replace("?", "");
            s = s.Replace("!", "");
            s = s.ToLower();

            return s.SequenceEqual(s.Reverse());
        }

        static int factorial(int number){
            if(number == 0){return 1;}
            return number * factorial(number-1);
        }

        static string Capitalize(string s){
            char[] Trimmed = {' '};
            string s2 = s.Trim(Trimmed);
            char[] arrayChar = s2.ToCharArray();
            arrayChar[0] = char.ToUpper(arrayChar[0]);

            for(int i = 0; i < arrayChar.Length; i++){
                if(arrayChar[i] == ' '){
                    arrayChar[i+1] = char.ToUpper(arrayChar[i+1]);
                }
            }
            return new string(arrayChar);

        }

        static string Reverse(string s){
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void IndexNumber(int[] arrayNum, int index){
            Console.WriteLine(Array.IndexOf(arrayNum, index));
        }

        static void LastIndex(int[] arrayNum){
            Console.WriteLine(arrayNum.Length - 1);
        }

        static void Includes(int[] arrayNum, int value){
            Console.WriteLine(arrayNum.Contains(value));
        }

        static void Fills(int[] arrayNum, int value){
            Array.Fill(arrayNum, value);
            for(int i = 0; i < arrayNum.Length; i++){
                Console.WriteLine(arrayNum[i]);
            }
        }

        static void SumNumber(int[] arrayNum){
            int sum = 0;
            for(int i = 0; i < arrayNum.Length; i++){
                sum += arrayNum[i];
            }
            Console.WriteLine(sum);
        }

        static void JoinString(int[] arrayNum, char value){
            string join = string.Join(value, arrayNum);
            Console.WriteLine(join);
        }
    }

    class Caesar{

        public static char cipher(char ch, int key) {  
            if (!char.IsLetter(ch)) {return ch;}  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + key) - d) % 26) + d);  
        } 

        public static void CaesarCipher(string input, int key){
            string output = string.Empty;  
        
            foreach(char ch in input){output += cipher(ch, key);}
        
            Console.WriteLine(output);
        }
    }

    class Sorting{
        public static void swapping(int[] arrayNum, int first, int next){
            int temp;

            temp = arrayNum[first];
            arrayNum[first] = arrayNum[next];
            arrayNum[next] = temp;
        }

        public static void BubbleSort(int[] arrayNum){
            int i, j;
            int arrayLength = arrayNum.Length;

            for(j = arrayLength - 1; j > 0; j--){
                for(i = 0; i < j; i++){
                    if(arrayNum[i] > arrayNum[i + 1]){
                        swapping(arrayNum, i, i + 1);
                    }
                }
            }
            for(i = 0; i < arrayLength; i++){
                Console.Write(arrayNum[i]+" ");
            }
        }

        public static void InsertionSort(int[] arrayNum){
            int i, j;
            int arrayLength = arrayNum.Length;

            for(j = 1; j < arrayLength; j++){
                for(i = j; i > 0 && arrayNum[i] < arrayNum[i - 1]; i--){
                    swapping(arrayNum, i, i - 1);
                }
            }
            for(i = 0; i < arrayLength; i++){
                Console.Write(arrayNum[i]+" ");
            }
        }

        public static int ArrayMinimal(int[] arrayNum, int start){
            int minPos = start;
            for (int pos=start+1; pos < arrayNum.Length; pos++){
                if (arrayNum[pos] < arrayNum[minPos])
                minPos = pos;
            }
            return minPos;         
        }

        public static void SelectionSort(int[] arrayNum){
            int i;
            int arrayLength = arrayNum.Length;

            for(i = 0; i < arrayLength-1; i++){
                int k = ArrayMinimal(arrayNum, i);
                if(i != k){
                    swapping(arrayNum, i, k);
                }
            }
            for(i = 0; i < arrayLength; i++){
                Console.Write(arrayNum[i]+" ");
            }
        }
    }


}






