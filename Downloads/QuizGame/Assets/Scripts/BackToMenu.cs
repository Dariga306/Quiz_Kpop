using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Название сцены главного меню
    }
}
