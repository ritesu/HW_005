Console.WriteLine("Введите новый размер массива");
int a = int.Parse(Console.ReadLine()?? "0");
int[] numbers1 = new int [100];
int[] numbers2 = new int [a];

void FillMass()
{
    for (int i = 0; i < numbers1.Length; i++)
    {
        int num = new Random().Next(10);
        numbers1[i] = num;
    }
}

void ResizeMass()
{
    for (int i = 0; i < numbers2.Length; i++)
    {
        numbers2[i] = numbers1[i];
    }
}
FillMass();
ResizeMass();
