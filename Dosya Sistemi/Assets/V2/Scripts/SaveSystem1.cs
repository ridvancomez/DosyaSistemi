using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class SaveSystem1
{
    internal static void SavePlayer(Player1 player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream("player.bin", FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    internal static PlayerData LoadPlayer()
    {

        string dosyaadi = "player.bin";

        if(File.Exists(dosyaadi))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("player.bin", FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Dosya Yok");
        }
        return null;
    }
}
