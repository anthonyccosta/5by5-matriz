//// int[] nome = new int[10];
//int[,] matriz = new int[3,3];

//for  (int linha = 0; linha < 3; linha++) // 
//{
//    for (int coluna = 0; coluna < 3; coluna++) //
//    {
//        matriz[linha,coluna] = int.Parse(Console.ReadLine()); //
//    }
//}

//for (int linha = 0; linha < 3; linha++) // 
//{
//    Console.WriteLine();
//    for (int coluna = 0; coluna < 3; coluna++) //
//    {
//        Console.Write(matriz[linha,coluna] + " "); //
//    }
//}


// Fazendo calculo com 3 matrizes
//int qtdlinhas = 3, qtdcolunas = 3;
//int[,] matriz1 = new int[qtdlinhas, qtdcolunas];
//int[,] matriz2 = new int[qtdlinhas, qtdcolunas];
//int[,] matriz3 = new int[qtdlinhas, qtdcolunas];

//// criação da matriz1
//for (int linha = 0; linha < qtdlinhas; linha++) // 
//{
//    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
//    {
//        matriz1[linha, coluna] = new Random().Next(0, 10); //
//    }
//}
////exibe a matriz1
//for (int linha = 0; linha < qtdlinhas; linha++) // 
//{
//    Console.WriteLine();
//    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
//    {
//        Console.Write(matriz1[linha, coluna] + " "); //
//    }
//}
//Console.ReadLine();
//// criação da matriz2
//for (int linha = 0; linha < qtdlinhas; linha++) // 
//{
//    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
//    {
//        matriz2[linha, coluna] = new Random().Next(0, 10); //
//    }
//}
////exibe a matriz2
//for (int linha = 0; linha < qtdlinhas; linha++) // 
//{
//    Console.WriteLine();
//    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
//    {
//        Console.Write(matriz2[linha, coluna] + " "); //
//    }
//}
//Console.ReadLine();

////criação da matriz3 fazendo calculo da 1 + 2
//for (int linha = 0; linha < qtdlinhas; linha++)
//{
//    for (int coluna = 0; coluna < qtdcolunas; coluna++)
//    {
//        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
//    }
//}

////exibe a matriz3
//for (int linha = 0; linha < qtdlinhas; linha++) // 
//{
//    Console.WriteLine();
//    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
//    {
//        Console.Write(matriz3[linha, coluna] + " "); //
//    }
//}
//Console.ReadLine();

// faça um programa que calcule o valor das 4 operações com matrizes e exiba seus valores


int qtdlinhas = 3, qtdcolunas = 3;
float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

// criação da matriz1
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        matriz1[linha, coluna] = new Random().Next(0, 10); //
    }
}
//exibe a matriz1
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        Console.Write(matriz1[linha, coluna] + " "); //
    }
}
Console.ReadLine();
// criação da matriz2
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        matriz2[linha, coluna] = new Random().Next(0, 10); //
    }
}
//exibe a matriz2
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        Console.Write(matriz2[linha, coluna] + " "); //
    }
}
Console.ReadLine();

//fazendo a soma
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}
/// exibe a SOMA
Console.Write("\n SOMA ");
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        Console.Write(matriz3[linha, coluna] + " "); //
    }
}
Console.ReadLine();
/////////////////////////////////////////////////////////////////////////////////////////////////
/// fazendo a subtração 
Console.Write("\n SUBTRAÇÃO ");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}
//exibe a subtração
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        Console.Write(matriz3[linha, coluna] + " "); //
    }
}
Console.ReadLine();
/////////////////////////////////////////////////////////////////////////////////////////////////
////// fazendo a multiplicação
Console.Write("\n MULTIPLICAÇÃO ");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}
//exibe a multiplicacao
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        Console.Write(matriz3[linha, coluna] + " "); //
    }
}
Console.ReadLine();
/////////////////////////////////////////////////////////////////////////////////////////////////
////// fazendo a divisao 
Console.Write("\n DIVISÃO ");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        if (matriz2[linha, coluna] != 0)
            // {
            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        //}
        else
            //{
            matriz3[linha, coluna] = float.NaN;
        //Console.WriteLine("ERRO: Divisão por 0 na posição (" + linha + ", " + coluna + ")");
        //}
    }
}
// exibe a divisao
for (int linha = 0; linha < qtdlinhas; linha++) // 
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++) //
    {
        Console.Write(matriz3[linha, coluna] + " "); //
    }
}
Console.ReadLine();
/////////////////////////////////////////////////////////////////////////////////////////////////////
/////

// faça um programa que faça a soma dos valores da matriz, linha coluna e diagonais

//int qtdlinhas = 2, qtdcolunas = 2;  // Tamanho da matriz (linhas e colunas)
//float[,] matriz = new float[qtdlinhas, qtdcolunas]; // Criando a matriz

//// Preenchendo a matriz com valores aleatórios (0 a 99)
//Random valores = new Random();
//for (int i = 0; i < qtdlinhas; i++)
//{
//    for (int linha = 0; linha < qtdlinhas; linha++)
//    {
//        matriz[i, linha] = valores.Next(100);
//    }
//}

//// Exibindo a matriz
//Console.WriteLine("Matriz:");
//for (int i = 0; i < qtdlinhas; i++)
//{
//    for (int j = 0; j < qtdcolunas; j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//// Soma das linhas
//float somaLinha;
//for (int i = 0; i < qtdlinhas; i++)
//{
//    somaLinha = 0;
//    for (int j = 0; j < qtdlinhas; j++)
//    {
//        somaLinha += matriz[i, j];
//    }
//    Console.WriteLine("Soma linha " + (i + 1) + ": " + somaLinha);
//}

//// Soma das colunas
//float somaColuna;
//for (int j = 0; j < qtdcolunas; j++)
//{
//    somaColuna = 0;
//    for (int coluna = 0; coluna < qtdlinhas; coluna++)
//    {
//        somaColuna += matriz[coluna, j];
//    }
//    Console.WriteLine("Soma coluna " + (j + 1) + ": " + somaColuna);
//}

//// Soma da diagonal principal
//float diagonal1 = 0;
//for (int linha = 0; linha < qtdlinhas; linha++)
//{
//    diagonal1 += matriz[linha, linha];
//}
//Console.WriteLine("Soma diagonal principal: " + diagonal1);

//// Soma da diagonal secundária
//float diagonal2 = 0;
//for (int coluna = 0; coluna < qtdcolunas; coluna++)
//{
//    diagonal2 += matriz[qtdlinhas-1-coluna, coluna]; //
//    // qtdlinhas--;
//}
//Console.WriteLine("Soma diagonal secundária: " + diagonal2);