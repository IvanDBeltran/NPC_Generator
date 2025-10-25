using System.Collections.Generic;
using UnityEngine;

namespace CharacterCreation
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData")]
    public class CharacterData : ScriptableObject
    {
        [SerializeField] private Mesh m_Mesh;
        public Mesh Mesh => m_Mesh;
   
        [SerializeField] List<Material> m_Materials = new List<Material>();
    
        public Material GetMaterial()
        {
            if (m_Materials.Count == 0)
            {
                Debug.Log("No materials assigned to character");
                return null;
            }
        
            return m_Materials[Random.Range(0, m_Materials.Count)];
        }

    }
}