using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheLine.PlayerVariables;

namespace TheLine.Player
{
    public class Player1 : MonoBehaviour
    {
        private Animator _animator;
        private IntoLine _intoLine;
        private BoxCollider2D _playerCollider;
        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }
    }
}