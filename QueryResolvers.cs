using HotChocolate;

namespace hot_chocolate
{
    // [GraphQLResolverOf("Query")]
    public class QueryResolvers
    {
        public string CurrentTimestamp()
        {
            return "now";
        }
    }
}