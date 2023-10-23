namespace wwhile;

class Program
{
    static void Main(string[] args)
    {
        //1 den n e kadar( n dahil) olan sayıların ortalamsını while ile konsola yazdıran program
        Console.WriteLine("bir sayı giriniz.");
        int sayi=int.Parse(Console.ReadLine());
        int i=1,toplam=0,ort;
        while(i<=sayi){
            toplam=toplam+i;
            i++;
        }
        ort=toplam/sayi;
        Console.WriteLine("Ortalama:"+ort);


        //A dan Z ye kadar olan sayıları yazdır

        char character='A';
        while(character<='Z'){
            Console.WriteLine(character);
            character ++;

        }
        //for each

        string[] cars={"AUIDI","BMW","VOLKSWOGAN"};
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

    }
}
