using IESA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IESA.Controllers
{
    public class GamesCategoriesController : ApiController
    {
        public List<GamesCategories> Get() //Add_New_Competition.html - method OO1
        {
            GamesCategories gamecategories = new GamesCategories();
            return gamecategories.Read();
        }



        public int Post([FromBody] GamesCategories GameC) //Add_Game_Category.html
        {
            return GameC.InsertGameCategory();
        }




        [HttpGet]
        [Route("api/GamesCategories/mark1")]

        public void Put(int id, string status)
        {
            GamesCategories c = new GamesCategories();
            c.setNotactive(id, status);

        }


        //צריך לשים פה ROUTE שידע ללכת לכאן

        [HttpGet]
        [Route("api/GamesCategories/mark1")]

        public void Put(int id, string UpdateCategoryName)
        {
            GamesCategories c = new GamesCategories();
            c.ChangeName(id, UpdateCategoryName);

        }



    }
}