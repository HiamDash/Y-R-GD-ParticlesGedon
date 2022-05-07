using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDistance : MonoBehaviour
{
[SerializeField] private Transform Player;
[SerializeField] private TMP_Text ScoreDistanceText;

private void Update()
{
    ScoreDistanceText.text= ((int)(Player.position.x / 2)).ToString();
}
}
