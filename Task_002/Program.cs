Console.WriteLine("Введите коэффициент масштабирования");
int k = int.Parse(Console.ReadLine()?? "0");
int[,] form = new int[3, 3];
int c = 0;
int d = 0;

void PrintArray(int[,] form)
{
    for (int i = 0; i < form.GetLength(0); i++)
    {
        for (int j = 0; j < form.GetLength(1); j++)
        {
            Console.Write(form[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintForm()
{
    int a = form.GetLength(0) -1;
    for (int i = 0; i < form.GetLength(0); i++)
    {
        for (int j = 0; j < form.GetLength(1); j++)
        {
            if (i == 0 && j == 0)
            {
                Console.Write("("+ i + ", " + j + ") ");
            }
            else if (i == 0 && j == a)
            {
                Console.Write("("+ i + ", " + j + ") ");
            }
            else if (i == a && j == 0)
            {
                Console.Write("("+ i + ", " + j + ") ");
            }
            else if (i == a && j == a)
            {
                Console.Write("("+ i + ", " + j + ")");
            }
        }
    }
    Console.WriteLine();
}


void PrintNew_Form()
{
    int a = form.GetLength(0) -1;
    c = 0;
    d = 0;
    for (int i = 0; i < form.GetLength(0); i++)
    {
        for (int j = 0; j < form.GetLength(1); j++)
        {
            if (i == 0 && j == 0)
            {
                c = i * k;
                d = j * k;
                Console.Write("("+ c + ", " + d + ") ");
            }
            else if (i == 0 && j == a)
            {
                c = i * k;
                d = j * k;
                Console.Write("("+ c + ", " + d + ") ");
            }
            else if (i == a && j == 0)
            {
                c = i * k;
                d = j * k;
                Console.Write("("+ c + ", " + d + ") ");
            }
            else if (i == a && j == a)
            {
                c = i * k;
                d = j * k;
                Console.Write("("+ c + ", " + d + ") ");
            }
        }
    }
    Console.WriteLine();
}

void PrintNew_Array(int[,] new_form)
{
    for (int i = 0; i < new_form.GetLength(0); i++)
    {
        for (int j = 0; j < new_form.GetLength(1); j++)
        {
            Console.Write(new_form[i,j] + " ");
        }
        Console.WriteLine();
    }
}
PrintForm();
PrintArray(form);
PrintNew_Form();
c++;
d++;
int[,] new_form = new int[c, d];
PrintNew_Array(new_form);