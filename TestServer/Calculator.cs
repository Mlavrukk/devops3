using TestServer.Model;

namespace TestServer;

public static class Calculator
{
    public static void Hello() {
        return;
    }
    
    public static int Sum(IEnumerable<Number> numbers) => numbers.Sum(n => n.Value);
}
