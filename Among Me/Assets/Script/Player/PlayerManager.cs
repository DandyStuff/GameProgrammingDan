using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    private void Awake()
    {
        isGameOver = false;
        AudioManager.instance.Play("StartSFX");
    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            
        }
    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
