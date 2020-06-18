using System.Net;
using System.Net.Http;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, ILogger log)
{
    object requestBody = await req.Content.ReadAsAsync<object>();

    return new HttpResponseMessage(HttpStatusCode.OK);
}
