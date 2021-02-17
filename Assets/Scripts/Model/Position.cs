using UnityEngine;

namespace Assets.Model {
    public class Position {
        /// <summary>
        /// Variables for future vector size assignment
        /// </summary>
        private static float _xSize { get; set; }
        private static float _ySize { get; set; }
        private static float _zSize { get; set; }

        public Position() { }

        public static Vector3 RandomPosition(float xSize, float ySize, float zSize) => new Vector3(Random.Range(xSize*-1,xSize), ySize, Random.Range(zSize * -1, zSize));
    }
}
