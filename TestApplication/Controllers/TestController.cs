using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;
using WebApplication4.Models;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase

        
        
    {
        JsonTable js = new JsonTable();
        TestClass cls = new TestClass(); 

        [HttpGet]
        [Route("Insert")]
        public async  Task<Object> Insert(int  Id,string? CatageryName,string? Name  , string? lastName,string? userName , DateTime dob,
           string? email,int phone ,int cnic , string? address  , string? password   , string? message  ,bool optionOne  ,bool optionTwo ) 
        {
            cls.Id = Id;
            cls.CatageryName = CatageryName;
            cls.Name = Name;
            cls.lastName = lastName;
            cls.userName = userName;
            cls.dob = dob;
            cls.email = email;
            cls.phone = phone;
            cls.cnic = cnic;
            cls.address = address;
            cls.password = password;
            cls.message = message;
            cls.optionOne = optionOne;
            cls.optionTwo = optionTwo;   
            cls.Mode = "InsertUpdate";

            var obj = js.DataTableToJSON(cls.Insert());
            return Ok(obj);
        }


        //https://localhost:44308/api/test/Insert?catageryName=abcd&name=sfvadsf&lastname=a&username=fasdf&dob=12/31/9999&email=dsfsd&phone=232&cnic=24242&address=asfsaf&password=abcd&message=sfsafs&optionone=true&optiontwo=true

        //[HttpGet]
        //[Route("Update")]
        //public async Task<Object> Update(int Id,string? CatageryName)
        //{
        //    cls.Mode = "Update";
        //    cls.Id = Id;
        //    cls.CatageryName = CatageryName;
      
           

        //    var obj = js.DataTableToJSON(cls.Update());
        //    return Ok(obj);
        //}


        [HttpGet]
        [Route("ReadAll")]
        public async Task<Object> ReadAll()
        {
            cls.Mode = "ReadAll";
          
            var obj = js.DataTableToJSON(cls.ReadAll());
            return Ok(obj);
        }

        [HttpGet]
        [Route("ReadById")]
        public async Task<Object> ReadById(int Id)
        {
            cls.Mode = "ReadById";
            cls.Id = Id;

            var obj = js.DataTableToJSON(cls.ReadById());
            return Ok(obj);
        }


        [HttpGet]
        [Route("Delete")]
        public async Task<Object> Delete(int Id)
        {
            cls.Mode = "Delete";
            cls.Id = Id;

            var obj = js.DataTableToJSON(cls.Delete());
            return Ok(obj);
        }

    }
}
