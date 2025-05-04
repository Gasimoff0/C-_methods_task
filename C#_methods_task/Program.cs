using System;

class Program
{
    static void Main()
    {
        #region task1
        //Console.WriteLine("Ededi daxil edin");
        //int eded = Convert.ToInt32(Console.ReadLine());
        //eded = KvadrataYukselt(eded);
        //Console.WriteLine("ededin kvadrati: " + eded);
        #endregion

        #region task2
        //int[] ededler = { 1, 2, 3, 4, 5 };
        //int[] kvadratEdedler = KvadratlaraYukselt(ededler);

        //Console.WriteLine("Kvadratlara yukselmish massiv:");
        //foreach (int num in kvadratEdedler)
        //{
        //    Console.Write(num + " ");
        //}
        #endregion

        #region task3     
        //Console.WriteLine("Yazi daxil edin");
        //string name = Console.ReadLine();
        //name = BosluqlariSil(name);
        //Console.WriteLine("Boshluqsuz yazi: " + name);
        #endregion

        #region task4
        //int[] nums = { 1, 5, 7 };
        //nums = ArrayElementElaveEt(nums, 3);

        //Console.WriteLine("Yeni array:");
        //foreach (int num in nums)
        //{
        //    Console.Write(num + " ");  
        //}
        #endregion

    }
    //task1
    public static int KvadrataYukselt(int x)
    {
        return x * x;
    }

    //task2
    public static int[] KvadratlaraYukselt(int[] array)
    {
        int[] yeniArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            yeniArray[i] = array[i] * array[i];
        }

        return yeniArray;
    }

    //task3
    public static string BosluqlariSil(string metn)
    {
        return metn.Replace(" " , "");
    }

    //task4
    public static int[] ArrayElementElaveEt(int[] array, int yeniElement)
    {
        int[] yeniArray = new int[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            yeniArray[i] = array[i];
        }

        yeniArray[array.Length] = yeniElement;

        return yeniArray;
    }
}
