using TMPro;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private TMP_Text healthTxt;
    public void UpdatePlayerStats(PlayerData data)
    {
        healthTxt.SetText(data.Health.ToString());
    }
}