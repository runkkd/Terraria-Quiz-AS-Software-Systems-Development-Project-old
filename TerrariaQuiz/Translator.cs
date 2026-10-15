using Amazon;
using Amazon.Translate;
using Amazon.Translate.Model;
using System;

// Fully Commented [X]

public class Translator
{
    // IMPORTNANT NOTES
    // If this translator stops working it is because my subscription for amazon web services has run out or because the proxy on your computer is blocking it
    // Playing on a language other than english will cause longer loading times as it needs to access the amazon web services to translate text
    private readonly AmazonTranslateClient translateClient;
    public string region = "eu-west-1";


    public Translator()
    {
        // Set up Amazon Translate client
        //translateClient = new AmazonTranslateClient(accessKeyId, secretAccessKey, RegionEndpoint.GetBySystemName(region));
    }

    // Method to send input text to amazon web services translation client and translate the text into specified language
    public string TranslateText(string text, string sourceLanguage, string targetLanguage)
    {
        try
        {
            // Set up translation request
            TranslateTextRequest request = new TranslateTextRequest
            {
                Text = text,
                SourceLanguageCode = sourceLanguage,
                TargetLanguageCode = targetLanguage
            };

            // Perform translation
            TranslateTextResponse response = translateClient.TranslateText(request);
            return response.TranslatedText;
        }
        catch (Exception ex)
        {
            // Handle exception
            Console.WriteLine($"Translation error: {ex.Message}");
            return string.Empty;
        }
    }
}