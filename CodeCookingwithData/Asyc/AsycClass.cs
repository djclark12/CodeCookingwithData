using System;
using System.Web.Mvc;

namespace CodeCookingwithData.Asyc
{
    public class AsyncController : Controller
    {
        internal AsyncCallback Callback { get; set; }
        internal IAsyncResult Result { get; set; }
        internal Action<IAsyncResult> OnCompletion { get; set; }
    }
}