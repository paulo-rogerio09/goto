using System;

class tarefa
{
    static void Main(string[] args)
    {
        while(true)
        {
            
            Menu();
            Console.WriteLine("\n escolha uma opção");
            int caso = Convert.ToInt32(Console.ReadLine());

            switch (caso)
            {
                case 1:
                    Console.WriteLine("Digite o ínicio do intervalo: ");
                    ulong inicio = Convert.ToUInt64(Console.ReadLine());
                    Console.WriteLine("Digite o final do intervalo: ");
                    ulong fim = Convert.ToUInt64(Console.ReadLine());

                    Console.WriteLine($"Média: {Opcao1(inicio, fim).ToString("0.00")}");
                    break;

                case 2:
                    Console.WriteLine("Digite seu nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite sua data de nascimento: ");
                    DateTime idade = Convert.ToDateTime(Console.ReadLine());

                    if (Opcao2(idade))
                    {
                        Console.WriteLine($"{nome}, você pode entrar na festa");
                    }
                    else
                    {
                        Console.WriteLine($"{nome}, você NÃO pode entrar na festa");
                    }
                    break;

                case 3:
                    Console.WriteLine("digite o tamanho do lado: ");
                    double resposta3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"A area do quadrado é: {Opcao3(resposta3)}");
                    break;

                case 4:
                    Console.WriteLine("Digite seu salário: ");
                    double dinheiro = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Seu salário líquido é de R${Opcao4(dinheiro).ToString("0.00")}");
                    break;

                case 5:
                    Console.WriteLine("Digite o valor de A:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de C:");
                    int c = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"X1 = {Opcao5(a, b, c, 1).ToString("0.00")}");
                    Console.WriteLine($"X2 = {Opcao5(a, b, c, 2).ToString("0.00")}");
                    break;

                case 6:
                    Console.WriteLine("digite o tamanho do raio do circulo:");
                    double resposta6 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"A area do circulo é: {Opcao6(resposta6)}");
                    break;

