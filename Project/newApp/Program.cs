internal class Program{
    private static void Main(String[] args){
        int a;
        System.Console.Write("gia tri cua a la: ");
        a=Convert.ToInt32(Console.ReadLine());
        int b;
        System.Console.Write("gia tri cua b la: ");
        b=Convert.ToInt32(Console.ReadLine());
        if (a>b){
            System.Console.Write("a lon hon b ");
            
        }else if(a<b){
            System.Console.Write("a nho hon b");
        }else{
            System.Console.Write("a bang b ");
        }


    }
}