// Sugerencia general de Clean Code: usar if de una sola línea con llaves cuando sea legible.

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance; // Usar PascalCase

    [SerializeField] private GameObject _gameOverCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (instance == null) // Revisar: qué debe ocurrir cuando hay más de un GameManager
        {
            instance = this;

        }
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    public void GameOver() // Usar un verbo en el nombre del método
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
    }
}
