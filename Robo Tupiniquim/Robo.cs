
namespace Robo_Tupiniquim
{
    public class Robo
    {
        public  char direcao;
        public   int x = 0;
        public  int y = 0;

        public  char VirarEsquerda()
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

        public  char VirarDireita()
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

        public  void Mover()
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
