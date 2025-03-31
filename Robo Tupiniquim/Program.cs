
namespace Robo_Tupiniquim
{
    internal class Program
    {
        static int x;
        static int y;
        static char direcao;
        static int xMax;
        static int yMax;
        public static void Main(string[] args)
    {
        Console.WriteLine("Escreva o tamanho do grid\nUtilize um espaço para separar X e Y\nTamanho Maximo: 9|9");
        string[] TamanhoGrid = Console.ReadLine()!.Split(' ');
         xMax = int.Parse(TamanhoGrid[0]);
         yMax = int.Parse(TamanhoGrid[1]);
            int Robos = 0;
        while (Robos < 2)
        {
            Console.WriteLine("Escreva a posição Inicial do Robo\nUtilize um espaco para separar (X, Y e a Direção em que ele esta olhando)");
            string posicaoInicial = Console.ReadLine()!;

            Console.WriteLine("Escreva os Comandos do Robo!");
            string comandos = Console.ReadLine()!;

            string[] posicao = posicaoInicial.Split(' ');
            
  
             x = int.Parse(posicao[0]);
             y = int.Parse(posicao[1]);
             direcao = char.Parse(posicao[2]);

            foreach (char comando in comandos)
            {
                if (comando == 'E')
                {
                    direcao = VirarEsquerda();
                }
                else if (comando == 'D')
                {
                    direcao = VirarDireita();
                }
                else if (comando == 'M')
                {
                    Mover();
                }
            }
                if (x > xMax || y > yMax || x < 0 || y < 0)
                    Console.WriteLine("Voce digitou coordenadas invalidas");

                else
                {
                    Console.WriteLine($"{x} {y} {direcao}\nAperte ENTER para digitar as coordenadas do segundo ROBO");
                    Console.ReadLine();
                    Robos++;
                }
                
        }
          
        }

    public static char VirarEsquerda()
    {
        switch (direcao)
        {
            case 'N': return 'O';
            case 'O': return 'S';
            case 'S': return 'L';
            case 'L': return 'N';
            default: return direcao;
        }
    }

    public static char VirarDireita()
    {
        switch (direcao)
        {
            case 'N': return 'L';
            case 'L': return 'S';
            case 'S': return 'O';
            case 'O': return 'N';
            default: return direcao;
        }
    }

        public static void Mover()
        {
            switch (direcao)
            {
                case 'N': y++; break;
                case 'S': y--; break;
                case 'L': x++; break;
                case 'O': x--; break;
            }
        }

    }
}