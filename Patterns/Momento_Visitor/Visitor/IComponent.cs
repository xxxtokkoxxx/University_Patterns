namespace Patterns.Momento_Visitor.Visitor;

public interface IComponent
{
    void Accept(IVisitor visitor);
}