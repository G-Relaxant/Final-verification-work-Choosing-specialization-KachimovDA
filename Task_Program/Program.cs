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
string answerString = string.Empty;
PrintAnswerArray(answerStringArray, answerString);
Console.WriteLine("Если вы хотите распечатать ответ в консоли - нажмите 1, если вы хотите сохранить ответ в файле - нажмите 2, если вы хотите распечатать ответ в консоль и сохранить в файле - нажмите 3");
int choice = Convert.ToInt32(Console.ReadLine());
if(choice == 1)
{
    
}
else
{
    if(choice == 2)
    {

    }
    else
    {
        if(choice == 3)
        {

        }
        else
        {
            Console.WriteLine($"Вы ввели недопустимое значение, перезапустите программу и повторите ввод");
        }
    }
}


void PrintAnswerArray(string[] a, string b)
{
    
}