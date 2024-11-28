using UnityEngine;
using System.Collections.Generic;

public class LearningCurve : MonoBehaviour
{
    public int publicInt = 100; 
    private float privateFloat = 3.14f;

    public string publicString = "Hello";
    private string privateString = "World";

    void Start()
    {
        Debug.Log("Debug.Log example: " + publicString + " " + privateString);
        Debug.LogFormat("Debug.LogFormat example: Int: {0}, Float: {1}", publicInt, privateFloat);

        string concatenatedString = publicString + " " + privateString;
        Debug.Log("Concatenated String: " + concatenatedString);

        string interpolatedString = $"{publicString}, {privateString}!";
        Debug.Log($"Interpolated String: {interpolatedString}");

        int result = MultiplyNumbers(4, 5);
        Debug.Log($"Result of MultiplyNumbers: {result}");

        float divisionResult = DivideNumbers(20, 4);
        Debug.Log($"Result of DivideNumbers: {divisionResult}");
    }


    private int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    private float DivideNumbers(float numerator, float denominator)
    {
        return numerator / denominator;
    }




    private void ConditionalsExample()
    {
        int number = 15;

        if (number > 10)
        {
            Debug.Log("The number is greater than 10.");
        }
        else if (number == 10)
        {
            Debug.Log("The number is equal to 10.");
        }
        else
        {
            Debug.Log("The number is less than 10.");
        }

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Debug.Log("The number is positive and even.");
            }
            else
            {
                Debug.Log("The number is positive and odd.");
            }
        }

        switch (number)
        {
            case 10:
                Debug.Log("The number is exactly 10.");
                break;
            case 15:
                Debug.Log("The number is 15.");
                break;
            default:
                Debug.Log("The number is something else.");
                break;
        }
    }

    private void CollectionsExample()
    {
        int[] numbers = { 10, 20, 30 };
        Debug.Log($"The second number in the array is: {numbers[1]}");

        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        names.Add("Diana");
        Debug.Log($"The first name in the list is: {names[0]}");

        Dictionary<string, int> scores = new Dictionary<string, int>
        {
            { "Player1", 50 },
            { "Player2", 75 },
            { "Player3", 100 }
        };

        Debug.Log($"Player1's score is: {scores["Player1"]}");
    }

    private void LoopsExample()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        for (int i = 0; i < fruits.Count; i++)
        {
            Debug.Log($"Fruit at index {i}: {fruits[i]}");
        }

        foreach (string fruit in fruits)
        {
            Debug.Log($"Foreach Fruit: {fruit}");
        }

        Dictionary<string, int> items = new Dictionary<string, int>
        {
            { "Sword", 1 },
            { "Shield", 2 }
        };

        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log($"Item: {item.Key}, Quantity: {item.Value}");
        }
    }
}
