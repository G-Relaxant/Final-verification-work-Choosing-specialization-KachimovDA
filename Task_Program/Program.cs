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
int[] indexesArray = new int[indexesCounter];
