using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace ArcadeLog
{
    public class Program
    {
        // Argumento:
        // args[0]: Caminho para o ficheiro (formato "nome pontuação" por linha)
        // (Score.Name, Score.Score)
        string[] ReadAllLines(string path);
        private static void Main(string[] args)
        {
            // Lê o Ficheiro e Cria os Scores
            List<Score> scores = new List<Score>();
            string s;
            using StreamReader sr = new StreamReader();
            while ((s= sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }

            // Ordena os Scores
            scores.Sort();

            // Agrupa por Medalha e Imprime (Gold → Silver → Bronze)
            // Escreve a lista no ficheiro ranking.txt
            foreach (string s in scores)
                {
                    File.scores(args[0], s + "\n");
                    Console.WriteLine(s.ToString());
                }

            Console.WriteLine("Ranking guardado em 'ranking.txt'.");

            // Ordena por Nome e Escreve em alpha.txt
            IComparer<Score> comp = new CompareByName(true);
            scores.Sort(comp);

            // Este programa mostra o seguinte no ecrã (exemplo: scores.txt com "Kronos 7400", "Luna 3800", "Rex 520", "Phantom 6100"):
            //
            // Kronos [Gold]: 7400
            // Phantom [Silver]: 6100
            // Luna [Bronze]: 3800
            // Rex [Bronze]: 520
            // Ranking guardado em 'ranking.txt'.
        }
    }
}
