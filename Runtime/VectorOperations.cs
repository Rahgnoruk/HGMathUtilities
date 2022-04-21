using UnityEngine;

namespace HyperGnosys.MathUtilities
{
    public static class VectorOperations
    {
        /// Angles
        ///Los angulos se representan con floats de 0 a 360
        public static Vector3 GetXYVectorDirectionFromAngle(float angle)
        {
            float angleRad = angle * Mathf.Deg2Rad;
            return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
        }
        public static Vector3 GetXZVectorDirectionFromAngle(float angleInGlobalCoords)
        {
            float angleRad = angleInGlobalCoords * Mathf.Deg2Rad;
            return new Vector3(Mathf.Sin(angleRad), 0, Mathf.Cos(angleRad));
        }
        public static Vector3 GetRandomDir()
        {
            return new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        }
        public static Vector3 GetRandomXZDir()
        {
            return new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
        }
        public static Vector3 GetRandomXYDir()
        {
            return new Vector3(Random.Range(-1, 1), Random.Range(-1, 1));
        }
        public static float DistFromPointToACircleAroundAnotherPoint(Vector2 firstPoint, Vector2 secondPoint, float circleRadius)
        {
            return Vector2.Distance(firstPoint, secondPoint) - circleRadius;
        }
    }
}