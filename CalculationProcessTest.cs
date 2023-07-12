using CamundaClient;

namespace Calculation
{

    // First of all, we need to deploy the camunda model on localhost
    //This class is a test for the workflow (Here we will give the rwo required numbers "x" and "y")
    //But we can start the process from the camunda tasklist and fill the form there 
    
    internal class CalculationProcessTest
    {
        public void TestHappyPath()
        {
            // Engine client should point to a dedicated Camunda instance for test, preferrably locally available
            var camunda = new CamundaEngineClient(new System.Uri("http://localhost:8080/engine-rest/engine/default/"), null, null);

            // Deploy the model on the localhost:8080
            //string deploymentId = camunda.RepositoryService.Deploy("cal", new List<FileParameter> {
            //FileParameter.FromManifestResource(Assembly.GetExecutingAssembly(), "Calculation.calculation.bpmn") });
            
            // Start the process with definitinKey "calculate" with two variables x=21 and y=1000
            string processInstanceId = camunda.BpmnWorkflowService.StartProcessInstance("calculate", new Dictionary<string, object>()
            {
                {"x", 21},
                {"y", 1000}
            });
        }
    }
}
