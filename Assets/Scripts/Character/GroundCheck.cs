using UnityEngine;

namespace NutriQuest.Character
{


    public class GroundCheck : MonoBehaviour
    {
        [SerializeField]
        private float _rayDistance;
        public bool IsGrounded ()
        {
            Ray ray = new Ray(transform.position, Vector3.down);
            RaycastHit hit;
            bool result = Physics.Raycast(ray, out hit, _rayDistance);
           
            Debug.Log($"Ground Check : {result}");
            return result;
        }
      
    }
}