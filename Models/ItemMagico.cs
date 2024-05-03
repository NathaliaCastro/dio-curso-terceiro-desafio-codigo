using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Models
{
    public class ItemMagico
    {
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder

        public string Nome {get; private set;}
        public string Descricao {get; private set;}
        public int Poder {get; private set;}

        public ItemMagico(string nome, string descricao, int poder)
        {
            Nome = nome;
            Descricao = descricao;
            Poder = poder;
        }
    }
}