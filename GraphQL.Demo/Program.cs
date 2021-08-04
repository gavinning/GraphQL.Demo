using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace GraphQL.Demo {
    class MainClass {
        public async static Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            await demoGraphql();
        }

        async static Task demoGraphql() {
            //var graphQLClient = new GraphQLHttpClient("https://api.github.com/graphql");
            var graphQLClient = new GraphQLHttpClient("http://localhost:9902/graphql", new NewtonsoftJsonSerializer());

            var usersRequest = new GraphQLRequest {
                Query = @"
                    {
                        users {
                            username
                        }
                    }"
            };
            Console.WriteLine("12333");

            var resoponse = await graphQLClient.SendQueryAsync<ResponseType>(usersRequest);

            Console.WriteLine(resoponse.Data.Users[0].username);

            //return Task<'ok'>
        }
    }
}

public class ResponseType {
    public User[] Users { get; set; }
}

public class User {
    public string username { get; set; }
}