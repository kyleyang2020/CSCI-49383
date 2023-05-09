using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GoldTrackerController : MonoBehaviour
{
    public static TextMeshProUGUI goldText;
    public static int totalGold = 0;
    //public Button myButton; // Reference to the button in the scene

    private void Awake()
    {
        goldText = GetComponent<TextMeshProUGUI>();
        UpdateGold(0); // initialize the gold text to 0
    }

    public int GetGoldTotal()
    {
        return totalGold;
    }

    public void UpdateGold(int goldValue)
    {
        totalGold += goldValue;
        goldText.text = "Gold: " + totalGold.ToString();
    }
}
