
namespace Robo_Tupiniquim
{
    internal class Program
    {
        public static void Main(string[] args)
    {
        string[] limites = Console.ReadLine()!.Split(' ');
        int xMax = int.Parse(limites[0]);
        int yMax = int.Parse(limites[1]);

        while (true)
        {
            string posicaoInicial = Console.ReadLine()!;
            string comandos = Console.ReadLine()!;

            string[] posicao = posicaoInicial.Split(' ');
            int x = int.Parse(posicao[0]);
            int y = int.Parse(posicao[1]);
            char direcao = char.Parse(posicao[2]);

            foreach (char comando in comandos)
            {
                if (comando == 'E')
                {
                    direcao = VirarEsquerda(direcao);
                }
                else if (comando == 'D')
                {
                    direcao = VirarDireita(direcao);
                }
                else if (comando == 'M')
                {
                    Mover( x,  y, direcao, xMax, yMax);
                }
            }
             
                    Console.WriteLine($"{x} {y} {direcao}");
                    Console.ReadLine();
                
        }
          
        }

    public static char VirarEsquerda(char direcao)
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

    public static char VirarDireita(char direcao)
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

        public static void Mover(int x,  int y, char direcao, int xMax, int yMax)
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