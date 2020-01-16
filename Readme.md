# 200 Oker Lambda project

A simple lambda function that takes in a json file with urls, hits them to check if they return 200 OK. If not, log the failed urls and throw an exception.


This lambda project consists of:
* Function.cs - class file containing a class with a single function handler method
* Services/OkerService  - Runs 200 Oker and returns failed responses if any
* FileReader - Simple class to read contents of json file
* urls.json - Json file containing list of urls that need to be checked for 200 Ok status. 
* aws-lambda-tools-defaults.json - default argument settings for use with Visual Studio and command line deployment tools for AWS

## Project architecture
![200 Oker architecture](https://miro.medium.com/max/3524/1*OJWA2VYLivuSwtxb6dE6Nw.png)

## Here are some steps to follow from Visual Studio:

To deploy your function to AWS Lambda, right click the project in Solution Explorer and select *Publish to AWS Lambda*.

To view your deployed function open its Function View window by double-clicking the function name shown beneath the AWS Lambda node in the AWS Explorer tree.

To perform testing against your deployed function use the Test Invoke tab in the opened Function View window.

To configure event sources for your deployed function, for example to have your function invoked when an object is created in an Amazon S3 bucket, use the Event Sources tab in the opened Function View window.

To update the runtime configuration of your deployed function use the Configuration tab in the opened Function View window.

To view execution logs of invocations of your function use the Logs tab in the opened Function View window.
