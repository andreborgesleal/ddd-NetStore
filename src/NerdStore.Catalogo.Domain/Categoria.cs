using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        protected Categoria() { }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

            Validar();
        }
        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(valor: Nome, mensagem: "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeIgual(object1: Codigo, object2: 0, mensagem: "O campo Codigo não pode ser 0");
        }
    }
}
