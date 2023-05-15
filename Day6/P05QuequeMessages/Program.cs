﻿using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=volleyballsabp;AccountKey=DOc1zasI6Zebqy1ImfXxxdYnoc31uJSz7LWwlNsPEGfOEzuoEiFtGr26c3FxYPpRQv92wNs01+ns+AStI3jtBQ==;EndpointSuffix=core.windows.net";

var queueName = "messages";
QueueClient queueClient = new QueueClient(connectionString, queueName);
await queueClient.CreateIfNotExistsAsync();
Console.WriteLine("Enter a message to add to the queue:");
var message = Console.ReadLine();
await queueClient.SendMessageAsync(message);
Console.WriteLine($"Message '{message}' added to the queue.");
Console.WriteLine("Retrieving a message from the queue...");
QueueMessage[] retrievedMessage = await queueClient.ReceiveMessagesAsync();
if (retrievedMessage != null && retrievedMessage.Length > 0)
{
    Console.WriteLine($"Message retrieved: '{retrievedMessage[0].MessageText}'");
    Console.WriteLine("Deleting the message from the queue...");
    await queueClient.DeleteMessageAsync(retrievedMessage[0].MessageId,
    retrievedMessage[0].PopReceipt);
    Console.WriteLine("Message deleted successfully.");
}

else
{
    Console.WriteLine("No messages found in the queue.");
}