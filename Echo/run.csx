using System.Net;
using System.Net.Http;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage request, ILogger log)
{
    object requestBody = await request.Content.ReadAsAsync<object>();

    return new HttpResponseMessage(HttpStatusCode.OK);
}
