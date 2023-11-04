using System.Diagnostics;
using Antlr4.Runtime.Misc;

public class HelloWorldVisitor : HelloBaseVisitor<string>
{
    public string VisitHelloWorld([NotNull] HelloParser.RContext context) {
        UnityEngine.Debug.Log($"Received ID: {context.ID()}");
        return context.GetText();
    }
}
