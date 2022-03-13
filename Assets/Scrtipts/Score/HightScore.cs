using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HightScore : MonoBehaviour
{
    public int HightScoreMainMenu;
    public Text HightScoreText;

    void Start()
    {
        HightScoreMainMenu = PlayerPrefs.GetInt("SaveScore", 0);
    }

    void Update()
    {
        HightScoreText.text = ((int)HightScoreMainMenu).ToString();
    }
}
