using UnityEngine;

namespace Arkanoid
{
    public class Ball : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Platform _platform;
        [SerializeField] private int _speedBall = 10;
        [SerializeField] private int _speedMaxX = 10;
        [SerializeField] private int _speedMinX = 3;
        [SerializeField] private int _speedY = 10;

        private bool _isStarted;

        private Vector3 _offset;
        private Vector2 _randomFloat;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
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
            _rb.velocity = StartVector();
        }

        private Vector2 StartVector()
        {
            float x = Random.Range(-_speedMinX, _speedMaxX);
            float y = _speedY;
            return new Vector2(x, y).normalized * _speedBall;
        }

        #endregion
    }
}