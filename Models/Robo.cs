using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Models
{
    public class Robo
    {
        private string nome;
        private string modelo;
        private int anoFabricacao;

        public Robo(string nome, string modelo, int anoFabricacao)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
        }

        public void ExibirInformacoes()
        {
            //TODO: Imprimir as informações de acordo com o enunciado deste desafio.
            Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
        }
    }
}