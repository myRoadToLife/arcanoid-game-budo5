using System.Collections.Generic;

namespace Arkanoid
{
    public static class PointService
    {
        #region Variables

        private static readonly Dictionary<BlockType, int> _pointsByType = new();

        #endregion

        #region Public methods

        public static void AddPoints(BlockType type, int points)
        {
            _pointsByType.TryAdd(type, 0);
            _pointsByType[type] += points;
        }

        public static int GetPoints(BlockType blockType)
        {
            return _pointsByType.TryGetValue(blockType, out int points) ? points : 0;
        }

        public static void ResetAllPoints()
        {
            _pointsByType.Clear();
        }

        #endregion
    }
}