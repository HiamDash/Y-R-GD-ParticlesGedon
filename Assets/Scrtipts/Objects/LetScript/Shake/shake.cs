using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class shake : MonoBehaviour
{
    public CinemachineVirtualCamera vCamera;
    public float Amplitude=2;
    public float Frequence=2;
 
    void Update()
    {
        StartCoroutine(Shake());
    }

     IEnumerator Shake()
    {
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = Amplitude;
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = Frequence;

        yield return new WaitForSeconds(1);

        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="letShake")
        {
            Amplitude = 50;
            Frequence = 50;
            
            Invoke("Stop", 3f);
        }
    }

    void Stop()
    {
        Amplitude = 0;
        Frequence = 0;
    }


}