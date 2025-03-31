namespace Robo_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] limites = Console.ReadLine().Split(' ');
            int xMax = int.Parse(limites[0]);
            int yMax = int.Parse(limites[1]);

            while (true)
            {
                string posicaoInicial = Console.ReadLine();
                if (string.IsNullOrEmpty(posicaoInicial)) break;
                string comandos = Console.ReadLine();

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
                        Mover(ref x, ref y, direcao, xMax, yMax);
                    }
                }
                Console.WriteLine($"{x} {y} {direcao}");
            }
        }

       
    }
}
