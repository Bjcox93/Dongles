using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveLoadManager{

	public static string filename = Application.persistentDataPath + "/test.sav";

	public static void SaveFile()
	{
		using (FileStream stream = new FileStream(filename, FileMode.Create))
		{
            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                Debug.Log(Application.persistentDataPath);
                Debug.Log(GameManager.instance.currentLevel);
                GameData data = new GameData(GameManager.instance.currentLevel);

                bf.Serialize(stream, data);
            }
            catch (Exception)
            {
                Debug.Log("Caught");
            }
        }
	}

	public static string LoadFile()
	{
		if (File.Exists(filename))
		{
			GameData data;
			using (FileStream stream = new FileStream(filename, FileMode.Open))
			{
				BinaryFormatter bf = new BinaryFormatter();

				data = bf.Deserialize(stream) as GameData;
			}
			return data.currentLevel;
		}
		else
		{
			Debug.LogError("Couldn't find file");
			return "";
		}
	}
}

[Serializable]
public class GameData
{
	public string currentLevel;

	public GameData(string levelName)
	{
		currentLevel = levelName;
	}
}
