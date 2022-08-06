string[] stringArray = {"flower", "bus", "coffee", "777", "laptop", "AIO", "b2b", "12", "Samara", "NB", "NorthBridge", "Qiwi", "X", "AMD", "Intel", "SuperFlower"};
string bufer = string.Empty;
int indexesCounter = 0;
for(int i = 0; i < stringArray.Length; i++)
{
    bufer = stringArray[i];
    if(bufer.Length <= 3)
    {
        indexesCounter++;
    }
    bufer = string.Empty;
}
string[] answerStringArray = new string[indexesCounter];
int indexAnswerArray = 0;
for(int i = 0; i < stringArray.Length; i++)
{
    bufer = stringArray[i];
    if(bufer.Length <= 3)
    {
        answerStringArray[indexAnswerArray] = bufer;
        indexAnswerArray++;
    }
}
string answerString = string.Empty;  // Аналогично string "output" из практикума
PrintAnswerArray(answerStringArray, answerString);
string input = string.Empty;
PrintAnswerArray(stringArray, input);
Console.WriteLine("Если вы хотите распечатать ответ в консоли - нажмите 1");
Console.WriteLine("Если вы хотите сохранить ответ в файле - нажмите 2");
Console.WriteLine("Если вы хотите распечатать ответ в консоли и сохранить в файле - нажмите 3");
int choice = Convert.ToInt32(Console.ReadLine());
if(choice == 1)
{
    Console.WriteLine(answerString);
}
else
{
    if(choice == 2)
    {
        File.WriteAllText("input.txt", input);
        File.WriteAllText("output.txt", answerString);
    }
    else
    {
        if(choice == 3)
        {
            Console.WriteLine(answerString);
            File.WriteAllText("input.txt", input);
            File.WriteAllText("output.txt", answerString);
        }
        else
        {
            Console.WriteLine($"Вы ввели недопустимое значение, перезапустите программу и повторите ввод");
        }
    }
}


void PrintAnswerArray(string[] a, string b)
{
    for(int i = 0; i < a.Length; i++)
    {
        b = b + a[i];
        if(i != a.Length)
        {
            b = b + ", ";
        }
    }
}