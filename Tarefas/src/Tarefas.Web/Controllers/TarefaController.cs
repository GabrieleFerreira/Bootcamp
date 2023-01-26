using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers{
    public class TarefaController : Controller{
        public IActionResult Create(){
            return View();
        
        }
        public List<TarefaViewModel> listaDeTarefas {get;set;}
        public TarefaController()
        {
            listaDeTarefas = new List<TarefaViewModel>{
                new TarefaViewModel(){id = 1, Titulo = "Arrumando a casa ", Descricao = "Lavar louça "},
                new TarefaViewModel(){id = 1,Titulo = "Arrumando a casa ", Descricao = " Arrumar a cama"},
                new TarefaViewModel(){id = 1,Titulo = "Arrumando a casa ", Descricao = " Arrumar a cama"},
            };
        }
        public IActionResult Index(){
             
            return View(listaDeTarefas);

        }
        public IActionResult Detalis(int id){
          var tarefa =  listaDeTarefas.Find(tarefa => tarefa.id == id);
          return View(tarefa);

        }

    }
    }


