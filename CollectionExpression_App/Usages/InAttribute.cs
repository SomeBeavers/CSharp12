namespace CollectionExpression_App.Usages;

[CollectionExpression(["", "1", nameof(intField)])]
public class InAttribute
{
    public int intField;
}

public class CollectionExpressionAttribute(string[] parameter) : Attribute
{
    public string[] Parameter { get; } = parameter;
}