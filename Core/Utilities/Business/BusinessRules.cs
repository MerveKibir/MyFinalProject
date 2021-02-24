using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params istediğin kadar IResult verebilmemizi sağladı
        {
            foreach (var logic in logics)
            {
                if(!logic.Success)
                {
                    return logic;//başarısız olanı business e bildirdik.
                }
            }
            return null;//başarılıysa gerek yok 
        }
    }
}
