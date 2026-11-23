using UnityEngine;
using UnityEngine.UIElements;

public class MenuPause : MonoBehaviour
{
    public GameObject menuPause;
    public bool pausedGame;
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    public void Resume()
    { 
       menuPause.SetActive(false);
        Time.timeScale = 1;
        pausedGame= false;
    }
    public void Pause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0;
        pausedGame = true;
    }
}
