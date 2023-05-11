int CountArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string arrayElement = new string(array[i]);

        if(arrayElement.Length <= 3)
            count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, int count)
{    
    string[] newArray = new string[count];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string arrayElement = new string(array[i]);    
        
        if (arrayElement.Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); 
}

string[] myArray = {"Hello", "2", "world", ":-)"};

int numberElementsArray = CountArray(myArray);

string[] result = CreateNewArray(myArray, numberElementsArray);
ShowArray(result);
