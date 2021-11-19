using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ListaExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 1            
            /*
            Console.WriteLine("Exercicios 1:");
            var str = Console.ReadLine();

            if (char.IsDigit(char.Parse(str)))
            {
                Console.WriteLine($"O valor informado é um dígito: {str}"); 

            }
            else
            {
                Console.WriteLine($"O valor informado não é um dígito: {str}"); 

            }


            //Exercicio 2
            Console.WriteLine("Exercicios 2:");
            var str2 = Console.ReadLine();

            if (char.TryParse(str2, out char chr2))
            {
                Console.WriteLine((int)chr2); 
            }
            else
            {
                Console.WriteLine($"Não foi possível converter o valor: {chr2}"); 
            }
            

            //Exercicio 3
            Console.WriteLine("Exercicios 3:");

            var str3 = Console.ReadLine();

            try
            {
                if (!int.TryParse(str3, out int chr3))
                {
                    Console.WriteLine($"O valor ({ chr3}) informando não é um inteiro válido.");
                    throw new Exception();
                        
                }

                Console.WriteLine($"O código ASCII é {chr3}: " + (char)chr3 );
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar o código ASCII do valor: {str3}");
            }
            

            //Exercicio 4
            Console.WriteLine("Exercicios 4:");

            var str4 = Console.ReadLine();

            try
            {
                if (!char.TryParse(str4, out char chr4))
                {
                    Console.WriteLine($"O valor ({ chr4}) informando não é um char válido.");
                    throw new Exception();

                }

                if (Char.IsUpper(chr4))
                {
                    Console.WriteLine($"O valor ({ chr4}) informando está em maíusculo.");
                }
                else
                {
                    Console.WriteLine($"Informe um caracter em maíusculo.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar verificar o valor: {str4}");
            }

            

            //Exercicio 5
            Console.WriteLine("Exercicios 5:");

            var str4 = Console.ReadLine();

            try
            {
                if (!char.TryParse(str4, out char chr4))
                {
                    Console.WriteLine($"O valor ({ chr4}) informando não é um char válido.");
                    throw new Exception();

                }

                if (Char.IsLower(chr4))
                {
                    Console.WriteLine($"O valor ({ chr4}) informando está em minusculo.");
                }
                else
                {
                    Console.WriteLine($"Informe um caracter em minusculo.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar verificar o valor: {str4}");
            }

            

            //Exercicio 6
            Console.WriteLine("Exercicios 6:");

            var str4 = Console.ReadLine();

            try
            {
                if (!char.TryParse(str4, out char chr4))
                {
                    Console.WriteLine($"O valor ({ chr4}) informando não é um char válido.");
                    throw new Exception();

                }

                Console.WriteLine($"O valor em maíusculo é: { Char.ToUpper(chr4)}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar verificar o valor: {str4}");
            }

            
            //Exercicio 7
            Console.WriteLine("Exercicios 7:");

            var str4 = Console.ReadLine();

            try
            {
                if (!char.TryParse(str4, out char chr4))
                {
                    Console.WriteLine($"O valor ({ chr4}) informando não é um char válido.");
                    throw new Exception();

                }

                Console.WriteLine($"O valor em maíusculo é: { Char.ToLower(chr4)}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar verificar o valor: {str4}");
            }

            
            //Exercicio 8
            Console.WriteLine("Exercicios 8:");
            try
            {
                var str4 = Console.ReadLine();
                Console.WriteLine($"O valor informado foi: {str4}");
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            //Exercicio 9
            Console.WriteLine("Exercicios 9:");
            try
            {
                var str4 = Console.ReadLine();
                Console.WriteLine($"O valor informado foi: {str4.ToUpper()}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            
            //Exercicio 10
            Console.WriteLine("Exercicios 10:");
            try
            {
                var str4 = Console.ReadLine();
                Console.WriteLine($"O valor informado foi: {str4.ToLower()}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }


            
            //Exercicio 11
            Console.WriteLine("Exercicios 11:");
            try
            {
                Console.WriteLine("Informe o nome do usuário:");
                var nome = Console.ReadLine();
                
                Console.WriteLine("Informe o sobrenome:");
                var sobreNome = Console.ReadLine();

                Console.WriteLine("O nome completo do usuário é: {0} {1}",nome, sobreNome);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            

            //Exercicio 12
            Console.WriteLine("Exercicios 12:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                Console.WriteLine($"Texto Normal   : {texto}");
                string textoInvertido = new string(texto.Reverse().ToArray());

                Console.WriteLine($"Texto Invertido: {textoInvertido}");
                


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            

            //Exercicio 13
            Console.WriteLine("Exercicios 13:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                Console.WriteLine($"Texto Normal   : {texto}");
                string textoAlterado = new string(texto.Remove(texto.Length - 4,4));

                Console.WriteLine($"Texto Invertido: {textoAlterado}");



            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            

            //Exercicio 14
            Console.WriteLine("Exercicios 14:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                Console.WriteLine($"Texto Normal   : {texto}");
                string textoAlterado = new string(texto.Replace('a','b'));

                Console.WriteLine($"Texto Invertido: {textoAlterado}");



            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            

                            //Exercicio 15
                            Console.WriteLine("Exercicios 15:");
                            try
                            {
                                Console.WriteLine("Informe o texto:");
                                var texto = Console.ReadLine();
                                 
                                string texto2 = string.Join(",", texto);
                                Console.WriteLine(texto2);  // Saída: 1 2 3 4 5 6 7 8 9 10


                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
                            }

            

            //Exercicio 16
            Console.WriteLine("Exercicios 16:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                Console.WriteLine(texto.TrimStart().TrimEnd());


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            


            //Exercicio 17
            Console.WriteLine("Exercicios 17:");
            try
            {
                Console.WriteLine("Informe o texto:");
                
                var texto = Console.ReadLine();
                var unique = new HashSet<char>(texto);
                
                Console.Write($"String após remoção dos caracteres duplicados:");
                foreach (char c in unique)
                    Console.Write(c);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }
            


            //Exercicio 18
            Console.WriteLine("Exercicios 18:");
            try
            {
                Console.WriteLine("Informe o texto:");

                var texto = Console.ReadLine();
                Console.WriteLine("Texto sem as vogais: " + texto.Replace("A", "")
                                                                 .Replace("a","")
                                                                 .Replace("E", "")
                                                                 .Replace("e", "")
                                                                 .Replace("I", "")
                                                                 .Replace("i", "")
                                                                 .Replace("O", "")
                                                                 .Replace("o", "")
                                                                 .Replace("U", "")
                                                                 .Replace("u", ""));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }
            

            //Exercicio 19
            Console.WriteLine("Exercicios 19:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();
                
                string[] textoSeparado = texto.Split(' ');

                foreach (var c in textoSeparado)
                {
                    Console.WriteLine(c);  // Saída: John

                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }
            

            //Exercicio 20
            Console.WriteLine("Exercicios 20:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                if (texto.StartsWith("C#"))
                {
                    Console.WriteLine($"Texto começa com C#");
                }
                else
                {
                    Console.WriteLine($"Texto não começa com C#");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }
            

            //Exercicio 21
            Console.WriteLine("Exercicios 21:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                Console.WriteLine("Quantidade de vogais: " + texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u')));

                Console.WriteLine("Quantidade de consoantes: " + texto.Count(x => (x != 'a') && 
                                                                                  (x != 'e') && 
                                                                                  (x != 'i') && 
                                                                                  (x != 'o') && 
                                                                                  (x != 'u')));


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            

                                //Exercicio 22
                                Console.WriteLine("Exercicios 22:");
                                try
                                {
                                    Console.WriteLine("Informe o texto:");
                                    var texto = Console.ReadLine();

                                    Console.WriteLine("Quantidade de vogais: " + texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u')));

                                    Console.WriteLine("Quantidade de consoantes: " + texto.Count(x => (x != 'a') &&
                                                                                                      (x != 'e') &&
                                                                                                      (x != 'i') &&
                                                                                                      (x != 'o') &&
                                                                                                      (x != 'u')));


                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
                                }


                                //Exercicio 23
                                Console.WriteLine("Exercicios 23:");
                                try
                                {
                                    Console.WriteLine("Informe o texto:");
                                    var texto = Console.ReadLine();

                                    Console.WriteLine("Quantidade de vogais: " + texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u')));

                                    Console.WriteLine("Quantidade de consoantes: " + texto.Count(x => (x != 'a') &&
                                                                                                      (x != 'e') &&
                                                                                                      (x != 'i') &&
                                                                                                      (x != 'o') &&
                                                                                                      (x != 'u')));


                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
                                }

            

            //Exercicio 24
            Console.WriteLine("Exercicios 24:");
            try
            {
                Console.WriteLine("Informe o texto:");
                var texto = Console.ReadLine();

                string texto2 = string.Join(" ", texto.ToArray());
                Console.WriteLine(texto2);  // Saída: 1 2 3 4 5 6 7 8 9 10


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }
            

            //Exercicio 25
            Console.WriteLine("Exercicios 25:");

            var str3 = Console.ReadLine();

            try
            {
                if (!int.TryParse(str3, out int chr3))
                {
                    Console.WriteLine($"O valor ({ chr3}) informando não é um inteiro válido.");
                    throw new Exception();

                }

                Console.WriteLine($"O valor informado foi: {chr3}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar o código ASCII do valor: {str3}");
            }
            

            //Exercicio 26
            Console.WriteLine("Exercicios 26:");

            Console.WriteLine("Informe o primeiro valor:");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Informe o segundo valor");
            var valor2 = Console.ReadLine();

            try
            {
                if (!int.TryParse(valor1, out int vlr1) ||
                    !int.TryParse(valor2, out int vlr2)  )
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                var soma = vlr1 + vlr2;

                Console.WriteLine($"A soma dos valores totalizou em: {soma}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
            

            //Exercicio 27
            Console.WriteLine("Exercicios 27:");

            Console.WriteLine("Informe o primeiro valor:");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Informe o segundo valor");
            var valor2 = Console.ReadLine();

            try
            {
                if (!int.TryParse(valor1, out int vlr1) ||
                    !int.TryParse(valor2, out int vlr2))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                var resto = vlr1 % vlr2;

                Console.WriteLine($"Resto da divisão entre os dois valores: {resto}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            

            //Exercicio 28
            Console.WriteLine("Exercicios 28:");

            Console.WriteLine("Informe o primeiro valor:");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Informe o segundo valor");
            var valor2 = Console.ReadLine();

            try
            {
                if (!decimal.TryParse(valor1, out decimal vlr1) ||
                    !decimal.TryParse(valor2, out decimal vlr2))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                var resto = vlr1 % vlr2;

                Console.WriteLine($"Resto da divisão entre os dois valores: {resto.ToString("n2")}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            

            //Exercicio 29
            Console.WriteLine("Exercicios 29:");

            Console.WriteLine("Informe o primeiro valor:");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Informe o segundo valor");
            var valor2 = Console.ReadLine();

            try
            {
                if (!decimal.TryParse(valor1, out decimal vlr1) ||
                    !decimal.TryParse(valor2, out decimal vlr2))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                var resto = vlr1 % vlr2;

                Console.WriteLine($"Resto da divisão entre os dois valores: {resto.ToString("c2")}.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
            

            //Exercicio 30
            Console.WriteLine("Exercicios 30:");

            Console.WriteLine("Informe o primeiro valor:");
            var valor1 = Console.ReadLine();

            Console.WriteLine("Informe o segundo valor");
            var valor2 = Console.ReadLine();

            try
            {
                if (!int.TryParse(valor1, out int vlr1) ||
                    !int.TryParse(valor2, out int vlr2))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }                 

                if(vlr1 != vlr2) 
                    Console.WriteLine($"Valores diferentes.");
                else  
                    Console.WriteLine($"Valores iguais.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            

            //Exercicio 31
            Console.WriteLine("Exercicios 31:");

            Console.WriteLine("Informe o valor:");
            var valor = Console.ReadLine();

            try
            {
                if (!int.TryParse(valor, out int vlr) )
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                var resto = vlr % 2;

                if (resto == 0) 
                    Console.WriteLine($"Valor par.");
                else  
                    Console.WriteLine($"Valor ímpar.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }


                                    //Exercicio 32
                                    Console.WriteLine("Exercicios 32:");

                                    Console.WriteLine("Informe o valor:");
                                    var valor = Console.ReadLine();

                                    try
                                    {
                                        if (!int.TryParse(valor, out int vlr))
                                        {
                                            Console.WriteLine($"Informe um número inteiro válido.");
                                            throw new Exception();

                                        }

                                        var resto = vlr % 2;

                                        if (resto == 0)
                                            Console.WriteLine($"Valor par.");
                                        else
                                            Console.WriteLine($"Valor ímpar.");

                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                    }

            


            //Exercicio 33
            Console.WriteLine("Exercicios 33:");

            Console.WriteLine("Informe o valor:");
            var valor = Console.ReadLine();

            try
            {
                if (!int.TryParse(valor, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                if (vlr > 0)
                    Console.WriteLine($"Valor positivo.");
                else
                    Console.WriteLine($"Valor negativo.");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            

            //Exercicio 34
            Console.WriteLine("Exercicios 34:");

            Console.WriteLine("Informe o valor:");
            var ano = Console.ReadLine();

            try
            {
                if (!int.TryParse(ano, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                if (DateTime.IsLeapYear(vlr)) 
                    Console.WriteLine("Bissexto");
                else
                    Console.WriteLine("Não é Bissexto");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
                       

            //Exercicio 35
            Console.WriteLine("Exercicios 35:");

            Console.WriteLine("Informe a idade do candidato:");
            var idade = Console.ReadLine();

            try
            {
                if (!int.TryParse(idade, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                if (vlr >= 16)
                    Console.WriteLine("Qualificado");
                else
                    Console.WriteLine("Não está qualificado");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
                       


            //Exercicio 36
            Console.WriteLine("Exercicios 36:");

            Console.WriteLine("Informe a altura (cm):");
            var altura = Console.ReadLine();

            try
            {
                if (!int.TryParse(altura, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                switch (vlr){

                    case <= 140:
                        Console.WriteLine($"Anão.");
                        break;
                    case <= 160:
                        Console.WriteLine($"Baixo.");
                        break;
                    case <= 180:
                        Console.WriteLine($"Alto");
                        break;
                    case > 180:
                        Console.WriteLine($"Gigante");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            
            //Exercicio 37
            Console.WriteLine("Exercicios 37:");

            Console.WriteLine("Informe um número:");
            
            try
            {
                var maiorNumero = 0;

                for (int i = 0; i < 3; i++)
                { 
                    var altura = Console.ReadLine();

                    if (!int.TryParse(altura, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    maiorNumero = ((maiorNumero >= vlr) ? maiorNumero : vlr);

                }

                Console.WriteLine($"O maior número informado foi o:" + maiorNumero);


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
            

            //Exercicio 38
            Console.WriteLine("Exercicios 38:");

            Console.WriteLine("Informe 10 valores:");

            try
            {
                var numeros = new int[10];

                for (int i = 0; i < 10; i++)
                { 
                    var valor = Console.ReadLine();
                    
                    if (!int.TryParse(valor, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    numeros[i] = vlr; 

                }

                foreach (int c in numeros)
                {
                    Console.WriteLine($"O valor do elemento é:" + c);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

        

            //Exercicio 39
            Console.WriteLine("Exercicios 39:");

            Console.WriteLine("Informe 10 valores:");

            try
            {
                var numeros = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    var valor = Console.ReadLine();

                    if (!int.TryParse(valor, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    numeros[i] = vlr;

                }

                for (int i = numeros.Length-1; i >= 0; i--)
                {
                    Console.WriteLine($"O valor do elemento é:" + numeros[i]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
            

            //Exercicio 40
            Console.WriteLine("Exercicios 40:");

            Console.WriteLine("Informe 10 valores:");

            try
            {
                var numeros = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    var valor = Console.ReadLine();

                    if (!int.TryParse(valor, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    numeros[i] = vlr;

                }

                var soma = 0;

                foreach(int c in numeros)
                {
                    soma += c;
                    
                }

                Console.WriteLine($"O total da soma foi de:" + soma);


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            
            //Exercicio 41
            Console.WriteLine("Exercicios 41:");

            Console.WriteLine("Informe 10 valores:");

            try
            {
                var numeros = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    var valor = Console.ReadLine();

                    if (!int.TryParse(valor, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    numeros[i] = vlr;

                }

                var numero2 = new int[10];                 

                Array.Copy(numeros, numero2,10);
                 
                foreach (int value in numero2)
                {
                    Console.WriteLine("Valores: " + value);
                }
                                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            
            //Exercicio 42
            Console.WriteLine("Exercicios 42:");

            Console.WriteLine("Informe 10 valores:");

            try
            {
                var numeros = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    var valor = Console.ReadLine();

                    if (!int.TryParse(valor, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    numeros[i] = vlr;

                }

                var dict = new Dictionary<int, int>();

                foreach (var value in numeros)
                {
                    if (dict.ContainsKey(value))
                        dict[value]++;
                    else
                        dict[value] = 1;
                }

                foreach (var pair in dict)
                    Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
                

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            


                                            //Exercicio 43
                                            Console.WriteLine("Exercicios 43:");

                                            Console.WriteLine("Informe 10 valores:");

                                            try
                                            {
                                                var numeros = new int[10];

                                                for (int i = 0; i < 10; i++)
                                                {
                                                    var valor = Console.ReadLine();

                                                    if (!int.TryParse(valor, out int vlr))
                                                    {
                                                        Console.WriteLine($"Informe um número inteiro válido.");
                                                        throw new Exception();

                                                    }

                                                    numeros[i] = vlr;

                                                }

                                                var dict = new Dictionary<int, int>();

                                                foreach (var value in numeros)
                                                {
                                                    if (dict.(value))
                                                        dict[value]++;
                                                    else
                                                        dict[value] = 1;
                                                }

                                                foreach (var pair in dict)
                                                    Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
                

                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                            }


            

            //Exercicio 44
            Console.WriteLine("Exercicios 44:");

            Console.WriteLine("Informe 10 valores:");

            try
            {
                var numeros = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    var valor = Console.ReadLine();

                    if (!int.TryParse(valor, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    numeros[i] = vlr;

                }

                var (number, index) = numeros.Select((n, i) => (n, i)).Max();
                Console.WriteLine($"Maximum number = {number}, on index {index}.");


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }


                                    //Exercicio 45
                                    Console.WriteLine("Exercicios 45:");

                                    Console.WriteLine("Informe 10 valores:");

                                    try
                                    {
                                        var numeros = new int[10];

                                        for (int i = 0; i < 10; i++)
                                        {
                                            var valor = Console.ReadLine();

                                            if (!int.TryParse(valor, out int vlr))
                                            {
                                                Console.WriteLine($"Informe um número inteiro válido.");
                                                throw new Exception();

                                            }

                                            numeros[i] = vlr;

                                        }

                                        var (number, index) = numeros.Select((n, i) => (n, i)).Max();
                                        Console.WriteLine($"Maximum number = {number}, on index {index}.");


                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                    }

            

            //Exercicio 46
            Console.WriteLine("Exercicios 46:");
            var data = DateTime.Now;
            
            try
            {
                Console.WriteLine($"Data atual é:" + data.ToString("dd/MM/yyyy"));


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }
            
            

            //Exercicio 47
            Console.WriteLine("Exercicios 47:");
            var data = DateTime.Now;
            var data2 = new DateTime(2021, 11, 17);
            int result = DateTime.Compare(data, data2);
            string relationship;

            if (result < 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is the same time as";
            else
                relationship = "is later than";

            Console.WriteLine("{0} {1} {2}", data, relationship, data2);
            

            //Exercicio 48
            Console.WriteLine("Exercicios 48:");
            try
            {
                Console.WriteLine($"Informe o ano.");
                var ano = Console.ReadLine();

                if (!int.TryParse(ano, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                Console.WriteLine($"Informe o mês.");
                var mes = Console.ReadLine();

                if (!int.TryParse(mes, out int vlr2))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                Console.WriteLine("O número de dias é: " + DateTime.DaysInMonth(vlr,vlr2));


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            

            //Exercicio 49
            Console.WriteLine("Exercicios 49:");
            Console.WriteLine("Next Day (Tomorrow) = {0}", DateTime.Today.AddDays(1));


            //Exercicio 50
            Console.WriteLine("Exercicios 50:");
            Console.WriteLine("Next Day (Tomorrow) = {0}", DateTime.Today.AddDays(40).ToString("U"));

            //Exercicio 51
            Console.WriteLine("Exercicios 51:");
            var data = new DateTime(2016,08,01);
            
            Console.WriteLine("Informe o número de meses.");

            try
            {
                var meses = Console.ReadLine();

                if (!int.TryParse(meses, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                Console.WriteLine("O número de dias é: " + data.AddMonths(vlr).ToString());


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            

            //Exercicio 52
            Console.WriteLine("Exercicios 52:");
            Console.WriteLine("Last years = {0}", DateTime.Today.AddYears(-15));
            Console.WriteLine("Next years = {0}", DateTime.Today.AddYears(15));

                                //Exercicio 53
                                Console.WriteLine("Exercicios 53:");
                                Console.WriteLine("Last years = {0}", DateTime.;
                                Console.WriteLine("Next years = {0}", DateTime.Today.AddYears(15));

            

            //Exercicio 54
            Console.WriteLine("Exercicios 54:");
            var data = DateTime.Now;
            Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss.sss"));

            

            //Exercicio 55
            Console.WriteLine("Exercicios 55:");
            var fileName = @"C:\Users\PremierSoft\Documents\teste_adriano.txt";
        
            try
            {
                if (File.Exists(fileName))
                {
                    throw new Exception("Arquivo já existe.");
                }

                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Adriano, teste");
                    fs.Write(author, 0, author.Length);
                }

                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            


            //Exercicio 56
            Console.WriteLine("Exercicios 56:");
            var fileName = @"C:\\ahsgdjhkasdf\teste_adriano.txt";

            try
            {
               File.Delete(fileName);
               
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo não encontrado.");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            

            //Exercicio 57
            Console.WriteLine("Exercicios 57:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;
            var random = new Random();

            try
            {
                if (File.Exists(fullPath))
                {
                    fileName = fileName.Replace(".txt", random.Next() + ".txt");
                    fullPath = path + fileName;
                }

                using (FileStream fs = File.Create(fullPath))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Adriano, teste");
                    fs.Write(author, 0, author.Length);
                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            

            //Exercicio 58
            Console.WriteLine("Exercicios 58:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;
            
            try
            {
                if (File.Exists(fullPath))
                   throw new Exception("Arquivo já existe.");
                
                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            

            //Exercicio 59
            Console.WriteLine("Exercicios 59:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (File.Exists(fullPath))
                    throw new Exception("Arquivo já existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }

                using (StreamReader sr = fi1.OpenText())
                {
                    var s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            
            //Exercicio 60
            Console.WriteLine("Exercicios 60:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (File.Exists(fullPath))
                    throw new Exception("Arquivo já existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    var n = "";
                    do
                    {
                        n = Console.ReadLine();
                        sw.WriteLine(n);
                    }
                    while (n != "exit");

                }
                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            

            //Exercicio 61
            Console.WriteLine("Exercicios 61:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (!File.Exists(fullPath))
                    throw new Exception("Arquivo não existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = File.AppendText(fullPath))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is Extra");
                    sw.WriteLine("Text");
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            //Exercicio 62
            Console.WriteLine("Exercicios 62:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (File.Exists(fullPath))
                    throw new Exception("Arquivo já existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    var n = "";
                    do
                    {
                        n = Console.ReadLine();
                        sw.WriteLine(n);
                    }
                    while (n != "exit");

                }

                try
                {                   
                    File.Copy(Path.Combine(path, fileName), Path.Combine(path, fileName.Replace(fileName,"backup_" + fileName)));
                }

                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            

            //Exercicio 63
            Console.WriteLine("Exercicios 63:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var path2 = @"C:\Users\PremierSoft\Documents\adriano";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (File.Exists(fullPath))
                    throw new Exception("Arquivo já existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    var n = "";
                    do
                    {
                        n = Console.ReadLine();
                        sw.WriteLine(n);
                    }
                    while (n != "exit");

                }

                try
                {
                    File.Move(fullPath, Path.Combine(path2, fileName));
                }

                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            

            //Exercicio 64
            Console.WriteLine("Exercicios 64:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var path2 = @"C:\Users\PremierSoft\Documents\adriano";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (File.Exists(fullPath))
                    throw new Exception("Arquivo já existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    var n = "";
                    do
                    {
                        n = Console.ReadLine();
                        sw.WriteLine(n);
                    }
                    while (n != "exit");

                }

                using (StreamReader sr = fi1.OpenText())
                {
                    var m = "";
                    while (sr.EndOfStream == false)
                    {
                        m = sr.ReadLine().Last();
                    }
                    Console.WriteLine("{0}\n", m); 

                }


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }


            //Exercicio 64 segunda opção
            var file = Path.Combine(Directory.GetCurrentDirectory(), "adriano.txt"); 
            var blanckFile = File.Create(file); 
            blanckFile.Close();

            System.IO.File.WriteAllText(file, " \n Testes" + " \n leitura" + " \n ultima " + " \n linha");

            string read = File.ReadLines(file).Last();
            Console.WriteLine(read);

            blanckFile.Close();

            
            

            
            
                                        //Exercicio 65
                                        Console.WriteLine("Exercicios 65:");
                                        var path = @"C:\Users\PremierSoft\Documents\";
                                        var fileName = "teste_adriano.txt";
                                        var fullPath = path + fileName;

                                        try
                                        {
                                            if (File.Exists(fullPath))
                                                throw new Exception("Arquivo já existe.");

                                            var fi1 = new FileInfo(fullPath);

                                            using (StreamWriter sw = fi1.CreateText())
                                            {
                                                var n = "";
                                                do
                                                {
                                                    n = Console.ReadLine();
                                                    sw.WriteLine(n);
                                                }
                                                while (n != "exit");

                                            }

                                            


                                        }
                                        catch (Exception Ex)
                                        {
                                            Console.WriteLine(Ex.ToString());
                                        }

            

            //Exercicio 66
            Console.WriteLine("Exercicios 66:");
            var path = @"C:\Users\PremierSoft\Documents\";
            var fileName = "teste_adriano.txt";
            var fullPath = path + fileName;

            try
            {
                if (File.Exists(fullPath))
                    throw new Exception("Arquivo já existe.");

                var fi1 = new FileInfo(fullPath);

                using (StreamWriter sw = fi1.CreateText())
                {
                    var n = "";
                    do
                    {
                        n = Console.ReadLine();
                        sw.WriteLine(n);
                    }
                    while (n != "exit");

                }

                int i = 0;
                
                using (StreamReader sr = fi1.OpenText())
                {                    
                    while (sr.ReadLine() != null)
                    {
                        i++;
                    }
                }

                Console.WriteLine("Quantidade de linhas: {0}",i);


            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            

            //Exercicio 67
            Console.WriteLine("Exercicios 67:");
            Console.WriteLine("Informe a largura do retângulo:");
            var largura = Console.ReadLine();
            Console.WriteLine("Informe altura do retângulo:");
            var altura = Console.ReadLine();

            try
            {
                if (!decimal.TryParse(largura, out decimal  lar) ||
                    !decimal.TryParse(altura,  out decimal  alt) )
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                var area = (decimal)lar * alt;
                var perimetro = lar + lar + alt + alt;

                Console.WriteLine("A área do retângulo é: {0}", area);
                Console.WriteLine("O perímetro do quadrado é: {0}", perimetro);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }

            

            //Exercicio 68
            Console.WriteLine("Exercicios 68:");
            Console.WriteLine("Informe a largura do quadrado:");
            var largura = Console.ReadLine();
             
            try
            {
                if (!double.TryParse(largura, out double lar) )
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                //var area = (decimal)lar * alt;
                double Sqr = Math.Pow(lar, 2);
                var perimetro = (double)lar + lar + lar + lar;

                Console.WriteLine("A área do retângulo é: {0}", Sqr);
                Console.WriteLine("O perímetro do quadrado é: {0}", perimetro);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }
            

            //Exercicio 70
            Console.WriteLine("Exercicios 69:");
            Console.WriteLine("Informe o perímetro:");
            var raio = Console.ReadLine();
            var pi = 3.14;
            
            try
            {
                if (!double.TryParse(raio, out double r))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                double area = pi * Math.Pow(r, 2);
                var perimetro = 2 * pi * r;

                Console.WriteLine("A área do retângulo é: {0}", area);
                Console.WriteLine("O perímetro do quadrado é: {0}", perimetro);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }

            
            //Exercicio 70
            Console.WriteLine("Exercicios 70:");
            Console.WriteLine("Informe a largura 1:");
            var largura1 = Console.ReadLine();
            Console.WriteLine("Informe a largura 2:");
            var largura2 = Console.ReadLine();
            Console.WriteLine("Informe a largura 3:");
            var largura3 = Console.ReadLine();
            
            try
            {
                if (!decimal.TryParse(largura1, out decimal r1) ||
                    !decimal.TryParse(largura2, out decimal r2) ||
                    !decimal.TryParse(largura3, out decimal r3))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                var perimetro = r1 + r2 + r3;

                Console.WriteLine("O perímetro do triângulo é: {0}", perimetro);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }

            //Exercicio 71
            Console.WriteLine("Exercicios 71:");
            Console.WriteLine("Informe um número:");
            var numero = Console.ReadLine();
           
            try
            {
                if (!int.TryParse(numero, out int n))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                Console.WriteLine("O sucessor de {0} é: {1}", numero, n + 1);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }
            

            //Exercicio 72
            Console.WriteLine("Exercicios 72:");
            Console.WriteLine("Informe um primeiro número:");
            var numero = Console.ReadLine();

            Console.WriteLine("Informe um segundo número:");
            var numero2 = Console.ReadLine();

            try
            {
                if (!int.TryParse(numero,  out int n1) ||
                    !int.TryParse(numero2, out int n2))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                int remainder;
                int quotient = Math.DivRem(n1, n2, out remainder);

                Console.WriteLine("O quociente é de : {0}", quotient );
                Console.WriteLine("O resto da divisão entre o valores é de: {0}", remainder);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }
            

            //Exercicio 73
            Console.WriteLine("Exercicios 73:");
            Console.WriteLine("Informe a idade:");
            var idade = Console.ReadLine();

            try
            {
                if (!int.TryParse(idade, out int i))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }
                
                Console.WriteLine("Idade {0}", DateTime.Today.AddYears(-i));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }
            
            
            //Exercicio 74
            Console.WriteLine("Exercicios 74:");
            Console.WriteLine("Informe a temperatura:");
            var temperatura = Console.ReadLine();

            try
            {
                if (!int.TryParse(temperatura, out int t))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                //var conversao = (t - 32) /1.8;
                var conversao = (t - 32m) * (5m / 9m);
                Console.WriteLine("A temperatura em celsius é: {0}", conversao);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }
                       
                                        //Exercicio 75
                                        Console.WriteLine("Exercicios 75:");
                                        Console.WriteLine("Informe a temperatura:");
                                        var temperatura = Console.ReadLine();

                                        try
                                        {
                                            if (!int.TryParse(temperatura, out int t))
                                            {
                                                Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                                                throw new Exception();

                                            }

                                            //var conversao = (t - 32) / 1.8;
                                            var conversao = (t - 32m) *(5m/9m);
                                            Console.WriteLine("A temperatura em celsius é: {0}", conversao);

                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
                                        }

           

                                        //Exercicio 76
                                        Console.WriteLine("Exercicios 76:");
                                        Console.WriteLine("Informe a temperatura:");
                                        var temperatura = Console.ReadLine();

                                        try
                                        {
                                            if (!int.TryParse(temperatura, out int t))
                                            {
                                                Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                                                throw new Exception();

                                            }

                                            var conversao = (t - 32) / 1.8;
                                            Console.WriteLine("A temperatura em celsius é: {0}", conversao);

                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
                                        }


            

            //Exercicio 77
            Console.WriteLine("Exercicios 77:");
            Console.WriteLine("Informe a velocidade:");
            var velocidade = Console.ReadLine();

            try
            {
                if (!int.TryParse(velocidade, out int v))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                var conversao = v * 3.6;
                Console.WriteLine("A velocidade em Km/h é: {0}", conversao);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }
            

            //Exercicio 78
            Console.WriteLine("Exercicios 78:");
            Console.WriteLine("Informe a R1:");
            var resistencia1 = Console.ReadLine();
            Console.WriteLine("Informe a R2:");
            var resistencia2 = Console.ReadLine();
            Console.WriteLine("Informe a R3:");
            var resistencia3 = Console.ReadLine();

            try
            {
                if (!int.TryParse(resistencia1, out int r1) ||
                    !int.TryParse(resistencia2, out int r2) ||
                    !int.TryParse(resistencia3, out int r3))
                {
                    Console.WriteLine($"Os valores informandos não são um inteiro válido.");
                    throw new Exception();

                }

                var resistenciaEquivalente = r1 + r2 + r3;
                Console.WriteLine("A resistencia equivalente é: {0}", resistenciaEquivalente);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar encontrar a área/perímetro do retângulo.");
            }

            //Exercicio 79
            Console.WriteLine("Exercicios 79:");
            try
            {
                Console.WriteLine("Informe o valor:");
                var texto = Console.ReadLine();

                if (texto.Length == 3)
                {
                    Console.WriteLine($"Texto Normal   : {texto}");
                    string textoInvertido = new string(texto.Reverse().ToArray());

                    Console.WriteLine($"Texto Invertido: {textoInvertido}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
            }

            

            //Exercicio 80
            Console.WriteLine("Exercicios 80:");
            int a = 5;
            int b = 3;

            Console.WriteLine("Valor da variável a: {0}", a);
            Console.WriteLine("Valor da variável b: {0}", b);

            try
            {
                a += b;     
                b = a - b;  
                a -= b;

                Console.WriteLine("Valor da variável a: {0}", a);
                Console.WriteLine("Valor da variável b: {0}", b);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar coletar informação do usuário.");
                                            
            }
            
            

                                            //Exercicio 81
                                            Console.WriteLine("Exercicios 81:");

                                            Console.WriteLine("Informe o valor da mercadoria:");
                                            var valor1 = Console.ReadLine();

                                            try
                                            {
                                                if (!int.TryParse(valor1, out int vlr1))
                                                {
                                                    Console.WriteLine($"Informe um número inteiro válido.");
                                                    throw new Exception();

                                                }

                                                var resto = vlr1 % 3;

                                                Console.WriteLine($"Resto da divisão entre os dois valores: {resto}.");

                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                            }

            */

                                            //Exercicio 82
                                            Console.WriteLine("Exercicios 82:");

                                            Console.WriteLine("Informe o valor da mercadoria:");
            
                                            try
                                            {
                                                var maior = 0;

                                                for (var i = 0; i < 3; i++)
                                                {
                                                    var valor1 = Console.ReadLine();
                                                    if (!int.TryParse(valor1, out int vlr1))
                                                    {
                                                        Console.WriteLine($"Informe um número inteiro válido.");
                                                        throw new Exception();

                                                    }

                                                    if(maior)

                                                }

                                                var resto = vlr1 % 3;

                                                Console.WriteLine($"Resto da divisão entre os dois valores: {resto}.");

                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                            }

        
            /*
            //Exercicio 83
            Console.WriteLine("Exercicios 83:");

            Console.WriteLine("Informe o valor da renda mensal:");
            var valorRenda = Console.ReadLine();
            Console.WriteLine("Informe o valor do empréstimo:");
            var valorEmprestimo = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de prestações:");
            var quantidadePrestacoes = Console.ReadLine();

            try
            {
                if (!int.TryParse(quantidadePrestacoes, out int qtdPrestacoes))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                if (!decimal.TryParse(valorRenda,      out decimal vlrRenda) || 
                    !decimal.TryParse(valorEmprestimo, out decimal vlrEmprestimo))
                {
                    Console.WriteLine($"Informe um valor válido.");
                    throw new Exception();

                }

                if(vlrEmprestimo > (vlrRenda * 10) || 
                  ((vlrEmprestimo / qtdPrestacoes)) > ((vlrRenda *30)/100) )
                {
                    Console.WriteLine($"Empréstimo não pode ser concedido.");
                    throw new Exception();

                }
                else
                {
                    Console.WriteLine($"Empréstimo pode ser concedido.");
                    
                }

            }                
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            


                                            //Exercicio 84
                                            Console.WriteLine("Exercicios 84:");

                                            Console.WriteLine("Informe o dia da semana:");
                                            var diaSemana = Console.ReadLine();
            
                                            try
                                            {
                                                if (!int.TryParse(diaSemana, out int semana))
                                                {
                                                    Console.WriteLine($"Informe um número inteiro válido.");
                                                    throw new Exception();
                    
                                                }

                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                            }

            

            //Exercicio 85
            Console.WriteLine("Exercicios 85:");

            Console.WriteLine("Informe o valor de entrada:");
            var valorEntrada = Console.ReadLine();

            try
            {
                if (!int.TryParse(valorEntrada, out int vlr))
                {
                    Console.WriteLine($"Informe um número inteiro válido.");
                    throw new Exception();

                }

                int n1 = 0, n2 = 1, n3;
                //Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
                for (var i = 2; i < vlr; ++i) //loop starts from 2 because 0 and 1 are already printed    
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }




            
                                            //Exercicio 86
                                            Console.WriteLine("Exercicios 86:");

                                            Console.WriteLine("Informe o dia da semana:");
                                            var diaSemana = Console.ReadLine();

                                            try
                                            {
                                                if (!int.TryParse(diaSemana, out int semana))
                                                {
                                                    Console.WriteLine($"Informe um número inteiro válido.");
                                                    throw new Exception();

                                                }

                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
                                            }


            
            
            //Exercicio 87
            Console.WriteLine("Exercicios 87:");

            Console.WriteLine("Informe alguns valores:");
            try
            {
                var array = new int[10];

                for (int i = 0; i < array.Length; i++)
                {
                    var numero = Console.ReadLine();

                    if (!int.TryParse(numero, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    array[i] = vlr;

                }

                Array.Sort(array);
                Console.WriteLine("After sorting the entire array by using the default comparer:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            
            //Exercicio 88
            Console.WriteLine("Exercicios 88:");

            Console.WriteLine("Informe alguns valores:");
            try
            {
                var array = new int[10];
                IComparer revComparer = new ReverseComparer();

                for (int i = 0; i < array.Length; i++)
                {
                    var numero = Console.ReadLine();

                    if (!int.TryParse(numero, out int vlr))
                    {
                        Console.WriteLine($"Informe um número inteiro válido.");
                        throw new Exception();

                    }

                    array[i] = vlr;

                }

                Array.Sort(array, revComparer);
                Console.WriteLine("Reverse compare:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao tentar efetuar o calculo.");
            }

            */



    }
    }
}
public class ReverseComparer : IComparer
{
    // Call CaseInsensitiveComparer.Compare with the parameters reversed.
    public int Compare(Object x, Object y)
    {
        return (new CaseInsensitiveComparer()).Compare(y, x);
    }
}