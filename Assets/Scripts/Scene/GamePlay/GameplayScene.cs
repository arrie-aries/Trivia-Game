using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameplayScene : MonoBehaviour
{
  [SerializeField] Button _backButton;

    private void Awake()
    {
        _backButton.onClick.RemoveAllListeners();
        _backButton.onClick.AddListener(OpenLevelScene);
    }

    private void OpenLevelScene()
    {
        SceneManager.LoadScene("LevelScene");
    }
}
