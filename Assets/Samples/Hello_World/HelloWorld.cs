using Antlr4.Runtime;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private string _name = "World";
    [SerializeField] private string _number = "1234";

	void Start () 
	{
		ShowCorrectResult();
		ShowIncorrectResult();
	}

	private void ShowCorrectResult() {
		var antlerStream = new AntlrInputStream("Hello " + _name); // Transform into a character stream
		var lexer = new HelloLexer(antlerStream); // Create a Lexer from the stream
		var tokenStream = new CommonTokenStream(lexer); // Create tokens out of the Lexer
		var parser = new HelloParser(tokenStream); // And feed the parser with the tokens
		var visitor = new HelloWorldVisitor(); // Create a visitor to visit the tree generated by the parser
		var tree = parser.r(); // Generate the tree
		Debug.Log($"CORRECT RESULT: {visitor.VisitHelloWorld(tree)}");
	}

	private void ShowIncorrectResult() {
		var antlerStream = new AntlrInputStream("Hello " + _number);
		var lexer = new HelloLexer(antlerStream);
		var tokenStream = new CommonTokenStream(lexer);
		var parser = new HelloParser(tokenStream);
		var visitor = new HelloWorldVisitor();
		var tree = parser.r();
		Debug.Log($"INCORRECT RESULT: {visitor.VisitHelloWorld(tree)}");
	}
}
