var client = new HttpClient();

// Create the HttpContent for the form to be posted.
var requestContent = new FormUrlEncodedContent(new[] {
	new KeyValuePair<string, string>("text", "This is a block of text"),
});

// Get the response.
HttpResponseMessage response = await client.PostAsync(
	"https://api.jive.com/messaging/v1/messages/" +

	   "Content-Type: multipart/form-data/" +

	   "Accept: application/json/" +

	   "Authorization: Bearer {token}/" +

	   "ownerPhoneNumber=+15551234567;type=text/plain/" +

	   "contactPhoneNumbers=+15559998888;type=text/plain/" +

	   "body=Hi Bob;type=text/plain/" +

	   "media=@smile.jpg;type=image/jpeg",
	requestContent);

// Get the response content.
HttpContent responseContent = response.Content;

// Get the stream of the content.
using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
{
	// Write the output.
	Console.WriteLine(await reader.ReadToEndAsync());
}