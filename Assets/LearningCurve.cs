using UnityEngine;

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
}
