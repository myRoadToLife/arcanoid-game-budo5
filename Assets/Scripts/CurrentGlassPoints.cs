using TMPro;
using UnityEngine;

namespace Arkanoid
{
    public class CurrentGlassPoints : MonoBehaviour
    {
        #region Variables

        public static int GlassPoints;
        private TMP_Text _text;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.text = $"Glass: {GlassPoints.ToString()}";
        }

        #endregion
    }
}