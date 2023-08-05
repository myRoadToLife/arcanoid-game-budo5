using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arkanoid
{
    public class BottomWall : MonoBehaviour
    {
        #region Unity lifecycle

        private void OnTriggerEnter2D(Collider2D collision)
        {
            ReloadScene(collision);
        }

        #endregion

        #region Private methods

        private static void ReloadScene(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Trigger"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                PointService.ResetAllPoints();
            }
        }

        #endregion
    }
}