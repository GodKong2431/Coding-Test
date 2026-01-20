using System;

class Program {
    static void Main(string[] args) {
        string tInput = Console.ReadLine();
        if (string.IsNullOrEmpty(tInput)) return;
        
        int T = int.Parse(tInput);

        for (int i = 0; i < T; i++) {
            string[] inputs = Console.ReadLine().Split();
            
            int H = int.Parse(inputs[0]);
            int W = int.Parse(inputs[1]);
            int N = int.Parse(inputs[2]);

            int floor;
            int roomNumber;

            if (N % H == 0) {
                floor = H;
                roomNumber = N / H;
            } else {
                floor = N % H;
                roomNumber = (N / H) + 1;
            }

            Console.WriteLine(floor * 100 + roomNumber);
        }
    }
}