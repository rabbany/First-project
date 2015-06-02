using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookInformationAPP.DAL;
using BookInformationAPP.Model;

namespace BookInformationAPP.BLL
{
    class CatagorieManager
    {
        CatagorieGetway aCatagorieGetway=new CatagorieGetway();
        Catagorie aCatagorie=new Catagorie();


        public List<Catagorie> ShowAllBookCatagorie()
        {
            return aCatagorieGetway.ShowAllBookCatagorie();
        }

        public string Insert(Catagorie aCatagorie)
        {

            if (aCatagorieGetway.Insert(aCatagorie)>0)
            {
                return "Insert Successfully";
            }
            else
            {
                return "Insert Fail";
            }
            

        }

    }
}
