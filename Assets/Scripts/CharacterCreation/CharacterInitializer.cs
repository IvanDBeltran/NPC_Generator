using UnityEngine;
using UnityEngine.Assertions;

namespace CharacterCreation
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class CharacterInitializer : MonoBehaviour
    {
        [Header("Character Setup")]
        [SerializeField] private CharacterData m_CharacterData;

        private MeshFilter m_MeshFilter;
        private MeshRenderer m_MeshRenderer;

        private void Awake()
        {
            CacheComponents();
        }

        private void OnEnable()
        {
            ValidateDependencies();
            InitializeCharacter();
        }
        
        private void InitializeCharacter()
        {
            if (m_CharacterData == null)
                return;

            gameObject.name = m_CharacterData.name;
            m_MeshFilter.sharedMesh = m_CharacterData.Mesh;
            m_MeshRenderer.sharedMaterial = m_CharacterData.GetMaterial();
        }
        
        private void CacheComponents()
        {
            m_MeshFilter = GetComponent<MeshFilter>();
            m_MeshRenderer = GetComponent<MeshRenderer>();
        }
        
        [ContextMenu("Validate")]
        private void ValidateDependencies()
        {
            Assert.IsNotNull(m_CharacterData, $"{nameof(CharacterInitializer)} requires a valid {nameof(CharacterData)} asset.");
            Assert.IsNotNull(m_MeshFilter, $"{nameof(CharacterInitializer)} requires a {nameof(MeshFilter)} component.");
            Assert.IsNotNull(m_MeshRenderer, $"{nameof(CharacterInitializer)} requires a {nameof(MeshRenderer)} component.");
        }
    }
}