                case 7:
                    Console.WriteLine("digite o tamanho do raio da esfera:");
                    double resposta7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"O volume da esfera é: {Opcao7(resposta7)}");
                    break;

                case 8:
                    Console.WriteLine("digite o seu peso");
                    double peso = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite a sua altura em centimetros:");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Opcao8(peso, altura);
                    
                    break;

                case 9:
                    Console.Write("Digite um número:");
                    int numeroperfeito = Convert.ToInt32(Console.ReadLine());

                    if (Opcao9(numeroperfeito))
                    {
                        Console.WriteLine("O número É perfeito");
                    }
                    else
                    {
                        Console.WriteLine("O número NÃO é perfeito");
                    }
                    break;

                case 10:
                    Opcao10();

                    break;

                case 11:

                    goto exit;
                    break;

            }
        }

    exit:;



    }


    static void Menu()
    {
        Console.WriteLine("Escolha uma opção\n" +
            "1 - Média de números divisiveis por 2 e 3\n" + 
            "2 - Informar se pode entrar na festa\n" + 
            "3 - Área do quadrado\n" + 
            "4 - Salário líquido\n" +
            "5 - Bhaskara\n" +
            "6 - Área de um círculo\n" + 
            "7 - Volume de esfera\n" + 
            "8 - Índice de Massa Corporal\n" + 
            "9 - Números perfeitos\n" +
            "10 - Valor de ingressos\n" +
            "11 - Sair do programa");
    }

    static double Opcao1(ulong inicio, ulong fim)
    {
        ulong x = 0;
        ulong y = 0;
        for (ulong i = inicio; i < fim; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                ulong resultado1 = i + i;
                x += resultado1;
                y++;
            }
        }
        ulong resultado2 = (x / 2) / y;
        return resultado2;
    }

    static bool Opcao2(DateTime idade)
    {
        DateTime agr = DateTime.Now;
        if ((agr.Year - idade.Year) >= 60)
        {
            if (idade.Month <= agr.Month)
            {
                return true;
            }
            if (idade.Month == agr.Month)
            {
                return true;
            }
        }
        return false;
    }

    static double Opcao3(double resposta)
    {
        double resultado = 0;

        resultado = resposta * resposta;

        return resultado;
    }

    static double Opcao4(double dinheiro)
    {
        double x = 0;
        double xx = dinheiro * 0.15;

        if (dinheiro <= 2100.0)
        {
            Console.WriteLine("Isento");
        }
        else if (dinheiro >= 2250.01 && dinheiro <= 3400.00)
        {
            x = (dinheiro - 2250.01) * 0.08;
        }
        else if (dinheiro >= 3400.01 && dinheiro <= 5850.0)
        {
            x = (dinheiro - 3400.01) * 0.18 + (1000 * 0.08);
        }
        else if (dinheiro > 5850.0)
        {
            x = (dinheiro - 5850) * 0.28 + (2400 * 0.18) + (1000 * 0.08);
        }
        return dinheiro - x - xx;
    }

    static double Opcao5(int a, int b, int c, int opç)
    {
        double delta1 = (b * b) - (4 * a * c);

        double raiz2 = Math.Sqrt(delta1);

        if (delta1 < 0 || a == 0)
        {
            Console.WriteLine("Impossível de calcular");
        }
        else
        {
            double x1 = ((-(b) + raiz2)) / (2 * a);
            double x2 = ((-(b) - raiz2)) / (2 * a);

            if (opç == 1)
            {
                return x1;
            }
            else if (opç == 2)
            {
                return x2;
            }
        }
        return 0;
    }

    static double Opcao6(double resposta)
    {
        double resultado = 0;

        resultado = 4.0 / 3 * Math.PI * (resposta * resposta * resposta);

        return resultado;
    }

    static double Opcao7(double resposta)
    {
        double resultado = 0;

        resultado = (resposta * resposta) * Math.PI;

        return resultado;
    }

    static double Opcao8(double altura, double peso)
    {
        double resultado = 0;

        resultado = (altura * altura) / peso;

        if (resultado < 18.5)
        {
            Console.WriteLine("abaixo do peso");

        }

        if (resultado >= 18.5 && resultado <= 24.9)
        {
            Console.WriteLine("peso normal");

        }

        if (resultado >= 25 && resultado <= 29.9)
        {
            Console.WriteLine("sobrepeso");

        }

        if (resultado >= 30 && resultado <= 34.99)
        {
            Console.WriteLine(" obesidade grau I");

        }

        if (resultado >= 35 && resultado <= 39.99)
        {
            Console.WriteLine("obesidade grau II (severa)");

        }

        if (resultado >= 40)
        {
            Console.WriteLine("obesidade grau III (mórbida)");

        }

        return resultado;
    }

    static bool Opcao9(int n)
    {
        int soma = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                soma = soma + i;
            }
        }
        if (soma == n)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Opcao10()
    {
        DateTime agr = DateTime.Now;

        Console.WriteLine("Quantas pessoas irão comprar o ingresso? ");
        int numPessoas = Convert.ToInt32(Console.ReadLine());
        int resultado = 0;

        for (int i = 0; i < numPessoas; i++)
        {
            int[] pessoas = new int[numPessoas];

            Console.WriteLine("Digite a data de nascimento: ");
            DateTime[] data = new DateTime[numPessoas];
            data[i] = Convert.ToDateTime(Console.ReadLine());
            DateTime outro = data[i];

            if ((agr.Year - outro.Year) < 10)
            {

            }
            else if ((agr.Year - outro.Year) >= 8 && (agr.Year - outro.Year) <= 59)
            {
                resultado += 50;
            }
            else
            {
                resultado += 25;
            }
        }

        Console.WriteLine($"O valor total dos ingressos é R${resultado}");

    }
}