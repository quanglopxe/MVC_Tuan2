﻿using System.Web;
using System.Web.Mvc;

namespace DuongThuanQuang_Bai4_BTMAU
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
