using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeCoins : MonoBehaviour
{
    int maxCoins = 0;
    int coinCounter = 0;
    TextMeshProUGUI textCoin;
    public Transform MainCoin;
    public Transform Panel;
    public Transform CoinAudio;

    void Start()
    {
        maxCoins = MainCoin.childCount;
        textCoin = Panel.Find("TextCoin").GetComponent<TextMeshProUGUI>();
        textCoin.text = " Coins " + maxCoins + @" \ " + coinCounter;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinCounter += 1;
            textCoin.text = " Coins " + maxCoins + @" \ " + coinCounter;
            SoundOn();
            Destroy(collision.gameObject);
        }
    }

    public void SoundOn()
    {
        Transform obj = Instantiate(CoinAudio, transform.position, new Quaternion());
        obj.gameObject.SetActive(true);
        float time = obj.GetComponent<AudioSource>().clip.length;
        Destroy(obj.gameObject, time);
    }
}
