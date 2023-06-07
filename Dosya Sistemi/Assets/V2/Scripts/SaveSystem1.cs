using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class SaveSystem1
{
    internal static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream("player.bin", FileMode.Create);

        formatter.Serialize(stream, Datas.Puan);

        stream.Close();
    }

    internal static void LoadPlayer()
    {

        string dosyaadi = "player.bin";

        if(File.Exists(dosyaadi))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("player.bin", FileMode.Open);

            Datas1.Puan = Convert.ToInt32(formatter.Deserialize(stream));
            stream.Close();
        }
        else
        {
            Debug.LogError("Dosya Yok");
        }





    }
}
