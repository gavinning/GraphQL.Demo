using System;
using System.Threading.Tasks;

namespace GraphQL.Demo {
    class MainClass {
        public async static Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            GraphQLClient client = GraphQLClient.Default();

            var data = await client.Request<UsersType>(GraphQLModel.users);

            Console.WriteLine(data.Data.users[0].username);
        }
    }
}
