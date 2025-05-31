using TMPro.EditorUtilities;
using UnityEngine;

public class TheCoinWatcher : MonoBehaviour
{
   [SerializeField] private int coinCounter = 0;
   [SerializeField] private UiController uiController;

   private void Start()
   {
      coinCounter = 0;
      TMP_UIStyleManager.UpdateCoinText(coinCounter);
   }

   public void AddCoin()
   {
      coinCounter++;
      TMP_UIStyleManager.UpdateCoinText(coinCounter);
   }
}
