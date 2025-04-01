
namespace Robo_Tupiniquim
{
    internal class Program
    {
        
        static int xMax;
        static int yMax;
        public static void Main(string[] args)
        {
           
               

                

                Console.WriteLine("Escreva o tamanho do grid\nUtilize um espaço para separar X e Y");
            string[] TamanhoGrid = Console.ReadLine()!.Split(' ');

            xMax = int.Parse(TamanhoGrid[0]);
            yMax = int.Parse(TamanhoGrid[1]);

            Robo[] robos = new Robo[2];
            for (int i = 0; i < 2; i++)
            {
                Robo robo = new Robo();
                Console.WriteLine("Escreva a posição Inicial do Robo\nUtilize um espaco para separar (X, Y e a Direção em que ele esta olhando)");
            string posicaoInicial = Console.ReadLine()!;

            Console.WriteLine("Escreva os Comandos do Robo!");
            string comandos = Console.ReadLine()!;

            string[] posicao = posicaoInicial.Split(' ');

           
           

                robo.x = int.Parse(posicao[0]);
                robo.y = int.Parse(posicao[1]);
                robo.direcao = char.Parse(posicao[2]);

                foreach (char comando in comandos)
                {
                    if (comando == 'E')
                    {
                        robo.direcao = robo.VirarEsquerda();
                    }
                    else if (comando == 'D')
                    {
                        robo.direcao = robo.VirarDireita();
                    }
                    else if (comando == 'M')
                    {
                        robo.Mover();

                    }
                }
                if (robo.x > xMax || robo.y > yMax || robo.x < 0 || robo.y < 0)
                    Console.WriteLine("Voce digitou coordenadas invalidas");

                else
                {
                    robos[i] = robo;

                }
            }

            Console.WriteLine($"{robos[0].x} {robos[0].y} {robos[0].direcao}");
            Console.WriteLine($"{robos[1].x} {robos[1].y} {robos[1].direcao}");

            Console.ReadLine();
          
        }



    }
}