using UnityEngine;

public class FireManager : MonoBehaviour
{
    public Animator fireAnimator;
    private bool fireOn = true;

    public void ToggleFire()
    {
        if (fireAnimator != null)
        {
            fireOn = !fireOn;
            fireAnimator.SetBool("FireToggle",fireOn);
        }
    }
}
