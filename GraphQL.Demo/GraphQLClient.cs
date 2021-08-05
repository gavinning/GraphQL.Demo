using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

public class GraphQLClient {

    string baseURL = "http://localhost:9902/graphql";
    GraphQLHttpClient client;// = new GraphQLHttpClient(baseURL, new NewtonsoftJsonSerializer());


    private GraphQLClient() {
        client = new GraphQLHttpClient(baseURL, new NewtonsoftJsonSerializer());
    }

    public static GraphQLClient Default() {
        return new GraphQLClient();
    }

    public Task<GraphQLResponse<T>> Request<T>(string query) {
        var req = new GraphQLRequest { Query = query };
        return client.SendQueryAsync<T>(req);
    }
}
