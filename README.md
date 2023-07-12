# CalculationProcess
A calculation process using Camunda and .NET
## Application Description
This application is a simple calculation that uses a .NET worker
The process requires two variables "x" and "y" and gives their sum.
## Required packages
     - CamundaClient : Camunda REST API Client for .NET platform
     - Newtonsoft.json : Serialize and deserialize any .NET object 
## Classes :
     - CalculationProcessTest.cs : This class will start  test the process by giving two variables x and y.
      PS : We can start the process directly from Camunda Platform Run Tasklist and give the two numbers in a Camunda form.
      - CalculationWorker.cs : This class represents a camunda external task worker. The .NET application will recognize it by its annotation "ExternalTask"
      - Program.cs : This the main class that will call the test class and start the external tasks workers.

