namespace Hometask_Array_DateTime_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForMethods_Task_1
            ReverseOfMassiv(1, 2, 3, 4, 5, 6, 7, 8);
            #endregion
            #region ForMethods_Task_2
            AgeCalculator(new DateTime(2003, 11, 21));
            #endregion
            #region ForMethods_Task_3
            IsLeapYear(2024);
            #endregion
        }

        #region Task_1
        //Mehtod yazirsiz massiv qebul edib reverse edib yeni massiv qaytarsin(hazir method istifade etmek olmaz)

        static void ReverseOfMassiv(params int[]arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int[] newarray = arr;
                Console.WriteLine(newarray[i]);

            }

        }
        #endregion
        #region Task_2
        //İnsanın yaşını doğum tarixinə görə hesablayan C#
        //proqramı yazın.Proqram doğum tarixini giriş kimi götürməli və şəxsin yaşını çıxarmalıdır.
        static void AgeCalculator(DateTime BirhDate)
        {
            DateTime CurretDate=DateTime.Now;
            int birthdayyear=BirhDate.Year;
            int currentyear = CurretDate.Year;
            int age = currentyear - birthdayyear;
            Console.WriteLine(age);

        }
        #endregion
        #region Task_3
        //Verilən ilin "leap" ili olub olmadığını yoxlayan C# proqramı
        //yazın.Proqram "leap" ili olub-olmamasından asılı olmayaraq ili giriş və çıxış kimi qəbul etməlidir.(leap year nedir arashdirin)

        //qeyd: methodlar ile yazin.
        static void IsLeapYear(int year)
        {
            bool isLeapYear=DateTime.IsLeapYear(year);
            Console.WriteLine(isLeapYear);
        }
        #endregion



    }
}