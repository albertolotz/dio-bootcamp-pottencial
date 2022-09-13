using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExExplorando.Models
{
    public class LeituraFile
    {
        public (bool sucesso, string[] linhas, int quantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }catch(Exception)
            {
                return (false, new string[0], 0);
            }
            
        } 
    }
}