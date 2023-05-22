using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{
    public PlayerData data;
    public static SaveManager instance;
    static string filePath;

    private void Awake()
    {
        filePath = Application.persistentDataPath + "/Orbia.json";
        instance = this;
        LoadData();
    }

    public void SaveData()
    {
        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, jsonData);
    }

    public void LoadData()
    {
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<PlayerData>(jsonData);

        }
        else
        {
            Debug.Log("No file Found");
        }
    }

    public void PlayerPos()
    {
        data.targetSave = GameController.inst.target;
        data.Player = GameController.inst.player;

    }
    public void LoadPlayerDataToLevel1()
    {
        GameController.inst.player.transform.position = GameController.inst.LevelsStartPos[0].transform.position;
        GameController.inst.target = data.targetSave;
    }
    public void LoadPlayerDataToLevel2()
    {
        GameController.inst.player.transform.position = GameController.inst.LevelsStartPos[1].transform.position;
        GameController.inst.target = data.targetSave;
    }
    public void LoadPlayerDataToLevel3()
    {
        GameController.inst.player.transform.position = GameController.inst.LevelsStartPos[2].transform.position;
        GameController.inst.target = data.targetSave;
    }
    public void LoadPlayerDataToLevel4()
    {    
        GameController.inst.player.transform.position = GameController.inst.LevelsStartPos[3].transform.position;
        GameController.inst.target = data.targetSave;
    }

    public void PlayerToLevel(int i)
    {
        GameController.inst.player.transform.position = GameController.inst.LevelsStartPos[i].transform.position;
        GameController.inst.target = GameController.inst.AllLevelsPos[i];
    }

    public void CurrentLevelCount()
    {
        data.LevelCount = ScoreManager.instance.CurrentLevelCount.text;
    }
    public void LoadLastLevelData()
    {   
        ScoreManager.instance.LevelCountinMainMenu.text = data.LevelCount;
        ScoreManager.instance.LoadCurrentLevel.text = data.LevelCount;
    }

    public void CrystalsaveData()
    {
        data.CrystalScore = ScoreManager.instance.TotalCrystalCount.text;
        //ScoreManager.instance.LevelCountinMainMenu.text = data.CrystalScore;
    }

    public void CrystalLoadData()
    {
        ScoreManager.instance.TotalCrystalCount.text = data.CrystalScore;
        ScoreManager.instance.CrystalMainMenu.text = data.CrystalScore;
    }
}

[System.Serializable]
public class PlayerData
{
    public GameObject Player;
    public Transform targetSave;
    public string CrystalScore;
    public string LevelCount;
}

