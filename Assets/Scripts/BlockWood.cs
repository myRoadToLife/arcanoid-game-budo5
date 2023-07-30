using UnityEngine;

namespace Arkanoid
{
    public class BlockWood : MonoBehaviour
    {
        #region Variables

        private int _lives = 3;

        #endregion

        #region Unity lifecycle

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                _lives--;
                if (_lives == 0)
                {
                    Destroy(gameObject);
                }
            }
        }

        #endregion
    }
}