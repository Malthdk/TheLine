using UnityEngine;

namespace TheLine.PlayerVariables
{
    public class PlayerVariables : MonoBehaviour
    {
        public float maxJumpHeight = 3.5f;
        public float minJumpHeight = 1f;

        public float GetMaxJumpHeight()
        {
            return maxJumpHeight;
        }
    }
}