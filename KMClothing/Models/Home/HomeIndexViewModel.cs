using KMClothing.DAL;
using KMClothing.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace KMClothing.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        dbKMClothingEntities context =new dbKMClothingEntities();
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }
            public  HomeIndexViewModel CreateModel(string search,int pageSize,int?page)
            {
            SqlParameter[] pram = new SqlParameter[] {
                   new SqlParameter("@search",search??(object)DBNull.Value)
                   };
            IPagedList<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch",pram).ToList().ToPagedList(page ?? 1, pageSize);

            return new HomeIndexViewModel
            {
                ListOfProducts = data
             };
            }
    }
}