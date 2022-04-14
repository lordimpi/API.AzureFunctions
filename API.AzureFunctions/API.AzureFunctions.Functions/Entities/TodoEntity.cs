using Microsoft.Azure.Cosmos.Table;
using System;

namespace API.AzureFunctions.Functions.Entities
{
    public class TodoEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
