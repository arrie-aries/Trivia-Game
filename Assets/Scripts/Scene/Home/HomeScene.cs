using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScene : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    void Start()
    {
        _startButton.onClick.RemoveAllListeners();
        _startButton.onClick.AddListener(OpenSelectPack);
    }

    private void OpenSelectPack()
    {
        SceneManager.LoadScene("PackScene");
    }

    
}
