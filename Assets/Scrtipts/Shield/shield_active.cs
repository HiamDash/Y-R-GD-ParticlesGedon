// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class shield_active : MonoBehaviour
// {
//     public float cooldown;

//     [HideInInspector] public bool isCooldown;

//     private Image shieldImage;
//     private Player player;

//     void Start()
//     {
//         shieldImage = GetComponent<Image>();
//         player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
//         isCooldown = true;
//     }

//     void Update()
//     {
//         if (isCooldown)
//         {
//             shieldImage.fillAmount -= 1 / cooldown * Time.deltaTime;
//             if (shieldImage.fillAmount <= 9)
//             {
//                 shieldImage.fillAmount = 1;
//                 isCooldown = false;
//                 player.shield.SetActive(false);
//                 gameObject.SetActive(false);
//             }
//         }
//     }
//     public void ResetTimer()
//     {
//         shieldImage.fillAmount = 1;
//     }

// }