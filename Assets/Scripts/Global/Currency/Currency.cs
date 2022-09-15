using UnityEngine;

public class Currency : MonoBehaviour
{
    public static Currency currencyInstance;
    private const string _prefsKey = "CurrencyData";

    [SerializeField] private int _coin;
    [SerializeField] private int _addingCoin = 20;

    public int Coin => _coin;

    private void Awake()
    {
        if (currencyInstance == null)
        {
            currencyInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Load();
    }

    public void AddCoin()
    {
        _coin += _addingCoin;
        Save();
    }

    public void SpendCoin(int price)
    {
        _coin -= price;
        Save();
    }

    private void Save()
    {
        string json = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(_prefsKey, json);
        Debug.Log(json);
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey(_prefsKey))
        {
            string json = PlayerPrefs.GetString(_prefsKey);
            JsonUtility.FromJsonOverwrite(json, this);
        }
        else
        {
            Save();
        }
    }
}

