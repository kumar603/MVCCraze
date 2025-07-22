using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCraze.ViewModels
{
    /*****************************************************************************************************
            Writer       : Kiran Kumar J
            Description  : Know  how to Build Dynamic Web pages using views sending data bw views through
                            controllers and View through viewModels and Bind data efficiently
                            public class ProductsViewModel used in ProductsViewModelController 
            Created Date : 22 - July - 2025
            Created By   : Kiran Kumar
            Changed Date : 22 - July - 2025
            Changed By   : Kiran Kumar
            JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-3
      *****************************************************************************************************/
    public class ProductsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}