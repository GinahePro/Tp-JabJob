using UnityEngine;
using BaseStateMachine;

namespace Player
{
    public class PlayerBody : MonoBehaviour
    {

        [SerializeField] Transform cameraVerticalRotationPoint;
        StateMachine stateMachine;

        public void Start()
        {
            PlayerContext context = new PlayerContext(this.transform,cameraVerticalRotationPoint,GetComponent<Rigidbody>());
            PlayerState_Base baseState = new PlayerState_Base(context);
            stateMachine = new StateMachine(baseState);
        }

        public void Update()
        {
            stateMachine.CustomUpdate();
        }
    }
}