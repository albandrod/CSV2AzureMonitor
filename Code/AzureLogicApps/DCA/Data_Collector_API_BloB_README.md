## Data Collector API with Blob and Azure Function

The new option to send data to Azure Monitor is the Data Collector API option.

With Data Collector API you can work with a specific blob, the Data Collector API itself and the Azure FUnction to convert csv to json.

The actions:

* When a blob is added or modified - This operation triggers a flow when one or more blobs are added or modified in a container. This trigger will only fetch the file metadata. To get the file content, you can use the "Get file content" operation. The trigger does not fire if a file is added/updated in a subfolder.

* Create SAS URI by Path - This operation creates a SAS link for a blob using the path.

* HTTP Trigger with dedicate Azure FUnction

* Send Data - Sending data to Azure Log Analytics 

<img src="https://github.com/eshlomo1/CSV2AzureMonitor/blob/master/stuff/2020-08-11_22h35_10.png">



