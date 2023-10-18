class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {       double neg = 0;
            double f = 0;
            double pos  = 0;
            double d  = 0;
            double zero = 0;
            double g = 0;
            double v = arr.Count;

                foreach (var item in arr)
                { 
                   // Console.WriteLine(item);
                if (item <0)
                {
                    neg++;  
                }
                else if (item > 0)
                {
                    pos++;
                }
                else
                {
                    zero++;
                }
                }
             //   Console.WriteLine(pos + zero + neg);
               // d = pos/v;
            Console.WriteLine(pos/arr.Count );

               // f = neg / v;
            Console.WriteLine(neg/arr.Count);

               // g = zero / v;
            Console.WriteLine(zero/arr.Count);


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
