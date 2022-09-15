using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trivia.Global.Database
{
public class Database : MonoBehaviour
{
    public static Database dataInstance;
    private const string _prefsKey = "DataBase";
    [SerializeField] private int _packID;
    [SerializeField] private int _levelID;
    public int PackID => _packID;
    public int LevelID => _levelID;

 void Awake()
        {
            if (dataInstance == null)
            {
                dataInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            GetPackList();
        }
    public void GetPackList()
    { 
        //  GameObject packlistObj = GameObject.Find("PackList");
        //     packlist = packlistObj.GetComponent<PackList>();

        //     Debug.Log(packlist.themestruct.themes.Count);
    }
    private void GetLevelList(int packID)
    { 
         if (_packID==packID)
        {
            _levelID =packID;
        }
        else
        {

        }

    }
    private void GetLevelData (int levelID)
    {
        if (_levelID==LevelID)
        {
            _levelID=LevelID;
        }
        else
        {

        }
    }
}
}