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
Console.WriteLine("Если вы хотите распечатать ответ в консоли - нажмите 1, если вы хотите сохранить ответ в файле - нажмите 2, если вы хотите распечатать ответ в консоль и сохранить в файле - нажмите 3");
int choice = Convert.ToInt32(Console.ReadLine());
if(choice == 1)
{
    PrintAnswerArray(answerStringArray);
}


void PrintAnswerArray(string a)
{
    
}