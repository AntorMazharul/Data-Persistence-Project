using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] InputField nameInputField;
    public static StartMenu Instance;
    public string playerName;
    public Text bestScoreText;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        bestScoreText.text = $"Best Score : {PlayerPrefs.GetString("Player")} : {PlayerPrefs.GetInt("HighScore")}";
    }

    public void StartGame()
    {
        playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
