using System;

namespace day_5
{
    class Program
    {
       
        static float InputUser()
        {
            String StringInput;
            float FloatNumber;
            do
            {             
                StringInput = Console.ReadLine();
                try
                {
                    FloatNumber = float.Parse(StringInput);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n!!!!!! nhap sai roi hay nhap lai !!!!!!!!!\n ");
                }

            } while (float.TryParse(StringInput, out FloatNumber) == false);
            return FloatNumber;
        }
        static void Main(string[] args)
        {
            bool Anser;
            string AnserStr;
            do
            {
                float a, b, c, d;
                double x1, x2;

                Console.WriteLine("\nnhap a\n");
                a = InputUser();
                Console.WriteLine("\nnhap b\n");
                b = InputUser();
                Console.WriteLine("\nnhap c\n");
                c = InputUser();
                Console.WriteLine("\nKet qua cua phuong trinh {0}x^2+{1}x+{2}=0 la:\n", a, b, c);
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = -b + Math.Sqrt(d) / (2 * a);
                    x2 = -b - Math.Sqrt(d) / (2 * a);
                    Console.WriteLine("=====>PT co hai nghiem phan biet\nx1={0} \nx2={1}", x1, x2);

                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("PT co nghiem kep x1=x2={0}", x1);
                }
                else
                {
                    Console.WriteLine("====>> phuong trinh vo nghiem");
                }
                Console.WriteLine("\nban co muon lam tiep khong?\nNeu muon lam tiep thi an Y, khong muon thi an N");
                AnserStr=Console.ReadLine();
                if (AnserStr =="Y")
                {
                    Anser = true;
                }
                else Anser = false;
            } while (Anser = true);
            


        }

    }
}

