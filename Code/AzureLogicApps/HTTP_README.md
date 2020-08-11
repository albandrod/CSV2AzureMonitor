## Send CSV Data to Azure Monitor

To send CSV data to Azure Monitor in a readbale mode we must to work with the specific actions and triggers.

The actions is based on the following steps:

HTTP - Trigger an event based on a select REST API and get the relevant CSV file

Initializes a variable - Initialize variable action definitions from CSV file with a specific value based on json format and with object

Parse Json - Specify the schema of JSON content with variable, and with the json schema and sample pyalod  

Send Data - sending data to Azure Log Analytics with json request: Body


