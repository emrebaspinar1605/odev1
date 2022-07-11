Console.Write("Lütfen Bir Pozitif sayı giriniz : ");
int sayim=Convert.ToInt32(Console.ReadLine());
int[] array=new int[sayim];
int n=0;
if (sayim<0)
{
    Console.Write("Lütfen Pozitif bir Sayı girin :");
    sayim=Convert.ToInt32(Console.ReadLine());
    
}
for (int i = 1; i < sayim; i++)
{
    Console.Write("Lütfen "+i+". Sayıyı Giriniz");
    int sayi=Convert.ToInt32(Console.ReadLine());
    if (sayi%2==0)
    {
        array[n]=sayi;
        n++;
    }
}
Array.Resize<int>(ref array,n);
foreach (var element in array)
{
    Console.WriteLine(element);
}
