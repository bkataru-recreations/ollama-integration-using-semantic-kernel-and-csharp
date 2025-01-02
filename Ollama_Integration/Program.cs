using System;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

namespace Ollama_Integration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a kernel builder
            var builder = Kernel.CreateBuilder();

            builder.AddOllamaChatCompletion(
                modelId: "llama3.2",
                endpoint: new Uri("http://localhost:11434")
            );

            // Build the kernel
            var kernel = builder.Build();
            // Get the chat completion service
            var chatService = kernel.GetRequiredService<IChatCompletionService>();
            // Initialize chat history
            ChatHistory history = [];

            history.AddSystemMessage("You are a helpful assistant.");

            while (true)
            {
                Console.Write("You: ");
                var userMessage = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userMessage))
                {
                    break;
                }

                history.AddUserMessage(userMessage);
                var response = await chatService.GetChatMessageContentAsync(history);
                Console.WriteLine($"\nBot: {response}\n");
                history.AddAssistantMessage(response.ToString());
            }
        }
    }
}