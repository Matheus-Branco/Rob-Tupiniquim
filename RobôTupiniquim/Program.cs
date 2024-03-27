namespace RobôTupiniquim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo o tamanho da grade
            int maxX = 10;
            int maxY = 10;

            // Criando um robô na posição inicial (0, 0) voltado para o norte (N)
            int x = 0, y = 0;
            char orientacao = 'N';

            // Lista para armazenar os movimentos dos robôs
            List<char> movimentos = new List<char> { 'N', 'L', 'S', 'O', 'L', 'N', 'L', 'L', 'S' };

            // Executando os movimentos
            foreach (char movimento in movimentos)
            {
                if (movimento == 'N' && y < maxY)
                    y++;
                else if (movimento == 'S' && y > 0)
                    y--;
                else if (movimento == 'L' && x < maxX)
                    x++;
                else if (movimento == 'O' && x > 0)
                    x--;

                // Exibindo a posição atual do robô
                Console.WriteLine($"Posição atual: ({x}, {y}), Orientação: {orientacao}");
            }
        }
    }
}
