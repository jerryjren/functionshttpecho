using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, ILogger log)
{
    log.LogInformation($"Echo : {req.Query["name"]}");

    object requestBody = await req.Content.ReadAsAsync<object>();

    return new HttpResponseMessage(HttpStatusCode.OK);
    // return Ok($"Hello {req.Query.name}");
}
