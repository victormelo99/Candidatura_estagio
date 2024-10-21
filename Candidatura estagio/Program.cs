/*1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
 * (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
 * ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.*/

int a = 0;
int b = 1;

Console.Write("escolha um número ");
int escolhanum = int.Parse(Console.ReadLine());

Console.Write("digite um número final: ");
int fim = int.Parse(Console.ReadLine());

while (a <= fim)
{
    Console.WriteLine($"{a}, ");
    if (a == escolhanum)
    {
        Console.WriteLine($"\n{escolhanum} pertence a sequência");
        break;
    }
    int roda = a;
    a = b;
    b = roda + b;

}

if (a > fim)
{
    Console.WriteLine($"\n{escolhanum} não pertence a sequência");
}

/*2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a 
 * quantidade de vezes em que ela ocorre.*/

Console.Write("digite algo ");
string texto = Console.ReadLine();

int a= 0;

foreach(char procurar in texto)
{
    if(procurar == 'a' || procurar == 'A')
    {
        a = a+1;
    }
}

Console.WriteLine($"quantidade de letras A = {a}");

/*3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA?*/

int indice = 12, soma = 0, k = 1;

while(k< indice)
{
    soma = soma + k;
    k = k + 1;
}
Console.WriteLine($"valor de Soma = {soma}");

/*4) Descubra a lógica e complete o próximo elemento:
a) 1, 3, 5, 7, 9
b) 2, 4, 8, 16, 32, 64, 128
c) 0, 1, 4, 9, 16, 25, 36, 49
d) 4, 16, 36, 64, 100
e) 1, 1, 2, 3, 5, 8, 13
f) 2,10, 12, 16, 17, 18, 19, 200*/

/*5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. 
    Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é 
    descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas 
    duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada? 

primeiro aciono um interruptor e espero alguns minutos e desligo a luz, após isso vou até as salas procurar qual esta mais iluminado devido 
    a lampada esta quente, após isso volto até o local que estão os interruptores e marco o que acionei primeiro, após isso, repito
    o mesmo processo com outro interruptor e procuro qual local esta sala esta novamente com mais iluminação, depois volto e marco o 
    interruptor que acionei e assim consigo saber qual interruptor aciona cada lampada de cada sala.*/
