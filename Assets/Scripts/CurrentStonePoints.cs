using TMPro;
using UnityEngine;

namespace Arkanoid
{
    public class CurrentStonePoints : MonoBehaviour
    {
        #region Variables

        public static int StonePoints;
        private TMP_Text _text;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.text = $"Stone: {StonePoints.ToString()}";
        }

        #endregion
    }
}