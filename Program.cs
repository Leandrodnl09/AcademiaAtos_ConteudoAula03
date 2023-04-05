namespace ConteudoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Endadeamento de condições;
            int n, secreto;
            secreto = 7;

            Console.Write("Digite um número: ");
            Console.WriteLine();
            n = int.Parse(Console.ReadLine());

            if (n == secreto)
            {
                Console.WriteLine("Acertou o número!");
            }
            else
            {
                Console.WriteLine("Errou!");
                if (n > secreto)
                {
                    Console.WriteLine("O número secreto é menor que " + n);
                }
                else 
                {
                    Console.WriteLine("O número secreto e maior que " + n);
                }
            }

            int a = 4, b = 5, c = 9, d = 1;

            if ((a == 0) || b != 5)
            {
                Console.WriteLine("Entrei como verdadeiro!");
            }
            else
                Console.WriteLine("Entrei como falso!");


            if (a == 0 || b != 5)
            {
                Console.WriteLine("Entrei como verdadeiro na 1!"); // False;
            }
            if (a > 3 || d == 1)
            {
                Console.WriteLine("Entrei como verdadeiro na 2!"); // True;
            }
            if ((a > 3 || d < 3) && !(b < c && b > c))
            {
                Console.WriteLine("Entrei como verdadeiro na 3!"); // False;
            }
            if ((b != 0 || a > 4) || (b < 3 && c >= 8))
            {
                Console.WriteLine("Entrei como verdadeiro na 4!"); // False;
            }

            // Declaração das variáveis salario, aumento e novoSalario como do tipo double;
            double salario, aumento, novoSalario;
            // Exibe uma mensagem solicitando ao usuário que informe o salário do vendedor;
            Console.Write("Informe o salário do vendedor: R$ ");
            // Lê o salário informado pelo usuário e converte para double, armazenando na variável salario;
            salario = double.Parse(Console.ReadLine()); 

            if (salario <= 900) // Verifica se o salário informado é menor ou igual a 900;
            {
                aumento = salario * 0.05; // Se for, calcula o aumento como 5% do salário e armazena na variável aumento;
            }
            else if (salario < 1400) // Senão, verifica se o salário informado é menor que 1400;
            {
                aumento = salario * 0.08; // Se for, calcula o aumento como 8% do salário e armazena na variável aumento;
            }
            else // Senão, se o salário informado for maior ou igual a 1400;
            {
                aumento = salario * 0.1; // Calcula o aumento como 10% do salário e armazena na variável aumento;
            }

            // Calcula o novo salário somando o salário informado com o valor do aumento, e armazena na variável novoSalario
            novoSalario = salario + aumento;

            // Exibe na tela o salário atual formatado com duas casas decimais;
            Console.WriteLine("Salário atual: R$ " + salario.ToString("F2"));
            // Exibe na tela o valor do aumento em porcentagem, formatado com duas casas decimais;
            Console.WriteLine("Aumento (%): " + (aumento / salario * 100).ToString("F2") + "%");
            // Exibe na tela o valor do aumento em reais, formatado com duas casas decimais;
            Console.WriteLine("Aumento (R$): R$ " + aumento.ToString("F2"));
            // Exibe na tela o novo salário formatado com duas casas decimais;
            Console.WriteLine("Novo salário: R$ " + novoSalario.ToString("F2"));



            // Solicita ao usuário o valor do primeiro lado do triângulo;
            Console.Write("Digite o valor do primeiro lado: ");
            double lado1 = double.Parse(Console.ReadLine());

            // Solicita ao usuário o valor do segundo lado do triângulo;
            Console.Write("Digite o valor do segundo lado: ");
            double lado2 = double.Parse(Console.ReadLine());
            
            // Solicita ao usuário o valor do terceiro lado do triângulo;
            Console.Write("Digite o valor do terceiro lado: ");
            double lado3 = double.Parse(Console.ReadLine());

            // Verifica se os valores dos lados podem formar um triângulo;
            if ((lado1 < (lado2 + lado3)) && (lado2 < (lado1 + lado3)) && (lado3 < (lado1 + lado2)))
            {
                // Se os valores dos lados formarem um triângulo, verifica a classificação do triângulo;
                if (lado1 == lado2 && lado2 == lado3)
                {
                    // Triângulo com três lados iguais é equilátero;
                    Console.WriteLine("Triângulo Equilátero!");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    // Triângulo com dois lados iguais é isósceles;
                    Console.WriteLine("Triângulo Isósceles!");
                }
                else
                {
                    // Triângulo com todos os lados diferentes é escaleno;
                    Console.WriteLine("Triângulo Escaleno!");
                }
            }
            else
            {
                // Se os valores dos lados não puderem formar um triângulo, informa ao usuário;
                Console.WriteLine("Não é possível formar um triângulo com essas medidas!");
            }


            // declaração das variáveis para armazenar a base, altura e área do triângulo;
            double baseTriangulo, alturaTriangulo, areaTriangulo;

            // solicita ao usuário que informe a base do triângulo e armazena na variável baseTriangulo;
            Console.Write("Digite a base do triângulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            // solicita ao usuário que informe a altura do triângulo e armazena na variável alturaTriangulo;
            Console.Write("Digite a altura do triângulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            // verifica se a base e a altura são diferentes de zero, para evitar divisão por zero e outras inconsistências;
            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                // calcula a área do triângulo usando a fórmula dada e armazena na variável areaTriangulo;
                areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

                // exibe a mensagem com a área do triângulo;
                Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
            }
            else
            {
                // caso a base ou a altura sejam iguais a zero, exibe uma mensagem de erro;
                Console.WriteLine("A base ou a altura não podem ser iguais a zero.");
            }



            // Lê quatro valores;
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            double valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor:");
            double valor4 = double.Parse(Console.ReadLine());

            // Calcula a média;
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Escreve na tela os valores que são superiores à média;
            if (valor1 > media)
            {
                Console.WriteLine($"O valor {valor1} é superior à média ({media}).");
            }

            if (valor2 > media)
            {
                Console.WriteLine($"O valor {valor2} é superior à média ({media}).");
            }

            if (valor3 > media)
            {
                Console.WriteLine($"O valor {valor3} é superior à média ({media}).");
            }

            if (valor4 > media)
            {
                Console.WriteLine($"O valor {valor4} é superior à média ({media}).");
            }
        }
    }
}