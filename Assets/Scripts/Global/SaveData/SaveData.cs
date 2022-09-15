using UnityEngine;

namespace Trivia.Global.SaveData
{
    public class SaveData : MonoBehaviour
    {
        public static SaveData saveInstance;
        private const string _prefsKey = "SaveData";

        [SerializeField] private int _currentPack;
        [SerializeField] private bool[] _unlockedPack;
        [SerializeField] private int _currentLevel;
        [SerializeField] private bool[] _completedLevel;
        public int currentPack => _currentPack;
        public bool[] unlockedPack => _unlockedPack;
        public int currentLevel => _currentLevel;
        public bool[] completedLevel => _completedLevel;
        void Awake()
        {
            if (saveInstance == null)
            {
                saveInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            Load();
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
        public void ChangeCurrentPack(int pack)
        {
            if (_unlockedPack[pack])
            {
                _currentPack = pack;
            }
            else
            {
                int cost = 100;
                if (Currency.currencyInstance.Coin >= cost)
                {
                    _unlockedPack[pack] = true;
                    Currency.currencyInstance.SpendCoin(cost);
                }
            }
            Save();
        }
        public void ChangeCurrentLevel(int level)
        {
            _currentLevel=level;
            Save();
        }


    }
}
