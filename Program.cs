using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Exemplo de Casting
            Casting();
            Console.WriteLine();

            //Programa sobre produtos.
            string produto1 = "Commputer";
            string produto2 = "Mesa de Computador";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ", Cuja o preço é $ " + preco1);
            Console.WriteLine(produto2 + ", Cuja o preço é $ " + preco2);
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine(media.ToString("F8"));
            Console.WriteLine(media.ToString("F3"));
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Metodo Split
            Console.Write("Digite seu nome: ");
            string s = Console.ReadLine();

            string [] vet = s.Split(' ');
            string nome = vet [0];
            string sobrenome = vet [1];
            string ultimoNome = vet [2];
            Console.WriteLine();
            Console.WriteLine($"Nome Completo: {nome} {sobrenome} {ultimoNome}");
            Console.WriteLine();

            //Valor do produto
            ProdutoDC();
            Console.WriteLine();

            //Saida de dados
            SaidaDeDados();
            Console.WriteLine();
            

            //Sistema de Horário
            Console.Write("Quantas horas são: ");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if(hora > 12 && hora < 17) {
                Console.WriteLine("Boa Tarde!");
            }
            else if(hora > 17 && hora < 20) {
                Console.WriteLine("Boa noite!");
            }
            Console.WriteLine();
            

            //Exercicios Compostos
            Console.WriteLine("digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);          
            

            //Estrutura de While.
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(n > 0.0) {
                double raiz = Math.Sqrt(n);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro Número: ");
                n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo!");
            Console.WriteLine();
            
            //Estrutura de For.
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine();
            

            //Triangulo
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Digite o lado do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o lado do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areaX.ToString("F6", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F6", CultureInfo.InvariantCulture));

            if(areaY < areaX) {
                Console.WriteLine("Maior area: X");
            }
            else {
                Console.WriteLine("Maior area: Y");
            }
            Console.WriteLine();



        }

        static void Casting() {
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
        }

        static void ProdutoDC() {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Digite um produto a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Produto Atualizado: " + p);

            Console.WriteLine();
            Console.Write("Digite um produto a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Produto atualizado: " + p);
        }

        static void SaidaDeDados() {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string [] vet1 = Console.ReadLine().Split(' ');
            string nome2 = vet1 [0];
            int idade = int.Parse(vet1 [1]);
            double altura = double.Parse(vet1 [2]);

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }

        static int Maior(int a, int b, int c ) {
            int m;
            if(a > b && a > c) {
                m = a;
            }
            else if(b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}
