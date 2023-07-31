using UnityEngine;

namespace Arkanoid
{
    public class BlockStone : MonoBehaviour
    {
        #region Variables

        private int _lives = 4;
        private readonly int _currentPoint = 4;

        #endregion

        #region Unity lifecycle

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                _lives--;
                if (_lives == 0)
                {
                    CurrentStonePoints.StonePoints += _currentPoint;
                    Destroy(gameObject);
                }
            }
        }

        #endregion
    }
}