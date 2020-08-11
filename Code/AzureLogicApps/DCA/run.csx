Replace RUN.CSX  default code with the following code and replace your schema

using System.Net;
using Newtonsoft.Json;
using CsvHelper;

class PopulationRecord
{
    public String Location { get; set; }
    public int Time { get; set; }
    public long Population { get; set; }
}

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    string filePath = await req.Content.ReadAsStringAsync(); //get the CSV URI being passed from Logic App
    string response = "";

    //get a stream from blob
    WebClient wc = new WebClient();
    Stream s = wc.OpenRead(filePath);         

    //read the stream
    using (var sr = new StreamReader(s))
    {
        var csvReader = new CsvReader(sr);

        var records = csvReader.GetRecords.perf1(); //deserialize the CSV stream as an IEnumerable

        response = JsonConvert.SerializeObject(records); //serialize the IEnumerable back into JSON
    }    

    return response == null
        ? req.CreateResponse(HttpStatusCode.BadRequest, "There was an issue getting data")
        : req.CreateResponse(HttpStatusCode.OK, response);
 }
