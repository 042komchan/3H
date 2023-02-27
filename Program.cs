class Program {
    static void Main(string[] args){
        int count = 0;
        int i = 0;

        while(1 < 10) {
            int x = int.Parse(Console.ReadLine());
            i++;
            if (x % 5 == 0) {
                continue;
            }
        Console.WriteLine("even");
        count++;
        }
    Console.WriteLine("Total: {0}", count);
    }
}
