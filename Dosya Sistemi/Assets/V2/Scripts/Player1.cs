using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class Player1 : MonoBehaviour
{

    public int Puan;

    public string Ad;


    [SerializeField]
    private TextMeshProUGUI puanText;

    [SerializeField]
    private TextMeshProUGUI adText;



    void Start()
    {
        //Datas1.Puan = 20;
        //Datas1.Ad = "Rýdvan";
    }

    public void Save()
    {
        //Datas1.Puan = System.Convert.ToInt32(gelenPuanDegeri.text);

        SaveSystem1.SavePlayer(this);
        Load();
    }

    public void Load()
    {
        if (!File.Exists("player.bin"))
            return;
        PlayerData data = SaveSystem1.LoadPlayer();

        puanText.text = data.Puan.ToString();

        adText.text = data.Name;

        Puan = data.Puan;
        Ad = data.Name;
    }
}
