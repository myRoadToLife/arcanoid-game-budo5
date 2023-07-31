using TMPro;
using UnityEngine;

namespace Arkanoid
{
    public class CurrentMetalPoints : MonoBehaviour
    {
        #region Variables

        public static int MetalPoints;
        private TMP_Text _text;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.text = $"Metal: {MetalPoints.ToString()}";
        }

        #endregion
    }
}