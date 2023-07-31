using TMPro;
using UnityEngine;

namespace Arkanoid
{
    public class CurrentWoodPoints : MonoBehaviour
    {
        #region Variables

        public static int WoodPoints;
        private TMP_Text _text;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.text = $"Wood: {WoodPoints.ToString()}";
        }

        #endregion

        //TODO: Сделать очки и текст для каждого блока!
    }
}