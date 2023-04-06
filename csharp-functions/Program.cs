// See https://aka.ms/new-console-template for more information
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

int[] numeri = { 1, 2, 3, 4, 5 };
StampaArray(numeri);

static void StampaArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + ", ");
    }
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int numero = 5;
int potenza = Quadrato(numero);
Console.WriteLine($"La potenza di {numero} è {potenza}");


static int Quadrato(int numero)
{
    return numero * numero;
}
