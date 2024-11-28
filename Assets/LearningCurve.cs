using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Single-line comment: This is an integer variable
    public int myInt = 42;

    /* Multi-line comment:
       This is a float variable
       used to represent decimal numbers */
    public float myFloat = 3.14f;

    /// <summary>
    /// This is a string variable to store text
    /// </summary>
    public string myString = "Hello, Unity!";

    public bool myBool = true;

    void Start()
    {
        Debug.Log("The script is running!");
    }
}
