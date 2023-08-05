using System;
using UnityEngine;

namespace Arkanoid
{
    public class Block : MonoBehaviour
    {
        #region Variables

        [SerializeField] private int _points;
        [SerializeField] private int _lives;
        [SerializeField] private Sprite[] _livesSprite;
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private BlockType _blockType;

        #endregion

        #region Unity lifecycle

        private void OnCollisionEnter2D(Collision2D collision)
        {
            ApplyHit(collision);
            
        }

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        #endregion

        #region Private methods

        private void ApplyHit(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                _lives--;
                
                
                if (_lives == 0)
                {
                    PointService.AddPoints(_blockType, _points);
                    Destroy(gameObject);
                }
                else
                {
                    _spriteRenderer.sprite =
                        _livesSprite.Length <= _lives ? _livesSprite[^1] : _livesSprite[_lives - 1];
                }
            }
            
        }

        #endregion
    }
}