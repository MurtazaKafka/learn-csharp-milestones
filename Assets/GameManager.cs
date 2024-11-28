using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text healthText;
    public Text itemsText;
    public Text winText;
    private int health = 100;
    private int items = 0;
    private bool gameWon = false;

    void Update()
    {
        if (gameWon)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0; // Pause the game
        }
    }

    public void CollectItem()
    {
        items++;
        itemsText.text = "Items: " + items;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthText.text = "Health: " + health;
        if (health <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        winText.text = "Game Over";
        winText.gameObject.SetActive(true);
        Time.timeScale = 0; // Pause the game
    }

    public void WinGame()
    {
        gameWon = true;
        winText.text = "You Win!";
        winText.gameObject.SetActive(true);
        Time.timeScale = 0; // Pause the game
    }
}
