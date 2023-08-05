using TMPro;
using UnityEngine;

namespace Arkanoid
{
    public class PointsLabel : MonoBehaviour
    {
        #region Variables

        [SerializeField] private BlockType _blockType;
        [SerializeField] private string _prefix;

        private TMP_Text _text;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.text = $"{_prefix}:{PointService.GetPoints(_blockType)}";
        }

        #endregion
    }
}