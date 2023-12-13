using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_WhenAll
{
    internal class Exemplos
    {
        public static async Task CriaDiretoriosEmLoop(string caminhoDiretorio, string nomeDiretorio)
        {
            string novaPasta = $"{caminhoDiretorio}\\{nomeDiretorio}";
            string novaPastaDinamica = novaPasta;

            for (int i = 1; i < 11; i++)
            {
                if (!Directory.Exists(novaPastaDinamica))
                {
                    Directory.CreateDirectory(novaPastaDinamica);
                    
                    Console.WriteLine("Diretório criado com sucesso!");
                    await Task.Delay(1000);
                }
                novaPastaDinamica = $"{novaPasta}({i})";
            }
        }

        public static async Task CriaArquivosEmLoop(string caminhoArquivo, string nomeArquivo, string extensao)
        {
            string novoArquivo = $"{caminhoArquivo}\\{nomeArquivo}{extensao}";
            string[] conteudos = ArrayConteudos();
            string conteudo;
            string novoArquivoDinamico = novoArquivo;
            Random random = new();
            int numeroAleatorio;

            for (int i = 1; i < 11; i++)
            {
                numeroAleatorio = random.Next(0, 10);
                conteudo = conteudos[numeroAleatorio];

                if (!File.Exists(novoArquivoDinamico))
                {
                    File.WriteAllText(novoArquivoDinamico, conteudo);
                    Console.WriteLine("Arquivo Criado com sucesso!");
                    await Task.Delay(2000);

                    novoArquivoDinamico = $"{caminhoArquivo}\\{nomeArquivo}({i}){extensao}";
                }
            }
        }

        public static string[] ArrayConteudos()
        {
            string[] conteudos = 
                    ["Se Deus não existe, tudo é permitido. (Dostoiévski)",
                    "Nada é permanente, exceto a mudança. (Heráclito de Éfeso)", 
                    "Só sei que nada sei. (Sócrates)",
                    "Uma vida sem reflexão não vale a pena ser vivida. (Sócrates)",
                    "Creio para compreender e compreendo para crer melhor. (Santo Agostinho)",
                    "O desordenado amor por si mesmo é a causa de todos os pecados. (São Tomás de Aquino)",
                    "Penso, logo existo. (Descartes)",
                    "O homem é o lobo do homem. (Hobbes)",
                    "Onde não há lei, não há liberdade. (Locke)",
                    "Compara-se muitas vezes a crueldade do homem à das feras, mas isso é injuriar estas últimas. (Dostoiévski)"];

            return conteudos;
        }

        public static string GetDesktopPath()
        {
            // Obter o caminho do diretório da área de trabalho
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            return desktopPath;
        }
    }
}
