using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ServerlessExample
{
    public class Handler
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string ExecuteLambda(ILambdaContext context)
        {
            // context.Logger.LogLine($"Executing test lambda function with input '{input}'");
            // return $"Hello {input?.ToUpper()}";
            LambdaLogger.Log("Executing test lambda function");
            context.Logger.LogLine($"Executing test lambda function with input");
            return $"Hello";
        }
    }
}
