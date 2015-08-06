using RestSharp;

namespace FhirRestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            callRest();
        }

        public static void callRest()
        {
            var client = new RestClient("http://worden.globalgold.co.uk:8080/FHIR_a/farm/cobalt/Patient/72428");
            var request = new RestRequest("Patient/1", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddHeader("Content-Type", "application/json; charset=UTF-8");
            var response = client.Execute(request);
        }
    }
}
