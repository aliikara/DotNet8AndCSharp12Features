namespace DotNet8AndCSharp12Features
{
    public class DefaultLambdaParameters
    {
        public void Demo()
        {
            var lambdaDemo = (string name = "User") => Console.WriteLine($"Hello {name}");

            lambdaDemo();
            lambdaDemo("Gandalf");
            Console.WriteLine($"Default parameter value is: {lambdaDemo.Method.GetParameters()[0].DefaultValue}");
        }
    }
}
