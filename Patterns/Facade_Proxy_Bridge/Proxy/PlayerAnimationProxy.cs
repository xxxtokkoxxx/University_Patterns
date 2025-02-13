using Patterns.Facade_Proxy_Bridge.Facade;

namespace Patterns.Facade_Proxy_Bridge.Proxy;

public class PlayerAnimationProxy : IPlayerAnimator
{
    private readonly IPlayerAnimator _playerAnimator;

    public PlayerAnimationProxy(IPlayerAnimator playerAnimator)
    {
        _playerAnimator = playerAnimator;
    }

    public void PlayMove()
    {
        _playerAnimator.PlayMove();
        Console.WriteLine("Add particles after movement complete");
    }

    public void PlayHeal()
    {
        _playerAnimator.PlayHeal();
        Console.WriteLine("Add particles after healing complete");
    }
}