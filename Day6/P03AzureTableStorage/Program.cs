


using Azure;
using Azure.Data.Tables;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsabp;AccountKey=DOc1zasI6Zebqy1ImfXxxdYnoc31uJSz7LWwlNsPEGfOEzuoEiFtGr26c3FxYPpRQv92wNs01+ns+AStI3jtBQ==;EndpointSuffix=core.windows.net";

string tableName = "Persons";

var tableClient = new TableClient(connectionString, tableName);

// Create a table in your storage account
await tableClient.CreateIfNotExistsAsync();

// Insert an entity into the table
/*var entity = new TableEntity("volleyball", "player5")
{
{ "firstname", "John" },
{ "country", "BRA" },
};
await tableClient.AddEntityAsync(entity);
Console.WriteLine("Entity added to the table.");*/

// Query entities from the table
/*var entity = new TableEntity("volleyball", "player5");
string partitionKeyFilter = $"PartitionKey eq '{entity.PartitionKey}'";
await foreach (var e in tableClient.QueryAsync<TableEntity>(partitionKeyFilter))
{
    Console.WriteLine($"" +
        $"PartitionKey: {e.PartitionKey}, " +
        $"RowKey: {e.RowKey}, " +
        $"Property1: {e.GetString("country")}, " +
        $"Property2: {e.GetString("firstname")}, " +
        $"Property3: {e.GetString("lastname")}, " +
        $"Property4: {e.GetString("phonenumber")}, ");
}*/

var entity = new TableEntity("volleyball", "player6");
// Update an entity in the table
/*entity["Property1"] = "NewValue1";
await tableClient.UpdateEntityAsync(entity, ETag.All);
Console.WriteLine("Entity updated in the table.");*/

// Delete an entity from the table
await tableClient.DeleteEntityAsync(entity.PartitionKey, entity.RowKey);
Console.WriteLine("Entity deleted from the table.");