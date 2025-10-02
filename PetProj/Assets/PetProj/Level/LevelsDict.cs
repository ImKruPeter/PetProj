using System;
using System.Collections.Generic;
using UnityEngine;

namespace PetProj.Level
{
    [CreateAssetMenu(menuName = "Models/LevelModels", fileName = "LevelModels")]
    public class LevelsDict : ScriptableObject
    {
        private Dictionary<int, LevelModel> _levelDict;

        [SerializeField] private List<LevelModel> levelModelList;

        public void SetLevels()
        {
            _levelDict.Clear();
            
            if (levelModelList.Count > 0)
            {
                foreach (var model in levelModelList)
                {
                    _levelDict.Add(model.LevelID, model);
                }
            }
        }

        public LevelModel GetLevelModel(int levelID)
        {
            if (_levelDict.ContainsKey(levelID))
            {
                return _levelDict[levelID];
            }

            Debug.Log("Level" + levelID + "not found");
            
            return new LevelModel();
        }
    }

    [Serializable]
    public struct LevelModel
    {
        [SerializeField] private string levelName;
        public int LevelID;
        public LevelView LevelView;
    }
}