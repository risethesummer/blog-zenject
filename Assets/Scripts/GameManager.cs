using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text healthTxt;
    private int _currentHealth;
    public void Heal(int health = 1)
    {
        _currentHealth += health;
        healthTxt.SetText(_currentHealth.ToString());
    }
    private void Start()
    {
        healthTxt.SetText(_currentHealth.ToString());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Heal();
    }
}