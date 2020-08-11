# Send data to Azure Monitor

## Introduction

There are many ways to send data every data to Azure Monitor (or the Azure Log Analytics), and it all depends on the sources from which the information is transmitted.

For example, if you need to send small CSV file (less than 30 MB) and you need to parse it to JSON and than send it to Azure Monitor, than you can send the data with the HTTP Data Collector API in a simple way.

But if you need to send with a large file you must to add the option of chunking inside Azure Logic Apps.

In all the ways data is sent, we can work with a number of different tools, such as: Azure Logic Apps, Azure Function, Azure Blob, Azure Log Analytics.

In addition, we work with a number of code languages, such as,Python, PowerShell, C# and others.
