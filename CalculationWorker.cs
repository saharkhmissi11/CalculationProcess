
using CamundaClient.Dto; //Contains Data Transfert Object classes for working with camunda entities
using CamundaClient.Worker; //Contains classes and interfaces to handle external tasks

namespace SimpleCalculationProcess
{
    [ExternalTaskTopic("calculate")]  //name of the topic
    //With this annotation, the system knows that this class  is a camunda task worker
    [ExternalTaskVariableRequirements("x", "y")] //required variables in order to execute the task worker
    class CalculationWorker : IExternalTaskAdapter // IExternalTaskAdapter : an interface (from CamundaClient.Worker) that executes the business logic of the task
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            //ExternalTask : is a class (from CamundaClient.dto) 
            long x = Convert.ToInt64(externalTask.Variables["x"].Value); // This line of code will take the value the variable "x" of the camunda process "calculate"
            long y = Convert.ToInt64(externalTask.Variables["y"].Value);
            long result = x + y;
            Console.WriteLine("la somme est :" + result);
            resultVariables.Add("result", result);   // This line of code will put the result in the variable "result " of the process

        }

    }
}
