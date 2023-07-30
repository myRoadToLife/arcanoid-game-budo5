using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arkanoid
{
    public class Ball : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Platform _platform;
        private bool _isStarted;

        private Vector3 _offset;
        private Vector2 _randomFloat;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            _randomFloat.x = Random.Range(-10f, 10f);
            _randomFloat.y = 10f;
            _offset = transform.position - _platform.transform.position;
        }

        private void Update()
        {
            if (_isStarted)
            {
                return;
            }

            MoveWithPad();

            if (Input.GetMouseButton(0))
            {
                StartBall();
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Trigger"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        #endregion

        #region Private methods

        private void MoveWithPad()
        {
            Vector3 platformPosition = _platform.transform.position;
            platformPosition += _offset;
            transform.position = platformPosition;
        }

        private void StartBall()
        {
           
            _isStarted = true;
            _rb.velocity = _randomFloat;
        }

        #endregion
    }
}