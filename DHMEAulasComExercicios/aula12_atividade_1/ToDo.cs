namespace aula12_atividade_1
{
    public class ToDo
    {
        private List<string> OurTodo = new List<string>();

        //adicionar tarefa

        public bool AddTask(string TaskText)
        {
            OurTodo.Add(TaskText);
            return true;
        }

        //remover tarefa
        public bool RemoveTask(string TaskText)
        {
            OurTodo.Remove(TaskText);
            return true;
        }
        //atualizar tarefa
        public bool AtualizaTask(string TaskText, string TaskToUpdate)
        {
            if (OurTodo.IndexOf(TaskText) >= 0)
            {
                OurTodo[OurTodo.IndexOf(TaskText)] = TaskToUpdate;
                return true;
            }
            return false;
        }
        //Listar todas as tarefas
        public void ListaTasks()
        {
            foreach (string Task in OurTodo)
            {
                Console.WriteLine(Task);
            }
        }
        //apresentar uma tarefa a partir do indice
        public bool ShowTask(int TaskIndex)
        {
            Console.WriteLine(OurTodo.ElementAt(TaskIndex));
            return true;
        }
    }
}