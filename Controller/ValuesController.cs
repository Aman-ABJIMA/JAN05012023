using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp2.Controller
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        //[Route("api/get-all")]
       // [Route("[controller]/[action]")]
        public string GetAll()
        {
            return "hello from get all";
        }
      //  [Route("get-all-author")]
     //   [Route("[controller]/[action]")]
        public string GetAllAuthors()
        {
            return "hello from get all author";
        }

        //  [Route("books/{id}")]//A resource can have multiple unique URL
        //  [Route("books")]
        //  [Route("b")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello "+id;
        }
        

      //  [Route("books/{name}/author/{authorId}")]  //https://localhost:60350/books/aman/author/510
        public string Address(string name,int authorId)
        {
            return "Hello " + name+"\nYOUR ID:"+authorId;
        }

      //  [Route("search")] //https://localhost:60350/search?name=aman&authorId=10

        public string Search(string name, int authorId)
        {
            return "Hello " + name + "\nYOUR ID:" + authorId;
        }

    }
}
