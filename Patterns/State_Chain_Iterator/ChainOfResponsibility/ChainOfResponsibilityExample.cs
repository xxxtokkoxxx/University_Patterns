namespace Patterns.State_Chain_Iterator.ChainOfResponsibility;

public class ChainOfResponsibilityExample
{
    static void ChainOfResponsibilityExampleMethod()
    {
        Handler authHandler = new AuthenticationHandler();
        Handler authorizeHandler = new AuthorizationHandler();
        Handler logHandler = new LoggingHandler();

        authHandler.SetNext(authorizeHandler);
        authorizeHandler.SetNext(logHandler);

        authHandler.Handle("Authentication");
    }
}