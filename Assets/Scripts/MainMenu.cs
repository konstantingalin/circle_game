using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int money;
    public int ernedMoney;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        ernedMoney = PlayerPrefs.GetInt("Score");
        money += ernedMoney; 
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();
        ernedMoney = 0;
        PlayerPrefs.SetInt("Score", ernedMoney);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToShop()
    {
        SceneManager.LoadScene(3);
    }
}
