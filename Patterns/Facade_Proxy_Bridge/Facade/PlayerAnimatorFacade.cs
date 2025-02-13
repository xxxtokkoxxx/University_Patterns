namespace Patterns.Facade_Proxy_Bridge.Facade;

public class PlayerAnimatorFacade : IPlayerAnimator
{
    private Animator _animator;

    public void PlayMove()
    {
        _animator.PlayAnimation("Move");
    }

    public void PlayHeal()
    {
        _animator.PlayAnimation("Heal");
    }
}