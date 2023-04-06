// See https://aka.ms/new-console-template for more information
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

int[] numeri = { 1, 2, 3, 4, 5 };
StampaArray(numeri);

 void StampaArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + ", ");

            }
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int numero = 5;

int quadro = Quadrato(numero);

Console.WriteLine($"La potenza di {numero} è {quadro}");

 int Quadrato(int numero)
{
    return numero * numero;
}

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!

int[] arrayInteri = { 1, 2, 3, 4, 5 };

ElevaArrayAlQuadrato(arrayInteri);
int[] ElevaArrayAlQuadrato(int[] arr)
{
    int[] copiaArray = (int[])arrayInteri.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = arr[i] * arr[i];

        Console.WriteLine(arr[i]);
        Console.WriteLine(copiaArray[i]);
      

    }
    return copiaArray;

    
}


