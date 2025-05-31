using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCoinCounter;
    [SerializeField] private GameObject panelLost;
    [SerializeField] private Button buttonRestartLevel;

    private void Start()
    {
        panelLost.SetActive(false);
        buttonRestartLevel.onClick.AddListener(RestartLevel);
    }

    public void UpdateCoinText(int newCoinCount)
    {
        textCoinCounter.text = newCoinCount.ToString();
    }

    public void ShowPanelLost()
    {
        panelLost.SetActive(true);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
