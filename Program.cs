                                    //Tipos de operadores em C#: 

                                    //Etapa 1 Operadores de Atribuição. 

//# Introduçõa define Atribuição:

 int a = 10; //exemplo: operação chamada de atribuição, operador sinal de = 
 int b = 20;

int c = a + b; 



//# Combinação de operadores:

//c = c + 5; // no momento estamos adicionando ao resultado da varivel que vai ser lido no terminal o valor de C + o (5) = 35
c += 5; //outra forma de representar a operação acima. escrevendo menos codigo. 
//c -= 5; //caso queira uma subtração. 
//c *= 5; //caso queira uma multiplicação
//c /= 5; // caso queira uma divisão
Console.WriteLine(c);



//#Convertendo tipos de Variaveis + # Diferença entre Convert e Parse: 

//Cast - Casting
//Não é uma operação valida pois o mesmo valor está como string "" em texto. para isso temos que usar um CASTING
//usar a classe convert com o metodo ToInt32 tranforma a string em um int

int a = Convert.ToInt32(null); // não da erro caso o dados da conversão seja null
int a = int.Parse("5"); // não aceita o valor null encerra o programa
Console.WriteLine(a);



//# Conversão para String 

int inteiro = 5; 
string a = inteiro.ToString(); //quando for representar ou converter usar diretamente o ToString pois ele representa da melhor forma

Console.WriteLine(a);



//# Cast implicito 

// o int sempre cabe dentro do double, assim podendo suportar os valores do inteiro, evitando que seja feita de forma manual a conversão. 

//  int a = 5; 
// double b = a; 
// int a = 5; 
// long b = a; //mesma coisa pois o int cabe dentro do long.
// long a= 5; 
// int b = a; 

//um inteiro não tem todos os valores que o long tem pois o int não suporta e ele dá erro no codigo então não pode ser feita a conversão automatica
//correção: 

//   int a = int.MaxValue;
//   long b = a;
//   Console.WriteLine (b);



//# Ordem dos Operadores

//segue os mesmo principios da matematica

double a = 4 / (2 + 2); 
Console.WriteLine(a); 


//#Convertendo de maneira Segura: 

 string a = "15-";
 int b = 0;
 int.TryParse (a , out int b);

 Console.WriteLine(b); 
 Console.WriteLine("Conversão realizada com sucesso!"); 



                                        //# Etapa 2 Operadores Condicionais: 

//# Operador condicional na pratica:

int quantidadeEmEstoque = 3;
int quantidadeComprar = 0;
bool possivelVenda = quantidadeComprar > 0 && quantidadeEmEstoque >= quantidadeComprar;

 Console.WriteLine($"Quantidade em estoque:  {quantidadeEmEstoque} ");
 Console.WriteLine($"Quantidade em compra:  {quantidadeComprar} ");
 Console.WriteLine($"É possivel realizar a venda? {possivelVenda} ");
 
if (quantidadeComprar == 0 )
 {
     Console.WriteLine("Venda invalida");
 }
 else if (possivelVenda)
 { 
     Console.WriteLine("Venda realizada.");
 }
else
 {
    Console.WriteLine("Desculpa. Não temos a quantidade desejada em estoque.");
}


// # Apredendendo o Switch case 

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine(); 

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é uma vogal");
// }


//Uma outra solução usando o sinal de OU ||

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine(); 
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
// Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Nõa é uma vogal");
// }

//Uma outra solução usando o Switch

 Console.WriteLine("Digite uma letra");
 string letra = Console.ReadLine(); 
 switch (letra)
 {
     case "a":
     case "e":
     case "i":
     case "o":
     case "u":
     Console.WriteLine("Vogal");
     break;

     default: 
        Console.WriteLine("Não é uma vogal");
    break;
}



                                         //# Etapa 3 Operadores Logicos:
//# Introdução operadores logicos:
//# Operador OR na pratica: 

bool ehMaiorDeIdade = true;
bool possuiuAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiuAutorizacaoDoResponsavel)
{
     Console.WriteLine("Entrada liberada!");
}
else 
{
     Console.WriteLine("Entrada não liberada");
}//Se ao menos uma condição dentro do codigo for verdadeira então a entrada é liberada mas se alguma for falsa então ele não libera a entrada


//# Operador AND na pratica: 

bool  possuiuPresencaMinima = true;
 double media = 7.5;

 if(possuiuPresencaMinima && media >=7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}


//#Introdução ao NOT 

bool choveu = true;
bool estaTarde = false; 

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}
