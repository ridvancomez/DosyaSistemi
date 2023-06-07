using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
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
        Datas.Puan = 20;
        Datas.Ad = "Rýdvan";
    }

    public void Save()
    {
        Datas.Puan = System.Convert.ToInt32(gelenPuanDegeri.text);

        SaveSystem.SavePlayer();
    }

    public void Load()
    {
        SaveSystem.LoadPlayer();
        puanText.text = Datas.Puan.ToString();
    }
}
