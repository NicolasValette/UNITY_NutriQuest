using UnityEngine;

namespace NutriQuest.Camera
{
    public class MoveCamera : MonoBehaviour
    {
        [SerializeField]
        private Transform _transformToFollow;
        [SerializeField]
        private float _speed;

        private void Start()
        {
            Vector3 position = transform.position;
            position.y = _transformToFollow.position.y;
            position.x = _transformToFollow.position.x;
            transform.position = position;
        }
        void Update()
        {

            float interpolation = _speed * Time.deltaTime;

            Vector3 position = transform.position;
            position.y = Mathf.Lerp(transform.position.y, _transformToFollow.position.y, interpolation);
            position.x = Mathf.Lerp(transform.position.x, _transformToFollow.position.x, interpolation);

            transform.position = position;
        }
    }
}