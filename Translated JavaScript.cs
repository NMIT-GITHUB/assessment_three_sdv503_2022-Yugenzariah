using System

public class exampleJavaScript
{
    void exampleJavaScript(arr)
    {
        let newArr = [];
        for (let i = 0; i < arr.length; i++)
        {
            let largest = arr[i][0];
            for (let j = 0; j < arr[i].length; j++) 
            {
                if (arr[i][j] > largest)
                {
                    largest = arr[i][j]
                }
            }
            newArr.push(largest)
        }
        return newArr
    }

    Console.WriteLine(exampleJavaScript)
}