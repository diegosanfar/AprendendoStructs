using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{
    class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;
            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
                teste();
            }

           public void ExibirInfo ()
            {
                Console.WriteLine($"Nome {this.nome}");
                Console.WriteLine($"Preço R$ {this.preco}");
                Console.WriteLine($"Peso {this.peso} KG");
                Console.WriteLine($"Marca {this.marca}");
            }

            public float Calculavalor (float calcula)
            {
                float desconto = this.preco * calcula / 100f;
                return desconto;
            }

            public void teste()
            {
                Console.WriteLine("Teste");
            }
        }
        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola do Ronaldinho", 100f, 1f, "Nike");
            Produto balde = new Produto("Balde Vermelho", 200f, 1.5f, "Buckethead");

            bola.ExibirInfo();
            Console.WriteLine("===============");
            balde.ExibirInfo();
            float ValorFinal = bola.Calculavalor(50f) + balde.Calculavalor(50f);
            Console.WriteLine($"{ValorFinal}");
            Console.ReadKey();
        }

       

      

    }
}
