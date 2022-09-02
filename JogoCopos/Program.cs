using System;

namespace JogoCopos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de movimentos que o jogador ira realizar: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o caractere entre A, B e C: ");
            char caracter = char.Parse(Console.ReadLine().ToUpper());
            
            if (caracter != 'A' && caracter != 'B' && caracter != 'C')
            {
                Console.WriteLine("Caracter invalido, escolhe A, B ou C");
            }

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Escolha um movimento entre 1, 2 e 3: ");
                int movimento = int.Parse(Console.ReadLine());

                switch (movimento)
                {
                    case 1:
                        if (caracter == 'A')
                        {
                            caracter = 'B';
                            break;
                        }
                        if (caracter == 'B')
                        {
                            caracter = 'A';
                            break;
                        }
                        break;
                    case 2:
                        if (caracter == 'B')
                        {
                            caracter = 'C';
                            break;
                        }
                        if (caracter == 'C')
                        {
                            caracter = 'B';
                            break;
                        }
                        break;
                    case 3:
                        if (caracter == 'C')
                        {
                            caracter = 'A';
                            break;
                        }
                        if (caracter == 'A')
                        {
                            caracter = 'C';
                            break;
                        }
                        break;
                } 
            }
            Console.WriteLine(caracter);
        }
    }
}
