using OpenAI.Managers;
using OpenAI;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;
using OpenAI.Interfaces;


string _ApiKey = "Your_API_Key";

while (true)
{
    var openAiService = new OpenAIService(new OpenAiOptions()
    {
        ApiKey = _ApiKey
    });
    Console.WriteLine("Please enter your prompt.");
    var usersPrompt = Console.ReadLine();
    #region ChatGPTExample




    //var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
    //{
    //    Messages = new List<ChatMessage>
    //    {
    //        // ChatMessage.FromSystem("You are a helpful assistant."),
    //        //ChatMessage.FromUser("Who won the world series in 2020?"),
    //        //ChatMessage.FromAssistant("The Los Angeles Dodgers won the World Series in 2020."),
    //        ChatMessage.FromUser(usersPrompt)
    //    },
    //    Model = Models.Gpt_3_5_Turbo,
    //    MaxTokens = 50//optional
    //});
    //if (completionResult.Successful)
    //{
    //    Console.WriteLine(completionResult.Choices.First().Message.Content);
    //}
    //else
    //{
    //    Console.WriteLine("Chat completion was not successful. Error details:");
    //    Console.WriteLine($"Error: {completionResult.Error?.Message}");
    //    Console.WriteLine($"Code: {completionResult.Error?.Code}");
    //}

    #endregion
    #region DALL·E Sample

    var imageResult = await openAiService.Image.CreateImage(new ImageCreateRequest
    {
        Prompt = usersPrompt,
        N = 3,
        Size = StaticValues.ImageStatics.Size.Size512,
        ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
        User = "TestUser"
    });


    if (imageResult.Successful)
    {
        Console.WriteLine(string.Join("\n", imageResult.Results.Select(r => r.Url)));
    }
    Console.ReadLine();


    #endregion
}