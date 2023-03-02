using System;

    class Program {
        static void Main(string[] args) {
            Console.Write("Please input password : ");
            int password = int.Parse(Console.ReadLine());

            Console.Write("Please input agency : ");
            string agency = Console.ReadLine();

            int password1 = password / 100000;
            int password2 = ((password - (password1 * 100000 )) / 10000);
            int password3 = ((password - (password1 * 100000 ) - (password2 * 10000)) / 1000);
            int password4 = ((password - (password1 * 100000 ) - (password2 * 10000) - (password3 * 1000)) / 100);
            int password5 = ((password - (password1 * 100000 ) - (password2 * 10000) - (password3 * 1000) - (password4 * 100)) / 10);
            int password6 = password - (password1 * 100000 ) - (password2 * 10000) - (password3 * 1000) - (password4 * 100) - (password5 * 10);

            if (agency == "CIA") {
                if ((password6 % 3 == 0) && (password5 != 1 && password5 != 3 && password5 != 5) && (password3 >=6 && password3 != 8)) {
                Console.WriteLine("True");
                } else {
                Console.WriteLine("False");
                }
            } else if (agency == "FBI") {
                if ((password1 >= 4 && password1 <= 7) && (password4 % 2 == 0 && password4 != 6) && (password2 %2 != 0)) {
                Console.WriteLine("True");
                } else {
                Console.WriteLine("False");
                }
            } else if (agency == "NSA") {
                if ((password == 1 || password6 == 2 || password6 == 3 || password6 == 5 || password6 == 6) && (password4 % 3 == 0 && password4 % 2 != 0)
                && (password1 == 7 || password2 == 7 || password3 == 7 || password5 == 7 || (password1 == 7 && password2 == 7 && password3 == 7 && password5 ==7)
                || (password1 == 7 && password2 == 7 && password3 == 7) || (password2 == 7 && password3 == 7 && password5 == 7) || 
                (password1 == 7 && password2 == 7 && password5 == 7) || (password1 == 7 && password3 == 7 && password5 == 7) || (password1 == 7 && password2 ==7)
                || (password2 == 7 && password3 == 7) || (password3 == 7 && password5 == 7) || (password1 == 7 && password3 == 7) ||
                (password1 == 7 && password5 == 7) || (password2 == 7 && password5 == 7))) {
                Console.WriteLine("True");
                } else {
                Console.WriteLine("False");   
                }
            } else {
                Console.WriteLine("Password is incorrect");
            }
    }
 }
