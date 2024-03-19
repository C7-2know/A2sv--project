using System.IO ;

public enum Categorys
{
    Personal,
    Work,
    Errands
}
public class Task{
    public string Name {get;set;}
    public string Description {get;set;}
    public Categorys Category;
    public bool IsCompleted ;
}
public class TaskManger{
    List<Task> tasks= new List<Task>();
    public StreamWriter writer;
    
    public async void addTask(Task task){
        this.tasks.Add(task);
        using (StreamWriter writer = new StreamWriter("task.csv",true)){
            await writer.WriteLineAsync($"{task.Name},{task.Description},{task.Category},{task.IsCompleted}");
        }
    }

    public async void loadDataFromCsvFile(string filePath){
        try{
            using (StreamReader reader=new StreamReader(filePath)){
                // await reader.ReadLineAsync();
                string line;
                while((line=await reader.ReadLineAsync())!=null){
                    string[] colm=line.Split(',');
                    Task task;
                    if(colm.Length==4){
                        task=new Task(){Name=colm[0],Description=colm[1], Category=(Categorys)Enum.Parse(typeof(Categorys),colm[2]),IsCompleted=bool.Parse(colm[3])};
                        Console.WriteLine("working!!");
                        this.tasks.Add(task);
                    }else
                    {
                        Console.WriteLine("Error!!");
                    }
                }
            }
        }catch(Exception e){
            Console.WriteLine($"error, {e}");
        }
    }
    public void showTasks(){
        foreach(Task task in this.tasks){
            Console.WriteLine($"task name: {task.Name} description: {task.Description} category:{task.Category}  completed: {task.IsCompleted}");
        }
    }
    public void filterTask(Categorys category){
        List<Task> filteredTasks=this.tasks.Where(task=>task.Category==category).ToList();
        foreach(Task task in filteredTasks){
            Console.WriteLine($"task name: {task.Name} description: {task.Description} category {task.Category} ");
        }
    }
    public void updateTask(Task tas){
        Task task =this.tasks.Find(tsk=>tsk.Name==tas.Name);
        task.IsCompleted= !task.IsCompleted;
    }
    public static void Main(){
        TaskManger taskManager=new TaskManger();
        taskManager.loadDataFromCsvFile("task.csv");
        Task task3=new Task(){Name="Visit",Description="drive to the capital",Category=Categorys.Work,IsCompleted=false};
        taskManager.addTask(new Task(){Name="write",Description="write paragraph",Category=Categorys.Personal,IsCompleted=false});
        taskManager.addTask(new Task(){Name="send Gift",Description="send Gift for the employee",Category=Categorys.Errands,IsCompleted=false});
        taskManager.addTask(new Task(){Name="Visit",Description="drive to the capital",Category=Categorys.Work,IsCompleted=false});
        // taskManager.updateTask(task3);
        taskManager.showTasks();
        // taskManager.filterTask(Categorys.Personal);

        
        
    }

}
