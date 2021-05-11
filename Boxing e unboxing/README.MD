# Boxing e unboxing

Boxing é o processo de conversão de um objeto tipo valor para um objeto tipo referencia compatível.

int x = 20;

object obj = x;

obj receberá o valor de 20, porém será alocado em um novo espaço no heap, custando memoria e processamento a mais.



Unboxing é o processo de conversão de um objeto tipo referencia para um objeto tipo valor compativel

int x = 20;

object obj = x;

int y = (int) obj;

int y receberá o valor de obj visto que o valor que está dentro da variavel é compativel com o tipo (INT nesse caso)