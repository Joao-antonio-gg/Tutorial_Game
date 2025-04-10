using UnityEngine;
using UnityEngine.UI;
public class CoinManage : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCount = PlayerPrefs.GetInt("Pontos", 0); // pega os pontos salvos
    }


    // Update is called once per frame
    void Update()
    {
        coinText.text = coinCount.ToString();
    }
}
