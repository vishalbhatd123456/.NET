using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;

namespace SampleReq_1
{
    class Program
    {
	static void Main(string[] args)
	{
	    //initiate the get request
	    PostRequest("https://posttestserver.com/post.php");


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

	async static void PostRequest(string url)
	{
	    IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
	    {
		new KeyValuePair<string, string>("query1","vishal"),
		new KeyValuePair<string, string>("query2","saurabh")
	    };
	    HttpContent q = new FormUrlEncodedContent(queries);
	    using (HttpClient client = new HttpClient())
	    {
		try
		{
		    using (HttpResponseMessage response = await client.PostAsync(url, q))
		    {
			using (HttpContent content = response.Content)
			{
			    string myContent = await content.ReadAsStringAsync();
			    HttpContentHeaders headers = content.Headers;

			}
		    }
		}catch(Exception e) { }
	    }
	}
    }
}
