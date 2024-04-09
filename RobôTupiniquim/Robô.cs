namespace RobôTupiniquim
{
    public class Robo
    {
        private int x;
        private int y;
        private char direcao;
        private readonly int maxX;
        private readonly int maxY;

        public Robo(int x, int y, char direcao, int maxX, int maxY)
        {
            this.x = x;
            this.y = y;
            this.direcao = direcao;
            this.maxX = maxX;
            this.maxY = maxY;
        }

        public void Explorar(string comandos)
        {
            foreach (char comando in comandos)
            {
                if (comando == 'E')
                {
                    VirarEsquerda();
                }
                else if (comando == 'D')
                {
                    VirarDireita();
                }
                else if (comando == 'M')
                {
                    Mover();
                }
            }
        }

        private void Mover()
        {
            if ((direcao == 'N' && y < maxY) || (direcao == 'S' && y > 0))
            {
                y += direcao == 'N' ? 1 : -1;
            }
            else if ((direcao == 'L' && x < maxX) || (direcao == 'O' && x > 0))
            {
                x += direcao == 'L' ? 1 : -1;
            }
            else
            {
                Console.WriteLine("O robô acabou de sair da área de exploração, por favor dê meia volta.");
            }
        }

        private void VirarEsquerda()
        {
            switch (direcao)
            {
                case 'N':
                    direcao = 'O';
                    break;
                case 'O':
                    direcao = 'S';
                    break;
                case 'S':
                    direcao = 'L';
                    break;
                case 'L':
                    direcao = 'N';
                    break;
            }
        }

        private void VirarDireita()
        {
            switch (direcao)
            {
                case 'N':
                    direcao = 'L';
                    break;
                case 'L':
                    direcao = 'S';
                    break;
                case 'S':
                    direcao = 'O';
                    break;
                case 'O':
                    direcao = 'N';
                    break;
            }
        }

        public void Output()
        {
            Console.WriteLine($"{x}, {y}, {direcao}");
        }
    }
}