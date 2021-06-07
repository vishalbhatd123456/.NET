using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SampleReq_1
{
    class Program
    {
	static void Main(string[] args)
	{
	    //initiate the get request
	    GetRequest("http://www.google.com.pk");


	    Console.ReadKey();
	}

	async static void GetRequest(string url)
	{
	    using (HttpClient client = new HttpClient())
	    {
		//create a client, then get a response from the server, discard the client once the  the connection is no longer needed.
		//async to the server
		using(HttpResponseMessage response = await client.GetAsync(url))
		{
		  using (HttpContent content = response.Content)
		    {
			HttpContentHeaders headers = content.Headers;
			Console.WriteLine(headers);
		    }
		}

	    }
	}
    }
}
