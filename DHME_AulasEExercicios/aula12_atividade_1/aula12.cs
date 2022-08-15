using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula12_atividade_1
{
    internal class aula12 // Room 1 - Hugo Diniz // Gabrielle
    {
        static void Main(string[] args)
        {
            ToDo NossoTodo = new ToDo();

            NossoTodo.AddTask("Aprender C#");
            NossoTodo.ShowTask(0);
            NossoTodo.AddTask("Aprender JS");
            NossoTodo.AddTask("Aprender Vue.js");
            NossoTodo.AddTask("Aprender Node.js");
            NossoTodo.AddTask("Abobora");
            NossoTodo.AtualizaTask("Aprender C#", "Aprender C# do jeito certo");
            NossoTodo.ListaTasks();
            NossoTodo.RemoveTask("Abobora");
            NossoTodo.ShowTask(0);
            NossoTodo.ListaTasks();
        }
    }
}