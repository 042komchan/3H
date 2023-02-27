class Program {
    static void Main(string[] args){
        int sum, add, multiply;

        for (sum = 0, add = 1, multiply = 1;
        add <= 10;
        add++, multiply *= 2) {
            sum += add * multiply;
            }
            Console.WriteLine("Summary is {0}", sum);
    }
}
