using UnityEngine;

namespace Arkanoid
{
    public class BlockWood : MonoBehaviour
    {
        #region Variables

        private readonly int _currentPoint = 2;

        private int _lives = 2;

        #endregion

        #region Unity lifecycle

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                _lives--;
                if (_lives == 0)
                {
                    CurrentWoodPoints.WoodPoints += _currentPoint;
                    Destroy(gameObject);
                }
            }
        }

        #endregion
    }
}