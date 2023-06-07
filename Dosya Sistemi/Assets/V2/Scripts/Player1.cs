using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player1 : MonoBehaviour
{

    [SerializeField]
    private InputField gelenPuanDegeri;

    [SerializeField]
    private InputField gelenAdDegeri;

    [SerializeField]
    private TextMeshProUGUI puanText;

    [SerializeField]
    private TextMeshProUGUI adText;



    void Start()
    {
        Datas1.Puan = 20;
        Datas1.Ad = "Rýdvan";
    }

    public void Save()
    {
        Datas1.Puan = System.Convert.ToInt32(gelenPuanDegeri.text);

        SaveSystem1.SavePlayer();
    }

    public void Load()
    {
        SaveSystem1.LoadPlayer();
        puanText.text = Datas1.Puan.ToString();
    }
}
