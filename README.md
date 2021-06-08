RestSharp supports rendering of unstructured data such a JSON,XML as a part of the request.

ADDING THE BODY TO THE REQUEST :
Call AddJsonBody or AddXmlBody both of which are the parents of the IrestRequest interface.

All the deserialization tasks would be handled automatically by RestSharp.

Sending a RestSharp request :

var request = new RestRequest(MethodToCall).AddJsonBody(updatedString);

Client : 

var request = new restRequest(Method.POST);

request.Resource = "Api/Score";
request.RequestFormat = DataFormat.Json;

request.AddBody(request.JsonSerializer(new {{ A = "foo", B = "bar" }));

RestResponse response = client.Execute(request);
