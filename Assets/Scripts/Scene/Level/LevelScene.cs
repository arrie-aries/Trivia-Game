using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelScene : MonoBehaviour
{
[SerializeField] Button _backButton;

    private void Awake()
    {
        _backButton.onClick.RemoveAllListeners();
        _backButton.onClick.AddListener(OpenHomeScene);
    }

    private void OpenHomeScene()
    {
        SceneManager.LoadScene("PackScene");
    }
}
