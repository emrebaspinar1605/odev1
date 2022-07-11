class Odev
{  
        public static void Main(string[] args)
        {
        //Ödev1
        Console.WriteLine("***** Ödev1 *****");
        Console.WriteLine();
        Console.Write("Lütfen Bir Pozitif sayı giriniz : ");
        int sayim=Convert.ToInt32(Console.ReadLine());
        int[] array=new int[sayim];
        int n=0;
        if (sayim<0)
        {
            Console.Write("Lütfen Pozitif bir Sayı girin :");
            sayim=Convert.ToInt32(Console.ReadLine());

        }
        for (int i = 1; i <=sayim; i++)
        {
            Console.Write("Lütfen "+i+". Sayıyı Giriniz :");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if (sayi%2==0)
            {
                array[n]=sayi;
                n++;
            }
        }
        Array.Resize<int>(ref array,n);
         n=0;
        foreach (var element in array)
        {
            Console.WriteLine(element);
        }
        //Ödev2
        Console.WriteLine();
        Console.WriteLine("***** Ödev2 *****");
        Console.WriteLine();
        
        Console.Write("Lütfen 1 pozitif sayı giriniz : ");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.Write("Lütfen 2 pozitif sayı giriniz : ");
        int x2=Convert.ToInt32(Console.ReadLine());
        int[] dizi2=new int[x];
        if (x>0)
        {
            for (int i = 1; i<=x; i++)
            {      
                Console.Write("Lütfen "+i+". Sayıyı giriniz : ");
                int y=Convert.ToInt32(Console.ReadLine());
                if (y==x2 || y%x2==0)
                {
                    dizi2[n]=y;
                    n++;
                }
            }
            Array.Resize(ref dizi2,n);
            n=0;
            foreach (var item in dizi2)
            {
            Console.WriteLine(item);   
            }
        }
        Ödev3
        Console.WriteLine("***** Ödev3 *****");
        Console.WriteLine();
        Console.WriteLine("Bir Sayı giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());
        string[] dizi3=new string[a];
        for (int i = 0; i <a; i++)
        {
            
            Console.WriteLine("Lütfen Kelimeyi giriniz: ");
            string word=Console.ReadLine().ToString();
            dizi3[i]=word;
        }
        Console.WriteLine(" ");
        for (int i = a - 1; i >= 0 ; i--)
        {
            Console.WriteLine(dizi3[i]);
        }
        Console.WriteLine("***** Ödev4 *****");
        Console.WriteLine();
        Console.WriteLine("Bir Cümle Yazınız giriniz: ");
        string cumle = Console.ReadLine().ToString();
        Console.WriteLine(cumle.Length);
        Console.WriteLine(cumle.IndexOf(" ")+2);
       

        
        
 }

}

