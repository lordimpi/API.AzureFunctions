using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.AzureFunctions.Test.Helpers
{
    public class MockCloudTableTodos : CloudTable
    {
        public MockCloudTableTodos(Uri tableAddress, TableClientConfiguration configuration = null) : base(tableAddress, configuration)
        {
        }

        public MockCloudTableTodos(Uri tableAbsoluteUri, StorageCredentials credentials, TableClientConfiguration configuration = null) : base(tableAbsoluteUri, credentials, configuration)
        {
        }

        public MockCloudTableTodos(StorageUri tableAddress, StorageCredentials credentials, TableClientConfiguration configuration = null) : base(tableAddress, credentials, configuration)
        {
        }

        public override async Task<TableResult> ExecuteAsync(TableOperation operation)
        {
            return await Task.FromResult(new TableResult
            {
                HttpStatusCode = 200,
                Result = TestFactory.GetTodoEntity()
            });
        }
    }
}
